// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the owner type.
    /// </summary>
    [KnownType(typeof(OwnershipType3Choice.Code))]
    [KnownType(typeof(OwnershipType3Choice.Proprietary))]
    [JsonDerivedType(typeof(OwnershipType3Choice.Code), nameof(OwnershipType3Choice.Code))]
    [JsonDerivedType(
        typeof(OwnershipType3Choice.Proprietary),
        nameof(OwnershipType3Choice.Proprietary)
    )]
    [IsoId("_ZExBAIzhEemXJvzC2Wyt1g")]
    [DisplayName("Ownership Type 3 Choice")]
    public abstract record OwnershipType3Choice_ { }
}
