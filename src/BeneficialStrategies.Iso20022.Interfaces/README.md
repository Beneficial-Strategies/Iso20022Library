# BeneficialStrategies.Iso20022.Interfaces

```
dotnet add package BeneficialStrategies.Iso20022.Interfaces --version 0.7.0-alpha
```

An interface for every ISO 20022 message, component and choice: the shape of each type without the implementation.

The records of [BeneficialStrategies.Iso20022](https://www.nuget.org/packages/BeneficialStrategies.Iso20022) implement them. A class of your own (an entity, a DTO, a type of another message framework) can implement one too, and then everything written against the interface works with it.

```csharp
public sealed class MyIdentification : IGenericIdentification3
{
    public Max35Text Identification => "MINE-1";
    public Max35Text? Issuer => null;
}
```

* Namespaces are those of the records: `IGroupHeader93` is in `BeneficialStrategies.Iso20022.Components`.
* An interface is flat: it lists every member of its own version and inherits nothing but a marker of its kind (`IIsoComponent`, `IIsoChoice`, `IIsoChoiceVariant`, and `IOuterRecord` for a message; `Iso.KindOf(Type)` tells the kind of any type).
* A required member is not nullable, an optional one is; a member that may repeat is an `IEnumerable<T>`.
* A choice is an interface (`IPartyIdentification8Choice`) and each variant is an interface in the namespace named for the choice that also derives from it (`Choices.PartyIdentification8Choice.IBICOrBEI`); test for one with a type pattern.
* Primitive types (`Max35Text`, code sets, amounts) are those of [BeneficialStrategies.Iso20022.Primitives](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Primitives).

Targets netstandard2.0 (.NET Framework 4.6.1+, Mono, Unity), net8.0 and net10.0.
