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
    /// Choice of format for the trading capacity.
    /// </summary>
    [KnownType(typeof(TradingPartyCapacity3Choice.Code))]
    [KnownType(typeof(TradingPartyCapacity3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradingPartyCapacity3Choice.Code),nameof(TradingPartyCapacity3Choice.Code))]
    [JsonDerivedType(typeof(TradingPartyCapacity3Choice.Proprietary),nameof(TradingPartyCapacity3Choice.Proprietary))]
    #endif
    [IsoId("_YLdZIY-1Eeaoj_JbcpWKgg")]
    [DisplayName("Trading Party Capacity 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradingPartyCapacity3Choice_
    #else
    public abstract partial class TradingPartyCapacity3Choice_
    #endif
    {
    }
}
