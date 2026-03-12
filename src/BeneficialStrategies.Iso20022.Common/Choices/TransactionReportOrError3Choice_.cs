// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between transactions and booked entries held at the transaction administrator or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(TransactionReportOrError3Choice.BusinessReport))]
    [KnownType(typeof(TransactionReportOrError3Choice.OperationalError))]
    [JsonDerivedType(typeof(TransactionReportOrError3Choice.BusinessReport),nameof(TransactionReportOrError3Choice.BusinessReport))]
    [JsonDerivedType(typeof(TransactionReportOrError3Choice.OperationalError),nameof(TransactionReportOrError3Choice.OperationalError))]
    [IsoId("_MwAZAZlPEee-Zps0fZQaFQ")]
    [DisplayName("Transaction Report Or Error 3 Choice")]
    public abstract partial record TransactionReportOrError3Choice_
    {
    }
}
