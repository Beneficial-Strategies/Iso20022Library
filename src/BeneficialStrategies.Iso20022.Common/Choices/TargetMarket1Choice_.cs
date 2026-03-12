// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the market for a type of investor expressed as a code.
    /// </summary>
    [KnownType(typeof(TargetMarket1Choice.Code))]
    [KnownType(typeof(TargetMarket1Choice.Proprietary))]
    [JsonDerivedType(typeof(TargetMarket1Choice.Code),nameof(TargetMarket1Choice.Code))]
    [JsonDerivedType(typeof(TargetMarket1Choice.Proprietary),nameof(TargetMarket1Choice.Proprietary))]
    [IsoId("_QM-3EDcMEeiIxKQErQxblg")]
    [DisplayName("Target Market 1 Choice")]
    public abstract partial record TargetMarket1Choice_
    {
    }
}
