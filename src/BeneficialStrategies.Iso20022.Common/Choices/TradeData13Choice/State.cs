// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData13Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_x460U__mEemm3skPVSMJQg")]
    [DisplayName("State")]
    [IsoXmlTag("Stat")]
    public record State : TradeData13Choice_
    {
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_x-Irgf_mEemm3skPVSMJQg")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? TechnicalRecordIdentification { get; init; }

        /// <summary>
        /// Date and time of submission of the report to the trade repository.
        /// </summary>
        [IsoId("_x-Irg__mEemm3skPVSMJQg")]
        [DisplayName("Reporting Date Time")]
        [IsoXmlTag("RptgDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime ReportingDateTime { get; init; }

        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_x-Irhf_mEemm3skPVSMJQg")]
        [DisplayName("Event Date")]
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate EventDate { get; init; }

        /// <summary>
        /// Data specific to counterparties of the reported transaction.
        /// </summary>
        [IsoId("_x-Irh__mEemm3skPVSMJQg")]
        [DisplayName("Counterparty")]
        [IsoXmlTag("CtrPty")]
        public required Counterparty30 Counterparty { get; init; }

        /// <summary>
        /// Unique and unambiguous identification of the collateral portfolio.
        /// </summary>
        [IsoId("_x-Irif_mEemm3skPVSMJQg")]
        [DisplayName("Collateral Portfolio Identification")]
        [IsoXmlTag("CollPrtflId")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public required IsoMax52Text CollateralPortfolioIdentification { get; init; }

        /// <summary>
        /// Information on posted collateral and margin.
        /// </summary>
        [IsoId("_x-Iri__mEemm3skPVSMJQg")]
        [DisplayName("Posted Margin Or Collateral")]
        [IsoXmlTag("PstdMrgnOrColl")]
        public PostedMarginOrCollateral3? PostedMarginOrCollateral { get; init; }

        /// <summary>
        /// Information on received collateral and margin.
        /// </summary>
        [IsoId("_x-Irjf_mEemm3skPVSMJQg")]
        [DisplayName("Received Margin Or Collateral")]
        [IsoXmlTag("RcvdMrgnOrColl")]
        public ReceivedMarginOrCollateral3? ReceivedMarginOrCollateral { get; init; }

        /// <summary>
        /// List of possible values for TRs reconciliation purposes.
        /// </summary>
        [IsoId("_x-Irj__mEemm3skPVSMJQg")]
        [DisplayName("Reconciliation Flag")]
        [IsoXmlTag("RcncltnFlg")]
        public ReconciliationFlag1? ReconciliationFlag { get; init; }

        /// <summary>
        /// Contract modification details expressed as an action type and a reporting level type.
        /// </summary>
        [IsoId("_x-Irkf_mEemm3skPVSMJQg")]
        [DisplayName("Contract Modification")]
        [IsoXmlTag("CtrctMod")]
        public required ContractModification3 ContractModification { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_x-Irk__mEemm3skPVSMJQg")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
