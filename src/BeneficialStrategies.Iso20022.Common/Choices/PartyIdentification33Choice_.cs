// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification33Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification33Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification33Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification33Choice.AnyBIC),nameof(PartyIdentification33Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification33Choice.ProprietaryIdentification),nameof(PartyIdentification33Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification33Choice.NameAndAddress),nameof(PartyIdentification33Choice.NameAndAddress))]
    [IsoId("_QPiO19p-Ed-ak6NoX_4Aeg_392714939")]
    [DisplayName("Party Identification 33 Choice")]
    public abstract partial record PartyIdentification33Choice_
    {
    }
}
