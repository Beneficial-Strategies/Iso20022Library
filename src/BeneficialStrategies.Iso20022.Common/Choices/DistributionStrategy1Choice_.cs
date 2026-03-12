// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of a distribution strategy.
    /// </summary>
    [KnownType(typeof(DistributionStrategy1Choice.Code))]
    [KnownType(typeof(DistributionStrategy1Choice.Proprietary))]
    [JsonDerivedType(typeof(DistributionStrategy1Choice.Code),nameof(DistributionStrategy1Choice.Code))]
    [JsonDerivedType(typeof(DistributionStrategy1Choice.Proprietary),nameof(DistributionStrategy1Choice.Proprietary))]
    [IsoId("_1jAiQDcgEeidBoT_PugKiA")]
    [DisplayName("Distribution Strategy 1 Choice")]
    public abstract partial record DistributionStrategy1Choice_
    {
    }
}
