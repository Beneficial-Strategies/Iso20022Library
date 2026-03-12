// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Holding of financial instrument for collateral purposes.
    /// </summary>
    [KnownType(typeof(AssetHolding1Choice.Gold))]
    [KnownType(typeof(AssetHolding1Choice.Triparty))]
    [KnownType(typeof(AssetHolding1Choice.Cash))]
    [KnownType(typeof(AssetHolding1Choice.Security))]
    [KnownType(typeof(AssetHolding1Choice.Guarantee))]
    [KnownType(typeof(AssetHolding1Choice.Commodity))]
    [JsonDerivedType(typeof(AssetHolding1Choice.Gold),nameof(AssetHolding1Choice.Gold))]
    [JsonDerivedType(typeof(AssetHolding1Choice.Triparty),nameof(AssetHolding1Choice.Triparty))]
    [JsonDerivedType(typeof(AssetHolding1Choice.Cash),nameof(AssetHolding1Choice.Cash))]
    [JsonDerivedType(typeof(AssetHolding1Choice.Security),nameof(AssetHolding1Choice.Security))]
    [JsonDerivedType(typeof(AssetHolding1Choice.Guarantee),nameof(AssetHolding1Choice.Guarantee))]
    [JsonDerivedType(typeof(AssetHolding1Choice.Commodity),nameof(AssetHolding1Choice.Commodity))]
    [IsoId("_A8xYoK_5EeaE9YROwd69hA")]
    [DisplayName("Asset Holding 1 Choice")]
    public abstract partial record AssetHolding1Choice_
    {
    }
}
