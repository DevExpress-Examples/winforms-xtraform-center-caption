<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128623618/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T103979)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms XtraForm - How to center a form caption

This example creates a `CustomFormPainter` class that draws the title of the form in the center.

![](https://raw.githubusercontent.com/DevExpress-Examples/xtraform-how-to-center-align-a-header-caption-text-t103979/17.2.3%2B/media/winforms-xtraform-centered-title.png)

```csharp
protected override DevExpress.Skins.XtraForm.FormPainter CreateFormBorderPainter() {
    HorzAlignment formCaptionAlignment = HorzAlignment.Center;
    return new CustomFormPainter(this, LookAndFeel, formCaptionAlignment);
}
```

You can also use the [DevExpress DirectX Form](https://docs.devexpress.com/WindowsForms/403878/controls-and-libraries/forms-and-user-controls/direct-x-form) to deliver modern, web-inspired user interfaces and ensure that your apps support today’s high resolution/high DPI monitors.


## Files to Review

* [CustomFormPainter.cs](./CS/WindowsApplication1/Custom%20Form%20Painter/CustomFormPainter.cs) (VB: [CustomFormPainter.vb](./VB/WindowsApplication1/Custom%20Form%20Painter/CustomFormPainter.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
* [XtraForm1.cs](./CS/WindowsApplication1/XtraForm1.cs) (VB: [XtraForm1.vb](./VB/WindowsApplication1/XtraForm1.vb))


## Documentation

* [Forms and User Controls](https://docs.devexpress.com/WindowsForms/114561/controls-and-libraries/forms-and-user-controls)


## See Also

* [XtraForm - How to center-align a header caption text](https://supportcenter.devexpress.com/ticket/details/t103959/xtraform-how-to-center-align-a-header-caption-text)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-xtraform-center-caption&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-xtraform-center-caption&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
