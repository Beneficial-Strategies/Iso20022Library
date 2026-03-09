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
    [KnownType(typeof(TradeData9Choice.DataSetAction))]
    [KnownType(typeof(TradeData9Choice.Report))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeData9Choice.DataSetAction),nameof(TradeData9Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData9Choice.Report),nameof(TradeData9Choice.Report))]
    #endif
    [IsoId("_zLimQa1GEemojPqsRBB5Lg")]
    [DisplayName("Trade Data 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeData9Choice_
    #else
    public abstract partial class TradeData9Choice_
    #endif
    {
    }
}
