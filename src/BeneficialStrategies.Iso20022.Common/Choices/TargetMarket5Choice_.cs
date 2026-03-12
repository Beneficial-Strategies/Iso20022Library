// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of how a financial product is in scope of a target market parameter.
    /// </summary>
    [KnownType(typeof(TargetMarket5Choice.Type))]
    [KnownType(typeof(TargetMarket5Choice.Other))]
    [JsonDerivedType(typeof(TargetMarket5Choice.Type),nameof(TargetMarket5Choice.Type))]
    [JsonDerivedType(typeof(TargetMarket5Choice.Other),nameof(TargetMarket5Choice.Other))]
    [IsoId("_xLdncbVLEeqkjqDuFVh1-A")]
    [DisplayName("Target Market 5 Choice")]
    public abstract partial record TargetMarket5Choice_
    {
    }
}
