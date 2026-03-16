// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DetailedTransactionStatistics6Choice
{
    /// <summary>
    /// Information about number of transactions accepted and rejected and the reasons of the rejections.
    /// </summary>
    [IsoId("_x_mYs1yGEe24CqbZJK5XxA")]
    [DisplayName("Detailed Statistics")]
    [IsoXmlTag("DtldSttstcs")]
    public record DetailedStatistics : DetailedTransactionStatistics6Choice_
    {
        /// <summary>
        /// Total number of reports sent or received.
        /// </summary>
        [IsoId("_yAw2UVyGEe24CqbZJK5XxA")]
        [DisplayName("Total Number Of Transactions")]
        [IsoXmlTag("TtlNbOfTxs")]
        [IsoSimpleType(IsoSimpleType.Max15NumericText)]
        public required IsoMax15NumericText TotalNumberOfTransactions { get; init; }

        /// <summary>
        /// Total number of transactions accepted.
        /// </summary>
        [IsoId("_yAw2U1yGEe24CqbZJK5XxA")]
        [DisplayName("Total Number Of Transactions Accepted")]
        [IsoXmlTag("TtlNbOfTxsAccptd")]
        public required StatisticsPerActionType1 TotalNumberOfTransactionsAccepted { get; init; }

        /// <summary>
        /// Total number of transactions rejected.
        /// </summary>
        [IsoId("_yAw2VVyGEe24CqbZJK5XxA")]
        [DisplayName("Total Number Of Transactions Rejected")]
        [IsoXmlTag("TtlNbOfTxsRjctd")]
        public required StatisticsPerActionType1 TotalNumberOfTransactionsRejected { get; init; }

        /// <summary>
        /// Total number of rejected derivatives submitted by the report submitting entity for the reporting counterparty which were then corrected within ten business days.
        /// </summary>
        [IsoId("_yAw2V1yGEe24CqbZJK5XxA")]
        [DisplayName("Total Corrected Rejections")]
        [IsoXmlTag("TtlCrrctdRjctns")]
        public StatisticsPerActionType1? TotalCorrectedRejections { get; init; }

        /// <summary>
        /// Details on transactions rejected per error code.
        /// </summary>
        [IsoId("_yAw2WVyGEe24CqbZJK5XxA")]
        [DisplayName("Transactions Rejections Reason")]
        [IsoXmlTag("TxsRjctnsRsn")]
        public RejectionReason71? TransactionsRejectionsReason { get; init; }
    }
}
