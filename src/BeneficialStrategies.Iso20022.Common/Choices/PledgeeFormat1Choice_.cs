// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the entity to which the financial instruments are pledged.
    /// </summary>
    [KnownType(typeof(PledgeeFormat1Choice.TypeAndIdentification))]
    [KnownType(typeof(PledgeeFormat1Choice.Identification))]
    [KnownType(typeof(PledgeeFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(PledgeeFormat1Choice.TypeAndIdentification),nameof(PledgeeFormat1Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(PledgeeFormat1Choice.Identification),nameof(PledgeeFormat1Choice.Identification))]
    [JsonDerivedType(typeof(PledgeeFormat1Choice.Proprietary),nameof(PledgeeFormat1Choice.Proprietary))]
    [IsoId("_l0d3ME9iEeSn2-3swbRbzg")]
    [DisplayName("Pledgee Format 1 Choice")]
    public abstract partial record PledgeeFormat1Choice_
    {
    }
}
