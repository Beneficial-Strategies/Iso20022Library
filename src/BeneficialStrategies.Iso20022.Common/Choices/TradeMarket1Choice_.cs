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
    /// Trade market identification using a externally defined code or proprietary identification.
    /// </summary>
    [KnownType(typeof(TradeMarket1Choice.Code))]
    [KnownType(typeof(TradeMarket1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeMarket1Choice.Code),nameof(TradeMarket1Choice.Code))]
    [JsonDerivedType(typeof(TradeMarket1Choice.Proprietary),nameof(TradeMarket1Choice.Proprietary))]
    #endif
    [IsoId("_OTgzMzEx-AOSNFX-8224498")]
    [DisplayName("Trade Market 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeMarket1Choice_
    #else
    public abstract partial class TradeMarket1Choice_
    #endif
    {
    }
}
