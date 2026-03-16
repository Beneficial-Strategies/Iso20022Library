// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transaction Report Or Error7Choice.
    /// </summary>
    [KnownType(typeof(TransactionReportOrError7Choice.BusinessReport))]
    [KnownType(typeof(TransactionReportOrError7Choice.OperationalError))]
    [JsonDerivedType(
        typeof(TransactionReportOrError7Choice.BusinessReport),
        nameof(TransactionReportOrError7Choice.BusinessReport)
    )]
    [JsonDerivedType(
        typeof(TransactionReportOrError7Choice.OperationalError),
        nameof(TransactionReportOrError7Choice.OperationalError)
    )]
    [IsoId("_1nF2cTEyEe6g-ffJsqGiSA")]
    [DisplayName("Transaction Report Or Error7Choice")]
    public abstract record TransactionReportOrError7Choice_ { }
}
