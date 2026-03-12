// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the entity to which the financial instruments are pledged.
    /// </summary>
    [KnownType(typeof(PledgeeFormat3Choice.TypeAndIdentification))]
    [KnownType(typeof(PledgeeFormat3Choice.Identification))]
    [KnownType(typeof(PledgeeFormat3Choice.Proprietary))]
    [JsonDerivedType(typeof(PledgeeFormat3Choice.TypeAndIdentification),nameof(PledgeeFormat3Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(PledgeeFormat3Choice.Identification),nameof(PledgeeFormat3Choice.Identification))]
    [JsonDerivedType(typeof(PledgeeFormat3Choice.Proprietary),nameof(PledgeeFormat3Choice.Proprietary))]
    [IsoId("_8tov4TnZEeWV5sr121Fc8A")]
    [DisplayName("Pledgee Format 3 Choice")]
    public abstract partial record PledgeeFormat3Choice_
    {
    }
}
