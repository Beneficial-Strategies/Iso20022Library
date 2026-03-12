// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification9Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification9Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification9Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification9Choice.BICOrBEI),nameof(PartyIdentification9Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification9Choice.ProprietaryIdentification),nameof(PartyIdentification9Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification9Choice.NameAndAddress),nameof(PartyIdentification9Choice.NameAndAddress))]
    [IsoId("_QRUXhtp-Ed-ak6NoX_4Aeg_967984948")]
    [DisplayName("Party Identification 9 Choice")]
    public abstract partial record PartyIdentification9Choice_
    {
    }
}
