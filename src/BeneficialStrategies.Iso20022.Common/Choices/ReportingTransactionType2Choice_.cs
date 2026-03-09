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
    [KnownType(typeof(ReportingTransactionType2Choice.New))]
    [KnownType(typeof(ReportingTransactionType2Choice.Cancellation))]
    [KnownType(typeof(ReportingTransactionType2Choice.SupplementaryData))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReportingTransactionType2Choice.New),nameof(ReportingTransactionType2Choice.New))]
    [JsonDerivedType(typeof(ReportingTransactionType2Choice.Cancellation),nameof(ReportingTransactionType2Choice.Cancellation))]
    [JsonDerivedType(typeof(ReportingTransactionType2Choice.SupplementaryData),nameof(ReportingTransactionType2Choice.SupplementaryData))]
    #endif
    [IsoId("_W2U3kZ26Eeuwmdq0KtnICg")]
    [DisplayName("Reporting Transaction Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReportingTransactionType2Choice_
    #else
    public abstract partial class ReportingTransactionType2Choice_
    #endif
    {
    }
}
