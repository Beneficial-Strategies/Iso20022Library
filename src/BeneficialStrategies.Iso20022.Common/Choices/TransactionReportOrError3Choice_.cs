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
    /// Choice between transactions and booked entries held at the transaction administrator or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(TransactionReportOrError3Choice.BusinessReport))]
    [KnownType(typeof(TransactionReportOrError3Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionReportOrError3Choice.BusinessReport),nameof(TransactionReportOrError3Choice.BusinessReport))]
    [JsonDerivedType(typeof(TransactionReportOrError3Choice.OperationalError),nameof(TransactionReportOrError3Choice.OperationalError))]
    #endif
    [IsoId("_MwAZAZlPEee-Zps0fZQaFQ")]
    [DisplayName("Transaction Report Or Error 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionReportOrError3Choice_
    #else
    public abstract partial class TransactionReportOrError3Choice_
    #endif
    {
    }
}
