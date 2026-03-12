// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation using a choice between a BIC or the name and addres or the country code.
    /// </summary>
    [KnownType(typeof(PartyIdentification34Choice.BIC))]
    [KnownType(typeof(PartyIdentification34Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification34Choice.Country))]
    [JsonDerivedType(typeof(PartyIdentification34Choice.BIC),nameof(PartyIdentification34Choice.BIC))]
    [JsonDerivedType(typeof(PartyIdentification34Choice.NameAndAddress),nameof(PartyIdentification34Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification34Choice.Country),nameof(PartyIdentification34Choice.Country))]
    [IsoId("_QPiO0Np-Ed-ak6NoX_4Aeg_1306764655")]
    [DisplayName("Party Identification 34 Choice")]
    public abstract partial record PartyIdentification34Choice_
    {
    }
}
