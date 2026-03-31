// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the tracking information.
    /// </summary>
    [KnownType(typeof(Tracking1Choice.Indicator))]
    [KnownType(typeof(Tracking1Choice.Proprietary))]
    [JsonDerivedType(typeof(Tracking1Choice.Indicator), nameof(Tracking1Choice.Indicator))]
    [JsonDerivedType(typeof(Tracking1Choice.Proprietary), nameof(Tracking1Choice.Proprietary))]
    [IsoId("_Qt7bCNp-Ed-ak6NoX_4Aeg_-1227011207")]
    [DisplayName("Tracking 1 Choice")]
    public abstract record Tracking1Choice_ { }
}
