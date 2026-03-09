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
    [KnownType(typeof(TradingPartyCapacity4Choice.Code))]
    [KnownType(typeof(TradingPartyCapacity4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradingPartyCapacity4Choice.Code),nameof(TradingPartyCapacity4Choice.Code))]
    [JsonDerivedType(typeof(TradingPartyCapacity4Choice.Proprietary),nameof(TradingPartyCapacity4Choice.Proprietary))]
    #endif
    [IsoId("_HcLafZBjEeakHoV5BVecAQ")]
    [DisplayName("Trading Party Capacity 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradingPartyCapacity4Choice_
    #else
    public abstract partial class TradingPartyCapacity4Choice_
    #endif
    {
    }
}
