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
    [KnownType(typeof(ReportingTransactionType1Choice.New))]
    [KnownType(typeof(ReportingTransactionType1Choice.Cancellation))]
    [KnownType(typeof(ReportingTransactionType1Choice.SupplementaryData))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReportingTransactionType1Choice.New),nameof(ReportingTransactionType1Choice.New))]
    [JsonDerivedType(typeof(ReportingTransactionType1Choice.Cancellation),nameof(ReportingTransactionType1Choice.Cancellation))]
    [JsonDerivedType(typeof(ReportingTransactionType1Choice.SupplementaryData),nameof(ReportingTransactionType1Choice.SupplementaryData))]
    #endif
    [IsoId("_JzZ68YG-EeaalK9UbuVGFw")]
    [DisplayName("Reporting Transaction Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReportingTransactionType1Choice_
    #else
    public abstract partial class ReportingTransactionType1Choice_
    #endif
    {
    }
}
