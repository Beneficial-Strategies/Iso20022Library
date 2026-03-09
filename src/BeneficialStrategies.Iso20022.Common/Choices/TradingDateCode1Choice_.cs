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
    /// Choice of format for the trading date code.
    /// </summary>
    [KnownType(typeof(TradingDateCode1Choice.Code))]
    [KnownType(typeof(TradingDateCode1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradingDateCode1Choice.Code),nameof(TradingDateCode1Choice.Code))]
    [JsonDerivedType(typeof(TradingDateCode1Choice.Proprietary),nameof(TradingDateCode1Choice.Proprietary))]
    #endif
    [IsoId("_AXUwUdokEeC60axPepSq7g_2130878160")]
    [DisplayName("Trading Date Code 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradingDateCode1Choice_
    #else
    public abstract partial class TradingDateCode1Choice_
    #endif
    {
    }
}
