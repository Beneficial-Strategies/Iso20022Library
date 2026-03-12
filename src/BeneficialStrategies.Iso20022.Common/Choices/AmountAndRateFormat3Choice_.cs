// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of rate formats.
    /// </summary>
    [KnownType(typeof(AmountAndRateFormat3Choice.Amount))]
    [KnownType(typeof(AmountAndRateFormat3Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(AmountAndRateFormat3Choice.Amount),nameof(AmountAndRateFormat3Choice.Amount))]
    [JsonDerivedType(typeof(AmountAndRateFormat3Choice.NotSpecifiedRate),nameof(AmountAndRateFormat3Choice.NotSpecifiedRate))]
    [IsoId("_UIFNs9p-Ed-ak6NoX_4Aeg_635648648")]
    [DisplayName("Amount And Rate Format 3 Choice")]
    public abstract partial record AmountAndRateFormat3Choice_
    {
    }
}
