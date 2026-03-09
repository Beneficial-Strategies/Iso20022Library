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
    /// Data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData13Choice.DataSetAction))]
    [KnownType(typeof(TradeData13Choice.State))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeData13Choice.DataSetAction),nameof(TradeData13Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData13Choice.State),nameof(TradeData13Choice.State))]
    #endif
    [IsoId("_xzjzMf_mEemm3skPVSMJQg")]
    [DisplayName("Trade Data 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeData13Choice_
    #else
    public abstract partial class TradeData13Choice_
    #endif
    {
    }
}
