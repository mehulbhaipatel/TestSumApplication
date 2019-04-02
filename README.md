# TestSumApplication
Test application for Sum of two numbers

How to run - To run the application unzip the code

Application structure -

-- Application follows MVC pattern -- It uses Razor syntax for the view

Application files and folders -

1> Controller --> HomeController - Controller which performs the addition of the number

2> View --> Home --> Index - UI for the addition

3> Models --> Contains all ViewModels of application -- ResultViewModel - base ViewModel of all ViewModels that returns from the controller to view, contains properties like IsSuccess and ErrorMsgs for view to identify if request succeded or failed -- AddViewModel -ViewModel for adding two numbers -- SumResultViewModel - ViewModel for returning result of Sum

4> Validations - Validations are performed using DataAnnotation. -- A basic validation for checking input data type is performed in AddViewModel file
