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
    /// Choice of format for the trading capacity of the party.
    /// </summary>
    [KnownType(typeof(TradeOriginator1Choice.Code))]
    [KnownType(typeof(TradeOriginator1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeOriginator1Choice.Code),nameof(TradeOriginator1Choice.Code))]
    [JsonDerivedType(typeof(TradeOriginator1Choice.Proprietary),nameof(TradeOriginator1Choice.Proprietary))]
    #endif
    [IsoId("_QsvINNp-Ed-ak6NoX_4Aeg_-1081021298")]
    [DisplayName("Trade Originator 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeOriginator1Choice_
    #else
    public abstract partial class TradeOriginator1Choice_
    #endif
    {
    }
}
