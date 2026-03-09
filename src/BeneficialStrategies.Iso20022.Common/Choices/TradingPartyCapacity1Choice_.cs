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
    [KnownType(typeof(TradingPartyCapacity1Choice.Code))]
    [KnownType(typeof(TradingPartyCapacity1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradingPartyCapacity1Choice.Code),nameof(TradingPartyCapacity1Choice.Code))]
    [JsonDerivedType(typeof(TradingPartyCapacity1Choice.Proprietary),nameof(TradingPartyCapacity1Choice.Proprietary))]
    #endif
    [IsoId("_AXUwVNokEeC60axPepSq7g_2103610848")]
    [DisplayName("Trading Party Capacity 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradingPartyCapacity1Choice_
    #else
    public abstract partial class TradingPartyCapacity1Choice_
    #endif
    {
    }
}
