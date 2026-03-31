// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReuseDataReport6Choice
{
    /// <summary>
    /// Information on collateral reusability for multiple transactions.
    /// </summary>
    [IsoId("_MzHkR8K8EeuMhqg3CsEu6Q")]
    [DisplayName("Collateral Reuse Update")]
    [IsoXmlTag("CollReuseUpd")]
    public record CollateralReuseUpdate : ReuseDataReport6Choice_
    {
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_jZla0cK8EeuCIrYISEfoUg")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? TechnicalRecordIdentification { get; init; }

        /// <summary>
        /// Date and time of submission of the report to the entitled receiver.
        /// </summary>
        [IsoId("_jZla08K8EeuCIrYISEfoUg")]
        [DisplayName("Reporting Date Time")]
        [IsoXmlTag("RptgDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime ReportingDateTime { get; init; }

        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_jZla1cK8EeuCIrYISEfoUg")]
        [DisplayName("Counterparty")]
        [IsoXmlTag("CtrPty")]
        public required CounterpartyData87 Counterparty { get; init; }

        /// <summary>
        /// Provides the details of the security or cash pledged as collateral.
        /// </summary>
        [IsoId("_jZla18K8EeuCIrYISEfoUg")]
        [DisplayName("Collateral Component")]
        [IsoXmlTag("CollCmpnt")]
        public CollateralType19? CollateralComponent { get; init; }

        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_jZla2cK8EeuCIrYISEfoUg")]
        [DisplayName("Event Day")]
        [IsoXmlTag("EvtDay")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate EventDay { get; init; }

        /// <summary>
        /// Information on funding sources used to finance margin loans.
        /// </summary>
        [IsoId("_jZla28K8EeuCIrYISEfoUg")]
        [DisplayName("Funding Source")]
        [IsoXmlTag("FndgSrc")]
        public FundingSource3? FundingSource { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_jZla3cK8EeuCIrYISEfoUg")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
