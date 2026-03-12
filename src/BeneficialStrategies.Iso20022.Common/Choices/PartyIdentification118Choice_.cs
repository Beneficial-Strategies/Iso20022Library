// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification118Choice.LEI))]
    [KnownType(typeof(PartyIdentification118Choice.Proprietary))]
    [JsonDerivedType(typeof(PartyIdentification118Choice.LEI),nameof(PartyIdentification118Choice.LEI))]
    [JsonDerivedType(typeof(PartyIdentification118Choice.Proprietary),nameof(PartyIdentification118Choice.Proprietary))]
    [IsoId("_OtNpsasXEeayv9XxdmMwKQ")]
    [DisplayName("Party Identification 118 Choice")]
    public abstract partial record PartyIdentification118Choice_
    {
    }
}
