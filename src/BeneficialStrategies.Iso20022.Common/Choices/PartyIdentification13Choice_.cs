// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification13Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification13Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification13Choice.BICOrBEI),
        nameof(PartyIdentification13Choice.BICOrBEI)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification13Choice.ProprietaryIdentification),
        nameof(PartyIdentification13Choice.ProprietaryIdentification)
    )]
    [IsoId("_QQIEsNp-Ed-ak6NoX_4Aeg_-1062714307")]
    [DisplayName("Party Identification 13 Choice")]
    public abstract record PartyIdentification13Choice_ { }
}
