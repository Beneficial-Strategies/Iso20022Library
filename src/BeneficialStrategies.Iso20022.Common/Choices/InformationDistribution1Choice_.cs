// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of how information is to be distributed.
    /// </summary>
    [KnownType(typeof(InformationDistribution1Choice.Code))]
    [KnownType(typeof(InformationDistribution1Choice.Proprietary))]
    [JsonDerivedType(typeof(InformationDistribution1Choice.Code),nameof(InformationDistribution1Choice.Code))]
    [JsonDerivedType(typeof(InformationDistribution1Choice.Proprietary),nameof(InformationDistribution1Choice.Proprietary))]
    [IsoId("_9jvwACCUEeWJd9HF2tO7BA")]
    [DisplayName("Information Distribution 1 Choice")]
    public abstract partial record InformationDistribution1Choice_
    {
    }
}
