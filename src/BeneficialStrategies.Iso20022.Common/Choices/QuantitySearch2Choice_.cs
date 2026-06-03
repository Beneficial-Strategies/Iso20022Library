// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.QuantitySearch2Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between quantity search criteria.</summary>
    [IsoId("_eMzYAWqWEemz04WrKJaMEA")]
    [DisplayName("Quantity Search 2 Choice")]
    [KnownType(typeof(QuantitySearch2Choice.Quantity))]
    [KnownType(typeof(QuantitySearch2Choice.OriginalAndCurrentFace))]
    [JsonDerivedType(typeof(QuantitySearch2Choice.Quantity))]
    [JsonDerivedType(typeof(QuantitySearch2Choice.OriginalAndCurrentFace))]
    public abstract record QuantitySearch2Choice_
    {
    }
}
