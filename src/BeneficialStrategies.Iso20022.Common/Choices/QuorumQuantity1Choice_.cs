// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of quorum quantity.
    /// </summary>
    [KnownType(typeof(QuorumQuantity1Choice.QuorumQuantity))]
    [KnownType(typeof(QuorumQuantity1Choice.QuorumQuantityPercentage))]
    [JsonDerivedType(typeof(QuorumQuantity1Choice.QuorumQuantity),nameof(QuorumQuantity1Choice.QuorumQuantity))]
    [JsonDerivedType(typeof(QuorumQuantity1Choice.QuorumQuantityPercentage),nameof(QuorumQuantity1Choice.QuorumQuantityPercentage))]
    [IsoId("_RDiepdp-Ed-ak6NoX_4Aeg_1841562834")]
    [DisplayName("Quorum Quantity 1 Choice")]
    public abstract partial record QuorumQuantity1Choice_
    {
    }
}
