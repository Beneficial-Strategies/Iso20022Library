# BeneficialStrategies.Iso20022.Primitives

The ISO 20022 primitive data types, code sets and external codes, with their format validation and JSON converters, without the message records.

* **Simple types** (`Max35Text`, `ActiveCurrencyAndAmount`-style decimals, dates, identifiers): immutable structs that refuse a value outside the ISO format.
* **Code sets** (enums) and **external codes** (structs such as `ActiveCurrencyCode`).
* **Amounts**: the currency-and-amount data types.

```
dotnet add package BeneficialStrategies.Iso20022.Primitives --version 0.7.0-alpha
```

The message records are in [BeneficialStrategies.Iso20022](https://www.nuget.org/packages/BeneficialStrategies.Iso20022), which depends on this package. Use this package alone when you want the types in your own model.
Namespaces are the same as in that package.
