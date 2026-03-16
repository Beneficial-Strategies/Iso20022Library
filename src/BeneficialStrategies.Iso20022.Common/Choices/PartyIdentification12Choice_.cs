// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [KnownType(typeof(PartyIdentification12Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification12Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification12Choice.Country))]
    [JsonDerivedType(
        typeof(PartyIdentification12Choice.BICOrBEI),
        nameof(PartyIdentification12Choice.BICOrBEI)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification12Choice.NameAndAddress),
        nameof(PartyIdentification12Choice.NameAndAddress)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification12Choice.Country),
        nameof(PartyIdentification12Choice.Country)
    )]
    [IsoId("_QQ3rltp-Ed-ak6NoX_4Aeg_1313053779")]
    [DisplayName("Party Identification 12 Choice")]
    public abstract record PartyIdentification12Choice_ { }
}
