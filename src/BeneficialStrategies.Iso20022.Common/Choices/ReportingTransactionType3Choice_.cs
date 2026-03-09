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
    /// Choice between a new or a cancellation transaction.
    /// </summary>
    [KnownType(typeof(ReportingTransactionType3Choice.New))]
    [KnownType(typeof(ReportingTransactionType3Choice.Cancellation))]
    [KnownType(typeof(ReportingTransactionType3Choice.SupplementaryData))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReportingTransactionType3Choice.New),nameof(ReportingTransactionType3Choice.New))]
    [JsonDerivedType(typeof(ReportingTransactionType3Choice.Cancellation),nameof(ReportingTransactionType3Choice.Cancellation))]
    [JsonDerivedType(typeof(ReportingTransactionType3Choice.SupplementaryData),nameof(ReportingTransactionType3Choice.SupplementaryData))]
    #endif
    [IsoId("_6c12MZicEe2f7NHvXATP5g")]
    [DisplayName("Reporting Transaction Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReportingTransactionType3Choice_
    #else
    public abstract partial class ReportingTransactionType3Choice_
    #endif
    {
    }
}
