// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party by BIC or by name and address.
    /// </summary>
    [KnownType(typeof(PartyIdentification29Choice.BIC))]
    [KnownType(typeof(PartyIdentification29Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification29Choice.BIC),nameof(PartyIdentification29Choice.BIC))]
    [JsonDerivedType(typeof(PartyIdentification29Choice.NameAndAddress),nameof(PartyIdentification29Choice.NameAndAddress))]
    [IsoId("_QFGgcNp-Ed-ak6NoX_4Aeg_-162334661")]
    [DisplayName("Party Identification 29 Choice")]
    public abstract partial record PartyIdentification29Choice_
    {
    }
}
