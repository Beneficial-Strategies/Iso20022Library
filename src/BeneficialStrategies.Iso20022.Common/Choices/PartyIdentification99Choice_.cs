// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party by a choice between a BIC or a name and address.
    /// </summary>
    [KnownType(typeof(PartyIdentification99Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification99Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification99Choice.NameAndAddress),nameof(PartyIdentification99Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification99Choice.AnyBIC),nameof(PartyIdentification99Choice.AnyBIC))]
    [IsoId("_-uWGYWz9EeWv_oZ1Y01DUQ")]
    [DisplayName("Party Identification 99 Choice")]
    public abstract partial record PartyIdentification99Choice_
    {
    }
}
