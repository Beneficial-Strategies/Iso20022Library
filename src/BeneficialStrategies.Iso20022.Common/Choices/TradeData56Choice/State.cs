// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData56Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_SBzrA152Ee2a_-MvhEjKmA")]
    [DisplayName("State")]
    [IsoXmlTag("Stat")]
    public record State : TradeData56Choice_
    {
        /// <summary>
        /// Date and time of submission of the report to the trade repository.
        /// </summary>
        [IsoId("_SCx7YV52Ee2a_-MvhEjKmA")]
        [DisplayName("Reporting Time Stamp")]
        [IsoXmlTag("RptgTmStmp")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? ReportingTimeStamp { get; init; }

        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_SCx7Y152Ee2a_-MvhEjKmA")]
        [DisplayName("Counterparty Identification")]
        [IsoXmlTag("CtrPtyId")]
        public required TradeCounterpartyReport20 CounterpartyIdentification { get; init; }

        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_SCx7ZV52Ee2a_-MvhEjKmA")]
        [DisplayName("Event Date")]
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? EventDate { get; init; }

        /// <summary>
        /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier as agreed with the counterparty.
        /// </summary>
        [IsoId("_SCx7Z152Ee2a_-MvhEjKmA")]
        [DisplayName("Transaction Identification")]
        [IsoXmlTag("TxId")]
        public UniqueTransactionIdentifier2Choice_? TransactionIdentification { get; init; }

        /// <summary>
        /// Information related to collateral agreement existing between counterparties.
        /// </summary>
        [IsoId("_SCx7aV52Ee2a_-MvhEjKmA")]
        [DisplayName("Collateral")]
        [IsoXmlTag("Coll")]
        public required MarginCollateralReport4 Collateral { get; init; }

        /// <summary>
        /// Information on posted collateral and margin.
        /// </summary>
        [IsoId("_SCx7a152Ee2a_-MvhEjKmA")]
        [DisplayName("Posted Margin Or Collateral")]
        [IsoXmlTag("PstdMrgnOrColl")]
        public PostedMarginOrCollateral6? PostedMarginOrCollateral { get; init; }

        /// <summary>
        /// Information on received collateral and margin.
        /// </summary>
        [IsoId("_SCx7bV52Ee2a_-MvhEjKmA")]
        [DisplayName("Received Margin Or Collateral")]
        [IsoXmlTag("RcvdMrgnOrColl")]
        public ReceivedMarginOrCollateral6? ReceivedMarginOrCollateral { get; init; }

        /// <summary>
        /// Indicates if a counterparty rating trigger is agreed by the counterparties for the collateral posted by the reporting counterparty.
        /// Usage: If the element is not present, the CounterpartyRatingTrigger is False.
        /// </summary>
        [IsoId("_SCx7b152Ee2a_-MvhEjKmA")]
        [DisplayName("Counterparty Rating Trigger Indicator")]
        [IsoXmlTag("CtrPtyRatgTrggrInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? CounterpartyRatingTriggerIndicator { get; init; }

        /// <summary>
        /// Indicates if a counterparty rating trigger includes a threshold that increases collateral requirements when the counterparty falls below the single-A rating or equivalent.
        /// Usage: If the CounterpartyRatingTrigger indicator is false, this element is omitted.
        /// </summary>
        [IsoId("_SCx7cV52Ee2a_-MvhEjKmA")]
        [DisplayName("Counterparty Rating Threshold Indicator")]
        [IsoXmlTag("CtrPtyRatgThrshldInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? CounterpartyRatingThresholdIndicator { get; init; }

        /// <summary>
        /// Contract modification details expressed as an action type and a reporting level type.
        /// </summary>
        [IsoId("_SCx7c152Ee2a_-MvhEjKmA")]
        [DisplayName("Contract Modification")]
        [IsoXmlTag("CtrctMod")]
        public ContractModification8? ContractModification { get; init; }

        /// <summary>
        /// Specifies technical attributes of the message.
        /// </summary>
        [IsoId("_SCx7dV52Ee2a_-MvhEjKmA")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public TechnicalAttributes6? TechnicalAttributes { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_SCx7d152Ee2a_-MvhEjKmA")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
