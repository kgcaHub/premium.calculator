# Premium.Calculator

 Backend and Frontend Premium.Calculator 

## Starting 🚀


Project Structure:
  - Controller:  endpoints
    - PremiumController: has only Get Method wich recibes params as headers
  - Entity: 
    - CriteriaWildcard: entity wich contains the criteria of wildcard
    - PremiumResponse: entity with data to match and premium value
  - UseCase: 
    - Premium: has logic, validation and match with criteria.
  - DB:
    - CriteriaWildcard.json: has criteria data to match
  - Constants:
      - Invariable information or reusable methods
  - HttpException:
      - Custom exception to manage http codes to front end or other integrations

### Prerequisites and references 📋

Framework : NetCore 3.0
Swagger   : Swashbuckle.AspNetCore

## Building with 🛠️

* [NetCore 3.0](https://dotnet.microsoft.com/download/dotnet-core/3.0)
* [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore/) 
* [BulmaCSS] (https://cdn.jsdelivr.net/npm/bulma@0.9.0/css/bulma.min.css)

## Autores ✒️

* **Klinsmann Carhuas**  - [kgcaHub](https://github.com/kgcaHub)

## Licencia 📄

---
⌨️ con ❤️ por [kgcaHub](https://github.com/kgcaHub) 😊
