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
    /// Provides details on the reported trade transactions.
    /// </summary>
    [KnownType(typeof(TradeReport10Choice.New))]
    [KnownType(typeof(TradeReport10Choice.Modification))]
    [KnownType(typeof(TradeReport10Choice.Error))]
    [KnownType(typeof(TradeReport10Choice.EarlyTermination))]
    [KnownType(typeof(TradeReport10Choice.PositionComponent))]
    [KnownType(typeof(TradeReport10Choice.CollateralUpdate))]
    [KnownType(typeof(TradeReport10Choice.Correction))]
    [KnownType(typeof(TradeReport10Choice.ValuationUpdate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeReport10Choice.New),nameof(TradeReport10Choice.New))]
    [JsonDerivedType(typeof(TradeReport10Choice.Modification),nameof(TradeReport10Choice.Modification))]
    [JsonDerivedType(typeof(TradeReport10Choice.Error),nameof(TradeReport10Choice.Error))]
    [JsonDerivedType(typeof(TradeReport10Choice.EarlyTermination),nameof(TradeReport10Choice.EarlyTermination))]
    [JsonDerivedType(typeof(TradeReport10Choice.PositionComponent),nameof(TradeReport10Choice.PositionComponent))]
    [JsonDerivedType(typeof(TradeReport10Choice.CollateralUpdate),nameof(TradeReport10Choice.CollateralUpdate))]
    [JsonDerivedType(typeof(TradeReport10Choice.Correction),nameof(TradeReport10Choice.Correction))]
    [JsonDerivedType(typeof(TradeReport10Choice.ValuationUpdate),nameof(TradeReport10Choice.ValuationUpdate))]
    #endif
    [IsoId("_34vr9f_qEemm3skPVSMJQg")]
    [DisplayName("Trade Report 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeReport10Choice_
    #else
    public abstract partial class TradeReport10Choice_
    #endif
    {
    }
}
