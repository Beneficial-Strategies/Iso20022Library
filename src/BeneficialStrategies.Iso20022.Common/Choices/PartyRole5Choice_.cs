// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the role.
    /// </summary>
    [KnownType(typeof(PartyRole5Choice.Code))]
    [KnownType(typeof(PartyRole5Choice.Proprietary))]
    [JsonDerivedType(typeof(PartyRole5Choice.Code), nameof(PartyRole5Choice.Code))]
    [JsonDerivedType(typeof(PartyRole5Choice.Proprietary), nameof(PartyRole5Choice.Proprietary))]
    [IsoId("_pSfUISDSEeWCLu74WLgP4w")]
    [DisplayName("Party Role 5 Choice")]
    public abstract record PartyRole5Choice_ { }
}
