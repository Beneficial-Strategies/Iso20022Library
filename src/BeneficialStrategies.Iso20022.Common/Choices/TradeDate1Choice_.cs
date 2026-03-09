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
    /// Choice of format for the trade date.
    /// </summary>
    [KnownType(typeof(TradeDate1Choice.Date))]
    [KnownType(typeof(TradeDate1Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeDate1Choice.Date),nameof(TradeDate1Choice.Date))]
    [JsonDerivedType(typeof(TradeDate1Choice.DateCode),nameof(TradeDate1Choice.DateCode))]
    #endif
    [IsoId("_Qvaowdp-Ed-ak6NoX_4Aeg_-681720433")]
    [DisplayName("Trade Date 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeDate1Choice_
    #else
    public abstract partial class TradeDate1Choice_
    #endif
    {
    }
}
