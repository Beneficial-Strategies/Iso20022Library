// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Asset class specific details of a derivative.
    /// </summary>
    [KnownType(typeof(AssetClassAttributes1Choice.Interest))]
    [KnownType(typeof(AssetClassAttributes1Choice.ForeignExchange))]
    [KnownType(typeof(AssetClassAttributes1Choice.Both))]
    [JsonDerivedType(
        typeof(AssetClassAttributes1Choice.Interest),
        nameof(AssetClassAttributes1Choice.Interest)
    )]
    [JsonDerivedType(
        typeof(AssetClassAttributes1Choice.ForeignExchange),
        nameof(AssetClassAttributes1Choice.ForeignExchange)
    )]
    [JsonDerivedType(
        typeof(AssetClassAttributes1Choice.Both),
        nameof(AssetClassAttributes1Choice.Both)
    )]
    [IsoId("_id4oJO94EeW7gabYEJmWIA")]
    [DisplayName("Asset Class Attributes 1 Choice")]
    public abstract record AssetClassAttributes1Choice_ { }
}
