<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/172991040/18.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830453)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# How to iterate through all SubDocuments in a document

RichEditControl's document is split into logical parts - [SubDocuments](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.SubDocument). The document body, [Text Boxes](https://docs.devexpress.com/WindowsForms/18007/controls-and-libraries/rich-text-editor/richeditcontrol-document/document-elements/text-boxes), [comments](https://docs.devexpress.com/WindowsForms/18077/controls-and-libraries/rich-text-editor/richeditcontrol-document/document-elements/comments), [headers and footers](https://docs.devexpress.com/WindowsForms/8305/controls-and-libraries/rich-text-editor/richeditcontrol-document/document-elements/headers-and-footers) for different document sections are stored in separate SubDocuments. Each SubDocument contains its own textual content, Field, Bookmark, Hyperlink, Image and Shape collections. In scenarios when such document elements should be edited for the entire document, it's necessary to get all document SubDocuments and edit each SubDocument separately.

This example demonstrates how to implement an extension method for RichEditControl.Document and specify a delegate that will be executed for each SubDocument in a document. This approach allows modifying the entire document content in a single place.
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-rich-edit-iterate-through-all-sub-documents&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-rich-edit-iterate-through-all-sub-documents&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
