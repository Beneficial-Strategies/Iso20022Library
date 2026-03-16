// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicates whether the contract was cleared or not.
    /// </summary>
    [KnownType(typeof(Cleared12Choice.Cleared))]
    [KnownType(typeof(Cleared12Choice.IntendToClear))]
    [KnownType(typeof(Cleared12Choice.NonCleared))]
    [JsonDerivedType(typeof(Cleared12Choice.Cleared), nameof(Cleared12Choice.Cleared))]
    [JsonDerivedType(typeof(Cleared12Choice.IntendToClear), nameof(Cleared12Choice.IntendToClear))]
    [JsonDerivedType(typeof(Cleared12Choice.NonCleared), nameof(Cleared12Choice.NonCleared))]
    [IsoId("_BT5_1-xYEemioJdkOVFBdw")]
    [DisplayName("Cleared 12 Choice")]
    public abstract record Cleared12Choice_ { }
}
