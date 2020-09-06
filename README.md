# PartialView in ASP.Net MVC5

# What is Partial View in MVC?

A partial view is a Razor mark-up file (.cshtml) that renders HTML output within another mark-up file's rendered output.

# When to use partial views

* Partial views are an effective way to Break up large mark-up files into smaller components.
* In a large, complex mark-up file composed of several logical pieces, there's an advantage to working with each piece isolated into a partial view. The code in the mark-up file is manageable because the mark-up only contains the overall page structure and references to partial views.
* Reduce the duplication of common mark-up content across mark-up files.
* When the same mark-up elements are used across mark-up files, a partial view removes the duplication of mark-up content into one partial view file. When the mark-up is changed in the partial view, it updates the rendered output of the mark-up files that use the partial view.
* Partial views shouldn't be used to maintain common layout elements. Common layout elements should be specified in _Layout.cshtml files.
* Don't use a partial view where complex rendering logic or code execution is required to render the mark-up. Instead of a partial view, use a view component.

# What are the different way of rendering Partial View in MVC?

There are 5 different way of rendering a partial view.
* Partial
* Render partial
* Action
* Render action
* JQuery load function

# What is the different between Partial and Render Partial in MVC?

Partial: The partial method returns an MvcHtmlString object. Basically, it stringifies the HTML content in the location where it was specified.

Example: @Html.Partial("_employee") 

Render Partial: The Render Partial method will not actually return any values or strings and instead, it will write the Partial View that is requested to the Response Stream through response write internally.

Example: @{ Html.Partial("_employee"); } 

# What is the different between Action and Render Action in MVC?

Action: Action method returns a string with the result.

Example: @Html.Action("Employee") 

Render Action: The Render Action method renders the result directly to the response which means it is more efficient if the action returns a large amount of HTML.

Example: @{ Html.Action("Employee"); }

# Difference between Html.Partial() and Html.RenderPartial() in ASP.NET MVC

|Html.Partial()|Html.RenderPartial()|
| --- | --- |
|Html.Partial returns html string.|Html.RenderPartial returns void.|
|Html.Partial injects the html string of the partial view into the main view.|Html.RenderPartial writes html in the response stream.|
|Performance is slow.|Perform is faster compared with HtmlPartial().|
|Html.Partial() need not to be inside the braces.|Html.RenderPartial must be inside braces @{ }.|

# What is the difference between View and Partial View?

|View|Partial View|
| --- | --- |
|MVC view contains the layout page.|Partial does not contain the layout page.|
|Before any view is rendered, ViewStart page is rendered.|It does not verify for a ViewStart.cshtml. We cannot put common code for a partial view within the ViewStart.cshtml page.|
|View might have mark-up tags like body, html, head, title, meta etc.|In MVC Partial view is designed specially to render within the view and just because of that it does not consist any mark up.|
|View is not lightweight as compare to Partial View.|We can pass a regular view to the Render Partial method.|

# For more information please visit below article 
https://www.c-sharpcorner.com/article/different-ways-of-render-partial-view-in-mvc/
