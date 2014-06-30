# FoodMe App — a workshop app built with AngularJS

This project is forked from a simplified meal ordering app for local restaurants built with AngularJS
and node.js backend (https://github.com/IgorMinar/foodme) for experimental purpose.

Updates in this forked project:

* Fixed the server code issue to use the latest node.js modules, including: logger —>
morgan, bodyParser —> body-parser
* Created a VS2013 solution (under vsproject folder) with the following:
  * A client side project leveraging the content from the original app folder
  * A server side project using WebAPI

To run the VS solution in the vsproject folder, the portnumber value (defined in app.js) needs to be updated to the right one from IIS Express on the local machine.
