// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat2Choice.Rate))]
    [KnownType(typeof(RateFormat2Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat2Choice.Rate),nameof(RateFormat2Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat2Choice.NotSpecifiedRate),nameof(RateFormat2Choice.NotSpecifiedRate))]
    [IsoId("_UPF0pNp-Ed-ak6NoX_4Aeg_1200621356")]
    [DisplayName("Rate Format 2 Choice")]
    public abstract partial record RateFormat2Choice_
    {
    }
}
