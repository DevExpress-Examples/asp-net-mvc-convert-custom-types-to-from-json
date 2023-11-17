<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128552755/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3338)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# ASP.NET MVC - How to pass complex objects to a callback Action as callback arguments
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3338/)**
<!-- run online end -->

This example demonstrates how to convert custom types to a JSON string on the client and parse this string on the server. The conversion is performed using the `$.toJSON` function that is declared in the [jquery.json-2.2.min](https://github.com/krinkle/jquery-json) file. The `JavaScriptSerializer.Deserialize` method parse the JSON string in a Controller's Action.

In this example, if it is not possible to deserialize user input, an exception is thrown.

## Files to Review

* [HomeController.cs](./CS/DevExpress.Razor/Controllers/HomeController.cs)
* [MyModel.cs](./CS/DevExpress.Razor/Models/MyModel.cs)
* [CallbackPanelPartial.cshtml](./CS/DevExpress.Razor/Views/Home/CallbackPanelPartial.cshtml)
* [EditorsPartial.cshtml](./CS/DevExpress.Razor/Views/Home/EditorsPartial.cshtml)
* [Index.cshtml](./CS/DevExpress.Razor/Views/Home/Index.cshtml)
