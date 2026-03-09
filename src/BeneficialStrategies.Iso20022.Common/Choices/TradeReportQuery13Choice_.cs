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
    [KnownType(typeof(TradeReportQuery13Choice.AdHocQuery))]
    [KnownType(typeof(TradeReportQuery13Choice.RecurrentQuery))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeReportQuery13Choice.AdHocQuery),nameof(TradeReportQuery13Choice.AdHocQuery))]
    [JsonDerivedType(typeof(TradeReportQuery13Choice.RecurrentQuery),nameof(TradeReportQuery13Choice.RecurrentQuery))]
    #endif
    [IsoId("_1LqeURfMEeyPHpqpKwtFdw")]
    [DisplayName("Trade Report Query 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeReportQuery13Choice_
    #else
    public abstract partial class TradeReportQuery13Choice_
    #endif
    {
    }
}
