// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the ownership type.
    /// </summary>
    [KnownType(typeof(OwnershipType1Choice.Code))]
    [KnownType(typeof(OwnershipType1Choice.Proprietary))]
    [JsonDerivedType(typeof(OwnershipType1Choice.Code), nameof(OwnershipType1Choice.Code))]
    [JsonDerivedType(
        typeof(OwnershipType1Choice.Proprietary),
        nameof(OwnershipType1Choice.Proprietary)
    )]
    [IsoId("_ZlS-0xc9EeK5g-3oYI0_9Q")]
    [DisplayName("Ownership Type 1 Choice")]
    public abstract record OwnershipType1Choice_ { }
}
