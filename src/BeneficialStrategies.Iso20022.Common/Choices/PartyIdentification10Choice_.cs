// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification10Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification10Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification10Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification10Choice.BICOrBEI),nameof(PartyIdentification10Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification10Choice.ProprietaryIdentification),nameof(PartyIdentification10Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification10Choice.NameAndAddress),nameof(PartyIdentification10Choice.NameAndAddress))]
    [IsoId("_QQR1tdp-Ed-ak6NoX_4Aeg_-1244141483")]
    [DisplayName("Party Identification 10 Choice")]
    public abstract partial record PartyIdentification10Choice_
    {
    }
}
