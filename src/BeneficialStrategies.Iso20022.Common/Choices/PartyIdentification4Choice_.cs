// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification4Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification4Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification4Choice.BICOrBEI),
        nameof(PartyIdentification4Choice.BICOrBEI)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification4Choice.ProprietaryIdentification),
        nameof(PartyIdentification4Choice.ProprietaryIdentification)
    )]
    [IsoId("_QRUXg9p-Ed-ak6NoX_4Aeg_1411958242")]
    [DisplayName("Party Identification 4 Choice")]
    public abstract record PartyIdentification4Choice_ { }
}
