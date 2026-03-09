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
    /// Defines the type of the query, a recurrent or an ad-hoc query.
    /// </summary>
    [KnownType(typeof(TradeReportQuery8Choice.AdHocQuery))]
    [KnownType(typeof(TradeReportQuery8Choice.RecurrentQuery))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeReportQuery8Choice.AdHocQuery),nameof(TradeReportQuery8Choice.AdHocQuery))]
    [JsonDerivedType(typeof(TradeReportQuery8Choice.RecurrentQuery),nameof(TradeReportQuery8Choice.RecurrentQuery))]
    #endif
    [IsoId("_4WULAf_lEemm3skPVSMJQg")]
    [DisplayName("Trade Report Query 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeReportQuery8Choice_
    #else
    public abstract partial class TradeReportQuery8Choice_
    #endif
    {
    }
}
