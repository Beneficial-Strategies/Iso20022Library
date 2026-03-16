// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData11Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_BO3n864UEemB_csI4yyKLA")]
    [DisplayName("Report")]
    public record Report : TradeData11Choice_
    {
        /// <summary>
        /// Information about accepted and rejected reports and the reasons of rejection.
        /// </summary>
        [IsoId("_R_kY3u3tEemV1LTEADuPBQ")]
        [DisplayName("Report Statistics")]
        [IsoXmlTag("RptSttstcs")]
        public ValueList<DetailedReportStatistics5> ReportStatistics { get; init; } = [];

        // ID for the above is _R_kY3u3tEemV1LTEADuPBQ

        /// <summary>
        /// Information about accepted and rejected transactions and the reasons of rejection.
        /// </summary>
        [IsoId("_R_kY3-3tEemV1LTEADuPBQ")]
        [DisplayName("Transaction Statistics")]
        [IsoXmlTag("TxSttstcs")]
        public ValueList<DetailedTransactionStatistics10> TransactionStatistics { get; init; } = [];

        // ID for the above is _R_kY3-3tEemV1LTEADuPBQ

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_R_kY3e3tEemV1LTEADuPBQ")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
