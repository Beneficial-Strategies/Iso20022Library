// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.Period12Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a period or a period code.</summary>
    [IsoId("_qOnkwatmEfCqjuqNaaNXgw")]
    [DisplayName("Period 12 Choice")]
    [KnownType(typeof(Period12Choice.Period))]
    [KnownType(typeof(Period12Choice.PeriodCode))]
    [JsonDerivedType(typeof(Period12Choice.Period))]
    [JsonDerivedType(typeof(Period12Choice.PeriodCode))]
    public abstract record Period12Choice_
    {
    }
}
