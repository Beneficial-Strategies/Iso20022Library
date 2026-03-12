// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party. The party can be identified by giving a BIC or a proprietary code.
    /// </summary>
    [KnownType(typeof(PartyIdentification177Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification177Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification177Choice.AnyBIC),nameof(PartyIdentification177Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification177Choice.ProprietaryIdentification),nameof(PartyIdentification177Choice.ProprietaryIdentification))]
    [IsoId("_7X5zsdgvEeipBO1pkKK6zg")]
    [DisplayName("Party Identification 177 Choice")]
    public abstract partial record PartyIdentification177Choice_
    {
    }
}
