// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the ownership type.
    /// </summary>
    [KnownType(typeof(OwnershipType2Choice.Code))]
    [KnownType(typeof(OwnershipType2Choice.Proprietary))]
    [JsonDerivedType(typeof(OwnershipType2Choice.Code),nameof(OwnershipType2Choice.Code))]
    [JsonDerivedType(typeof(OwnershipType2Choice.Proprietary),nameof(OwnershipType2Choice.Proprietary))]
    [IsoId("_9FsRgb-GEeWfsa741pI6WA")]
    [DisplayName("Ownership Type 2 Choice")]
    public abstract partial record OwnershipType2Choice_
    {
    }
}
