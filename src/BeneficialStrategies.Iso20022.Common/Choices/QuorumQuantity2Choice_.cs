// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Quorum Quantity2Choice.
    /// </summary>
    [KnownType(typeof(QuorumQuantity2Choice.QuorumQuantity))]
    [KnownType(typeof(QuorumQuantity2Choice.QuorumQuantityPercentage))]
    [JsonDerivedType(
        typeof(QuorumQuantity2Choice.QuorumQuantity),
        nameof(QuorumQuantity2Choice.QuorumQuantity)
    )]
    [JsonDerivedType(
        typeof(QuorumQuantity2Choice.QuorumQuantityPercentage),
        nameof(QuorumQuantity2Choice.QuorumQuantityPercentage)
    )]
    [IsoId("_h-GeH5K5Ee-l-O3vIHRmRw")]
    [DisplayName("Quorum Quantity2Choice")]
    public abstract record QuorumQuantity2Choice_ { }
}
