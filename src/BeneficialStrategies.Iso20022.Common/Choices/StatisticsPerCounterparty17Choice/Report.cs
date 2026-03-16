// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty17Choice
{
    /// <summary>
    /// Detailed statistics per counterparty.
    /// </summary>
    [IsoId("_x82ms1yGEe24CqbZJK5XxA")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public record Report : StatisticsPerCounterparty17Choice_
    {
        /// <summary>
        /// Reference date for statistics collection.
        /// </summary>
        [IsoId("_x9xMsVyGEe24CqbZJK5XxA")]
        [DisplayName("Reference Date")]
        [IsoXmlTag("RefDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ReferenceDate { get; init; }

        /// <summary>
        /// Total number of reports sent or received.
        /// </summary>
        [IsoId("_x9xMs1yGEe24CqbZJK5XxA")]
        [DisplayName("Total Number Of Reports")]
        [IsoXmlTag("TtlNbOfRpts")]
        [IsoSimpleType(IsoSimpleType.Max15NumericText)]
        public required IsoMax15NumericText TotalNumberOfReports { get; init; }

        /// <summary>
        /// Total number of reports accepted.
        /// </summary>
        [IsoId("_x9xMtVyGEe24CqbZJK5XxA")]
        [DisplayName("Total Number Of Reports Accepted")]
        [IsoXmlTag("TtlNbOfRptsAccptd")]
        [IsoSimpleType(IsoSimpleType.Max15NumericText)]
        public required IsoMax15NumericText TotalNumberOfReportsAccepted { get; init; }

        /// <summary>
        /// Total number of reports rejected.
        /// </summary>
        [IsoId("_x9xMt1yGEe24CqbZJK5XxA")]
        [DisplayName("Total Number Of Reports Rejected")]
        [IsoXmlTag("TtlNbOfRptsRjctd")]
        [IsoSimpleType(IsoSimpleType.Max15NumericText)]
        public required IsoMax15NumericText TotalNumberOfReportsRejected { get; init; }

        /// <summary>
        /// Total number of reports sent or received.
        /// </summary>
        [IsoId("_x9xMuVyGEe24CqbZJK5XxA")]
        [DisplayName("Total Number Of Transactions")]
        [IsoXmlTag("TtlNbOfTxs")]
        [IsoSimpleType(IsoSimpleType.Max15NumericText)]
        public required IsoMax15NumericText TotalNumberOfTransactions { get; init; }

        /// <summary>
        /// Total number of transactions accepted.
        /// </summary>
        [IsoId("_x9xMu1yGEe24CqbZJK5XxA")]
        [DisplayName("Total Number Of Transactions Accepted")]
        [IsoXmlTag("TtlNbOfTxsAccptd")]
        public required StatisticsPerActionType1 TotalNumberOfTransactionsAccepted { get; init; }

        /// <summary>
        /// Total number of transactions rejected.
        /// </summary>
        [IsoId("_x9xMvVyGEe24CqbZJK5XxA")]
        [DisplayName("Total Number Of Transactions Rejected")]
        [IsoXmlTag("TtlNbOfTxsRjctd")]
        public required StatisticsPerActionType1 TotalNumberOfTransactionsRejected { get; init; }

        /// <summary>
        /// Total number of rejected derivatives submitted by the report submitting entity for the reporting counterparty which were then corrected within ten business days.
        /// </summary>
        [IsoId("_x9xMv1yGEe24CqbZJK5XxA")]
        [DisplayName("Total Corrected Rejections")]
        [IsoXmlTag("TtlCrrctdRjctns")]
        public StatisticsPerActionType1? TotalCorrectedRejections { get; init; }

        /// <summary>
        /// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass validations.
        /// </summary>
        [IsoId("_x9xMwVyGEe24CqbZJK5XxA")]
        [DisplayName("Rejection Statistics")]
        [IsoXmlTag("RjctnSttstcs")]
        public ValueList<RejectionStatistics8> RejectionStatistics { get; init; } = [];
        // ID for the above is _x9xMwVyGEe24CqbZJK5XxA
    }
}
