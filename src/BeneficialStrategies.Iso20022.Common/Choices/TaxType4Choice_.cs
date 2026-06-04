// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.TaxType4Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a code and proprietary format for a tax type.</summary>
    [IsoId("c747fb5c-f271-40b3-a402-46937374c425")]
    [DisplayName("Tax Type 4 Choice")]
    [KnownType(typeof(TaxType4Choice.Code))]
    [KnownType(typeof(TaxType4Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxType4Choice.Code))]
    [JsonDerivedType(typeof(TaxType4Choice.Proprietary))]
    public abstract record TaxType4Choice_
    {
    }
}
