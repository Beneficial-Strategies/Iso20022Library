// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the opening closing information.
    /// </summary>
    [KnownType(typeof(OpeningClosing4Choice.Code))]
    [KnownType(typeof(OpeningClosing4Choice.Proprietary))]
    [JsonDerivedType(typeof(OpeningClosing4Choice.Code), nameof(OpeningClosing4Choice.Code))]
    [JsonDerivedType(
        typeof(OpeningClosing4Choice.Proprietary),
        nameof(OpeningClosing4Choice.Proprietary)
    )]
    [IsoId("_6SXYsZNLEeWGlc8L7oPDIg")]
    [DisplayName("Opening Closing 4 Choice")]
    public abstract record OpeningClosing4Choice_ { }
}
