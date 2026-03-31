// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the forex cancellation information.
    /// </summary>
    [KnownType(typeof(FXCancellation4Choice.Indicator))]
    [KnownType(typeof(FXCancellation4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FXCancellation4Choice.Indicator),
        nameof(FXCancellation4Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(FXCancellation4Choice.Proprietary),
        nameof(FXCancellation4Choice.Proprietary)
    )]
    [IsoId("_8T_SwZNLEeWGlc8L7oPDIg")]
    [DisplayName("FX Cancellation 4 Choice")]
    public abstract record FXCancellation4Choice_ { }
}
