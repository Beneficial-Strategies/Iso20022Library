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
    [KnownType(typeof(TradeReport22Choice.New))]
    [KnownType(typeof(TradeReport22Choice.Modification))]
    [KnownType(typeof(TradeReport22Choice.Error))]
    [KnownType(typeof(TradeReport22Choice.EarlyTermination))]
    [KnownType(typeof(TradeReport22Choice.PositionComponent))]
    [KnownType(typeof(TradeReport22Choice.CollateralUpdate))]
    [KnownType(typeof(TradeReport22Choice.Correction))]
    [KnownType(typeof(TradeReport22Choice.ValuationUpdate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeReport22Choice.New),nameof(TradeReport22Choice.New))]
    [JsonDerivedType(typeof(TradeReport22Choice.Modification),nameof(TradeReport22Choice.Modification))]
    [JsonDerivedType(typeof(TradeReport22Choice.Error),nameof(TradeReport22Choice.Error))]
    [JsonDerivedType(typeof(TradeReport22Choice.EarlyTermination),nameof(TradeReport22Choice.EarlyTermination))]
    [JsonDerivedType(typeof(TradeReport22Choice.PositionComponent),nameof(TradeReport22Choice.PositionComponent))]
    [JsonDerivedType(typeof(TradeReport22Choice.CollateralUpdate),nameof(TradeReport22Choice.CollateralUpdate))]
    [JsonDerivedType(typeof(TradeReport22Choice.Correction),nameof(TradeReport22Choice.Correction))]
    [JsonDerivedType(typeof(TradeReport22Choice.ValuationUpdate),nameof(TradeReport22Choice.ValuationUpdate))]
    #endif
    [IsoId("_ztk1Ncg3EeuGrNSsxk3B0A")]
    [DisplayName("Trade Report 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeReport22Choice_
    #else
    public abstract partial class TradeReport22Choice_
    #endif
    {
    }
}
