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
    /// Choice of format for the trade date code.
    /// </summary>
    [KnownType(typeof(TradeDateCode1Choice.Code))]
    [KnownType(typeof(TradeDateCode1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeDateCode1Choice.Code),nameof(TradeDateCode1Choice.Code))]
    [JsonDerivedType(typeof(TradeDateCode1Choice.Proprietary),nameof(TradeDateCode1Choice.Proprietary))]
    #endif
    [IsoId("_QvRe1tp-Ed-ak6NoX_4Aeg_1239659216")]
    [DisplayName("Trade Date Code 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeDateCode1Choice_
    #else
    public abstract partial class TradeDateCode1Choice_
    #endif
    {
    }
}
