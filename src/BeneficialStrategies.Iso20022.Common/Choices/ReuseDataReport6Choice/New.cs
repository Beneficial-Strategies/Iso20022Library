// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReuseDataReport6Choice
{
    /// <summary>
    /// Indicates whether transaction is reported for the first time.
    /// </summary>
    [IsoId("_MzHkQcK8EeuMhqg3CsEu6Q")]
    [DisplayName("New")]
    public partial record New : ReuseDataReport6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_M0kVwcK8EeuMhqg3CsEu6Q")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
        
        /// <summary>
        /// Date and time of submission of the report to the entitled receiver.
        /// </summary>
        [IsoId("_M0kVw8K8EeuMhqg3CsEu6Q")]
        [DisplayName("Reporting Date Time")]
        [IsoXmlTag("RptgDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime ReportingDateTime { get; init; } 
        
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_M0kVxcK8EeuMhqg3CsEu6Q")]
        [DisplayName("Counterparty")]
        [IsoXmlTag("CtrPty")]
        public required CounterpartyData87 Counterparty { get; init; } 
        
        /// <summary>
        /// Provides the details of the security or cash pledged as collateral.
        /// </summary>
        [IsoId("_M0kVx8K8EeuMhqg3CsEu6Q")]
        [DisplayName("Collateral Component")]
        [IsoXmlTag("CollCmpnt")]
        public CollateralType19? CollateralComponent { get; init; } 
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_M0kVycK8EeuMhqg3CsEu6Q")]
        [DisplayName("Event Day")]
        [IsoXmlTag("EvtDay")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate EventDay { get; init; } 
        
        /// <summary>
        /// Information on funding sources used to finance margin loans.
        /// </summary>
        [IsoId("_M0kVy8K8EeuMhqg3CsEu6Q")]
        [DisplayName("Funding Source")]
        [IsoXmlTag("FndgSrc")]
        public FundingSource3? FundingSource { get; init; } 
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_M0kVzcK8EeuMhqg3CsEu6Q")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
