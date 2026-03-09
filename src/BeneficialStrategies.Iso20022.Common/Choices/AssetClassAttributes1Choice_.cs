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
    /// Asset class specific details of a derivative.
    /// </summary>
    [KnownType(typeof(AssetClassAttributes1Choice.Interest))]
    [KnownType(typeof(AssetClassAttributes1Choice.ForeignExchange))]
    [KnownType(typeof(AssetClassAttributes1Choice.Both))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassAttributes1Choice.Interest),nameof(AssetClassAttributes1Choice.Interest))]
    [JsonDerivedType(typeof(AssetClassAttributes1Choice.ForeignExchange),nameof(AssetClassAttributes1Choice.ForeignExchange))]
    [JsonDerivedType(typeof(AssetClassAttributes1Choice.Both),nameof(AssetClassAttributes1Choice.Both))]
    #endif
    [IsoId("_id4oJO94EeW7gabYEJmWIA")]
    [DisplayName("Asset Class Attributes 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassAttributes1Choice_
    #else
    public abstract partial class AssetClassAttributes1Choice_
    #endif
    {
    }
}
