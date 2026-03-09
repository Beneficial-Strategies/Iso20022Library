// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
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
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetHolding1Choice.Gold),nameof(AssetHolding1Choice.Gold))]
    [JsonDerivedType(typeof(AssetHolding1Choice.Triparty),nameof(AssetHolding1Choice.Triparty))]
    [JsonDerivedType(typeof(AssetHolding1Choice.Cash),nameof(AssetHolding1Choice.Cash))]
    [JsonDerivedType(typeof(AssetHolding1Choice.Security),nameof(AssetHolding1Choice.Security))]
    [JsonDerivedType(typeof(AssetHolding1Choice.Guarantee),nameof(AssetHolding1Choice.Guarantee))]
    [JsonDerivedType(typeof(AssetHolding1Choice.Commodity),nameof(AssetHolding1Choice.Commodity))]
    #endif
    [IsoId("_A8xYoK_5EeaE9YROwd69hA")]
    [DisplayName("Asset Holding 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetHolding1Choice_
    #else
    public abstract partial class AssetHolding1Choice_
    #endif
    {
    }
}
