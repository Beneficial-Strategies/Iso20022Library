// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the role of the party.
    /// </summary>
    [KnownType(typeof(PartyRole6Choice.Code))]
    [KnownType(typeof(PartyRole6Choice.Proprietary))]
    [JsonDerivedType(typeof(PartyRole6Choice.Code), nameof(PartyRole6Choice.Code))]
    [JsonDerivedType(typeof(PartyRole6Choice.Proprietary), nameof(PartyRole6Choice.Proprietary))]
    [IsoId("_Ny0Ls46OEemzmeK8_tPygg")]
    [DisplayName("Party Role 6 Choice")]
    public abstract record PartyRole6Choice_ { }
}
