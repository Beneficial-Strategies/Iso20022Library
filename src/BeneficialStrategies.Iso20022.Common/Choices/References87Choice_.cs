// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.References87Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between previous reference and other reference for additional references.</summary>
    [IsoId("392d4318-696c-43fe-93d4-6de1e67e2ebf")]
    [DisplayName("References 87 Choice")]
    [KnownType(typeof(References87Choice.PreviousReference))]
    [KnownType(typeof(References87Choice.OtherReference))]
    [JsonDerivedType(typeof(References87Choice.PreviousReference))]
    [JsonDerivedType(typeof(References87Choice.OtherReference))]
    public abstract record References87Choice_
    {
    }
}
