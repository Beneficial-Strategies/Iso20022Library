// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport21Choice
{
    /// <summary>
    /// Indicates whether transaction was reported by mistake and need to be removed.
    /// </summary>
    [IsoId("_SKn4Y8g2EeuGrNSsxk3B0A")]
    [DisplayName("Error")]
    public record Error : TradeReport21Choice_
    {
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_aRqQ8cg2EeuGrNSsxk3B0A")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? TechnicalRecordIdentification { get; init; }

        /// <summary>
        /// Date and time of submission of the report to the trade repository.
        /// </summary>
        [IsoId("_aRqQ88g2EeuGrNSsxk3B0A")]
        [DisplayName("Reporting Date Time")]
        [IsoXmlTag("RptgDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime ReportingDateTime { get; init; }

        /// <summary>
        /// Data specific to counterparties of the reported transaction.
        /// </summary>
        [IsoId("_aRqQ9cg2EeuGrNSsxk3B0A")]
        [DisplayName("Counterparty")]
        [IsoXmlTag("CtrPty")]
        public required Counterparty39 Counterparty { get; init; }

        /// <summary>
        /// Unique and unambiguous identification of the collateral portfolio.
        /// </summary>
        [IsoId("_aRqQ98g2EeuGrNSsxk3B0A")]
        [DisplayName("Collateral Portfolio Identification")]
        [IsoXmlTag("CollPrtflId")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public required IsoMax52Text CollateralPortfolioIdentification { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_aRqQ-cg2EeuGrNSsxk3B0A")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
