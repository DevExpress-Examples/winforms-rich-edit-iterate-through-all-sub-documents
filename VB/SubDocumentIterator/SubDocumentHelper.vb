Imports DevExpress.XtraRichEdit.API.Native
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SubDocumentIterator
	Public Module SubDocumentHelper
		Public Delegate Sub SubDocumentDelegate(ByVal subDocument As SubDocument)
		<System.Runtime.CompilerServices.Extension> _
		Public Sub ForEachSubDocument(ByVal document As Document, ByVal subDocumentProcessor As SubDocumentDelegate)
			subDocumentProcessor(document)
			ProcessShapes(document.Shapes, subDocumentProcessor)
			ProcessComments(document.Comments, subDocumentProcessor)
			For Each section As Section In document.Sections
				ProcessSection(section, HeaderFooterType.First, subDocumentProcessor)
				ProcessSection(section, HeaderFooterType.Odd, subDocumentProcessor)
				ProcessSection(section, HeaderFooterType.Even, subDocumentProcessor)
			Next section
		End Sub
		Private Sub ProcessSection(ByVal section As Section, ByVal headerFooterType As HeaderFooterType, ByVal subDocumentProcessor As SubDocumentDelegate)
			If section.HasHeader(headerFooterType) Then
				Dim header As SubDocument = section.BeginUpdateHeader(headerFooterType)
				subDocumentProcessor(header)
				ProcessShapes(header.Shapes, subDocumentProcessor)
				section.EndUpdateHeader(header)
			End If
			If section.HasFooter(headerFooterType) Then
				Dim footer As SubDocument = section.BeginUpdateFooter(headerFooterType)
				subDocumentProcessor(footer)
				ProcessShapes(footer.Shapes, subDocumentProcessor)
				section.EndUpdateFooter(footer)
			End If
		End Sub
		Private Sub ProcessShapes(ByVal shapes As ShapeCollection, ByVal subDocumentProcessor As SubDocumentDelegate)
			For Each shape As Shape In shapes
				If shape.ShapeFormat.TextBox IsNot Nothing Then
					subDocumentProcessor(shape.ShapeFormat.TextBox.Document)
				End If
			Next shape
		End Sub
		Private Sub ProcessComments(ByVal comments As CommentCollection, ByVal subDocumentProcessor As SubDocumentDelegate)
			For Each comment As Comment In comments
				Dim commentSubDocument As SubDocument = comment.BeginUpdate()
				subDocumentProcessor(commentSubDocument)
				comment.EndUpdate(commentSubDocument)
			Next comment
		End Sub
	End Module
End Namespace
