# Fluent-Validation
**Why should we use Fluent Validations :**
- Fluent validation promotes a clear separation of validation logic from your business logic. This separation helps keeps codebase clean and organized, making it easier to maintain and understand.
- It can automatically validate requests in controllers. It integrates with the model binding process, allowing to apply validation rules to request parameters and models easily.
- It provides detailed error messages, which can be helpful for both developers during development and end-users when they encounter validation issues.


**Implementing Fluent validation in NET 6 : **

Install Nuget packages : 
- Install-Package FluentValidation
- Install-Package FluentValidation.DependencyInjectionExtensions


Create the Validator Class

![Capture](https://github.com/HqRhn/MovieCatalog/assets/141786593/4564a593-ef73-4810-8f70-fae96c7539ef)

Register the fluent validation service and validator class

![Capture](https://github.com/HqRhn/MovieCatalog/assets/141786593/f2d0228a-e879-40e8-8ce6-8262e4fa204d)


  Validation Result :

  ![Capture](https://github.com/HqRhn/MovieCatalog/assets/141786593/9b52bf17-7bfc-4e39-9095-05a02c405312)
