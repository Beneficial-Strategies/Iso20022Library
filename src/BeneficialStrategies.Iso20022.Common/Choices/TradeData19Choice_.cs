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
    /// Position/transaction reporting under EMIR regulation.
    /// </summary>
    [KnownType(typeof(TradeData19Choice.DataSetAction))]
    [KnownType(typeof(TradeData19Choice.Report))]
    [KnownType(typeof(TradeData19Choice.State))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeData19Choice.DataSetAction),nameof(TradeData19Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData19Choice.Report),nameof(TradeData19Choice.Report))]
    [JsonDerivedType(typeof(TradeData19Choice.State),nameof(TradeData19Choice.State))]
    #endif
    [IsoId("_mijCQXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Trade Data 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeData19Choice_
    #else
    public abstract partial class TradeData19Choice_
    #endif
    {
    }
}
