// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an absolute value.
    /// </summary>
    [KnownType(typeof(RateOrAbsoluteValue1Choice.RateValue))]
    [KnownType(typeof(RateOrAbsoluteValue1Choice.AbsoluteValue))]
    [JsonDerivedType(typeof(RateOrAbsoluteValue1Choice.RateValue),nameof(RateOrAbsoluteValue1Choice.RateValue))]
    [JsonDerivedType(typeof(RateOrAbsoluteValue1Choice.AbsoluteValue),nameof(RateOrAbsoluteValue1Choice.AbsoluteValue))]
    [IsoId("_RBTC99p-Ed-ak6NoX_4Aeg_955902350")]
    [DisplayName("Rate Or Absolute Value 1 Choice")]
    public abstract partial record RateOrAbsoluteValue1Choice_
    {
    }
}
