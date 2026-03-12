// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification30Choice.BIC))]
    [KnownType(typeof(PartyIdentification30Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification30Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification30Choice.BIC),nameof(PartyIdentification30Choice.BIC))]
    [JsonDerivedType(typeof(PartyIdentification30Choice.NameAndAddress),nameof(PartyIdentification30Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification30Choice.ProprietaryIdentification),nameof(PartyIdentification30Choice.ProprietaryIdentification))]
    [IsoId("_QQIEttp-Ed-ak6NoX_4Aeg_-73053058")]
    [DisplayName("Party Identification 30 Choice")]
    public abstract partial record PartyIdentification30Choice_
    {
    }
}
