// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between transactions and booked entries held at the transaction administrator or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(TransactionReportOrError4Choice.BusinessReport))]
    [KnownType(typeof(TransactionReportOrError4Choice.OperationalError))]
    [JsonDerivedType(
        typeof(TransactionReportOrError4Choice.BusinessReport),
        nameof(TransactionReportOrError4Choice.BusinessReport)
    )]
    [JsonDerivedType(
        typeof(TransactionReportOrError4Choice.OperationalError),
        nameof(TransactionReportOrError4Choice.OperationalError)
    )]
    [IsoId("_WeuNsW49EeiU9cctagi5ow")]
    [DisplayName("Transaction Report Or Error 4 Choice")]
    public abstract record TransactionReportOrError4Choice_ { }
}
