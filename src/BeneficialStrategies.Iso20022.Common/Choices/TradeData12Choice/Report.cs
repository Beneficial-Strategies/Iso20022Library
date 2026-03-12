// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeData12Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_SPuq8__kEemm3skPVSMJQg")]
    [DisplayName("Report")]
    public partial record Report : TradeData12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_qlrv4f_pEemm3skPVSMJQg")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
        
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_qlrv4__pEemm3skPVSMJQg")]
        [DisplayName("Counterparty Data")]
        [IsoXmlTag("CtrPtyData")]
        public required CounterpartyData46 CounterpartyData { get; init; } 
        
        /// <summary>
        /// Provides the details of the security or cash pledged as collateral.
        /// </summary>
        [IsoId("_qlrv5f_pEemm3skPVSMJQg")]
        [DisplayName("Collateral Component")]
        [IsoXmlTag("CollCmpnt")]
        public required CollateralType12 CollateralComponent { get; init; } 
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_qlrv6f_pEemm3skPVSMJQg")]
        [DisplayName("Event Day")]
        [IsoXmlTag("EvtDay")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate EventDay { get; init; } 
        
        /// <summary>
        /// Date and time of submission of the report to the entitled receiver.
        /// </summary>
        [IsoId("_qlrv6__pEemm3skPVSMJQg")]
        [DisplayName("Reporting Date Time")]
        [IsoXmlTag("RptgDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime ReportingDateTime { get; init; } 
        
        /// <summary>
        /// Information on funding sources used to finance margin loans.
        /// </summary>
        [IsoId("_qlrv7f_pEemm3skPVSMJQg")]
        [DisplayName("Funding Source")]
        [IsoXmlTag("FndgSrc")]
        public FundingSource1? FundingSource { get; init; } 
        
        /// <summary>
        /// List of possible values for TRs reconciliation purposes.
        /// </summary>
        [IsoId("_qlrv7__pEemm3skPVSMJQg")]
        [DisplayName("Reconciliation Flag")]
        [IsoXmlTag("RcncltnFlg")]
        public ReconciliationFlag1? ReconciliationFlag { get; init; } 
        
        /// <summary>
        /// Contract modification details expressed as an action type and a reporting level type.
        /// </summary>
        [IsoId("_qlrv8f_pEemm3skPVSMJQg")]
        [DisplayName("Contract Modification")]
        [IsoXmlTag("CtrctMod")]
        public required ContractModification3 ContractModification { get; init; } 
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_qlrv8__pEemm3skPVSMJQg")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
