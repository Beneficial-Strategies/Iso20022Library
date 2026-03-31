// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the opening closing information.
    /// </summary>
    [KnownType(typeof(OpeningClosing1Choice.Code))]
    [KnownType(typeof(OpeningClosing1Choice.Proprietary))]
    [JsonDerivedType(typeof(OpeningClosing1Choice.Code), nameof(OpeningClosing1Choice.Code))]
    [JsonDerivedType(
        typeof(OpeningClosing1Choice.Proprietary),
        nameof(OpeningClosing1Choice.Proprietary)
    )]
    [IsoId("_Qs45Ndp-Ed-ak6NoX_4Aeg_-775464350")]
    [DisplayName("Opening Closing 1 Choice")]
    public abstract record OpeningClosing1Choice_ { }
}
