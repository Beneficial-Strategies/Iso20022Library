// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the rate as a percentage or a text.
    /// </summary>
    [KnownType(typeof(RateType4Choice.Percentage))]
    [KnownType(typeof(RateType4Choice.Other))]
    [JsonDerivedType(typeof(RateType4Choice.Percentage), nameof(RateType4Choice.Percentage))]
    [JsonDerivedType(typeof(RateType4Choice.Other), nameof(RateType4Choice.Other))]
    [IsoId("_Rp-zkdp-Ed-ak6NoX_4Aeg_-171034137")]
    [DisplayName("Rate Type 4 Choice")]
    public abstract record RateType4Choice_ { }
}
