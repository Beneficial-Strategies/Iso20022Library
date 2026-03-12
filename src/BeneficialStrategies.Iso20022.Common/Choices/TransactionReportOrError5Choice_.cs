// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between transactions and booked entries held at the transaction administrator or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(TransactionReportOrError5Choice.BusinessReport))]
    [KnownType(typeof(TransactionReportOrError5Choice.OperationalError))]
    [JsonDerivedType(typeof(TransactionReportOrError5Choice.BusinessReport),nameof(TransactionReportOrError5Choice.BusinessReport))]
    [JsonDerivedType(typeof(TransactionReportOrError5Choice.OperationalError),nameof(TransactionReportOrError5Choice.OperationalError))]
    [IsoId("_dc83EdcZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction Report Or Error 5 Choice")]
    public abstract partial record TransactionReportOrError5Choice_
    {
    }
}
