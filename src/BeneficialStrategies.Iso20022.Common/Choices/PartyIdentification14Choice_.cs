// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification14Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification14Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification14Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification14Choice.Country))]
    [JsonDerivedType(typeof(PartyIdentification14Choice.BICOrBEI),nameof(PartyIdentification14Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification14Choice.ProprietaryIdentification),nameof(PartyIdentification14Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification14Choice.NameAndAddress),nameof(PartyIdentification14Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification14Choice.Country),nameof(PartyIdentification14Choice.Country))]
    [IsoId("_QP1Jxtp-Ed-ak6NoX_4Aeg_990739070")]
    [DisplayName("Party Identification 14 Choice")]
    public abstract partial record PartyIdentification14Choice_
    {
    }
}
