// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ServiceCategory1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Agreement under which or rules under which the transaction should be processed.</summary>
    [IsoId("_DguWIIQ7Eey-Qu7YK0yj_A")]
    [DisplayName("Service Category 1 Choice")]
    [KnownType(typeof(ServiceCategory1Choice.Code))]
    [KnownType(typeof(ServiceCategory1Choice.Proprietary))]
    [JsonDerivedType(typeof(ServiceCategory1Choice.Code))]
    [JsonDerivedType(typeof(ServiceCategory1Choice.Proprietary))]
    public abstract record ServiceCategory1Choice_
    {
    }
}
