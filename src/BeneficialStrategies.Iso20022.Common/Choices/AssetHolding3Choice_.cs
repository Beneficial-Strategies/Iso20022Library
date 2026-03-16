// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Asset Holding3Choice.
    /// </summary>
    [KnownType(typeof(AssetHolding3Choice.Cash))]
    [KnownType(typeof(AssetHolding3Choice.Commodity))]
    [KnownType(typeof(AssetHolding3Choice.Gold))]
    [KnownType(typeof(AssetHolding3Choice.Guarantee))]
    [KnownType(typeof(AssetHolding3Choice.Security))]
    [KnownType(typeof(AssetHolding3Choice.Triparty))]
    [JsonDerivedType(typeof(AssetHolding3Choice.Cash),nameof(AssetHolding3Choice.Cash))]
    [JsonDerivedType(typeof(AssetHolding3Choice.Commodity),nameof(AssetHolding3Choice.Commodity))]
    [JsonDerivedType(typeof(AssetHolding3Choice.Gold),nameof(AssetHolding3Choice.Gold))]
    [JsonDerivedType(typeof(AssetHolding3Choice.Guarantee),nameof(AssetHolding3Choice.Guarantee))]
    [JsonDerivedType(typeof(AssetHolding3Choice.Security),nameof(AssetHolding3Choice.Security))]
    [JsonDerivedType(typeof(AssetHolding3Choice.Triparty),nameof(AssetHolding3Choice.Triparty))]
    [IsoId("_eUalMShJEe2H2s7qerne1w")]
    [DisplayName("Asset Holding3Choice")]
    public abstract partial record AssetHolding3Choice_
    {
    }
}
