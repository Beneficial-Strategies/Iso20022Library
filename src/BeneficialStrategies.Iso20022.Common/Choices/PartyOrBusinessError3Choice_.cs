// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Report between the party reference data or a business error.
    /// </summary>
    [KnownType(typeof(PartyOrBusinessError3Choice.SystemParty))]
    [KnownType(typeof(PartyOrBusinessError3Choice.BusinessError))]
    [JsonDerivedType(typeof(PartyOrBusinessError3Choice.SystemParty),nameof(PartyOrBusinessError3Choice.SystemParty))]
    [JsonDerivedType(typeof(PartyOrBusinessError3Choice.BusinessError),nameof(PartyOrBusinessError3Choice.BusinessError))]
    [IsoId("_0CyYAYwXEei289CGNqs21g")]
    [DisplayName("Party Or Business Error 3 Choice")]
    public abstract partial record PartyOrBusinessError3Choice_
    {
    }
}
