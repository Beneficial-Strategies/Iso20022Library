// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeReport21Choice
{
    /// <summary>
    /// Indicates that the report is correcting the erroneous data fields of a previously submitted position.
    /// </summary>
    [IsoId("_SKn4Zcg2EeuGrNSsxk3B0A")]
    [DisplayName("Correction")]
    public partial record Correction : TradeReport21Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_SMF4Acg2EeuGrNSsxk3B0A")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
        
        /// <summary>
        /// Date and time of submission of the report to the trade repository.
        /// </summary>
        [IsoId("_SMF4A8g2EeuGrNSsxk3B0A")]
        [DisplayName("Reporting Date Time")]
        [IsoXmlTag("RptgDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime ReportingDateTime { get; init; } 
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_SMF4Bcg2EeuGrNSsxk3B0A")]
        [DisplayName("Event Date")]
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate EventDate { get; init; } 
        
        /// <summary>
        /// Data specific to counterparties of the reported transaction.
        /// </summary>
        [IsoId("_SMF4B8g2EeuGrNSsxk3B0A")]
        [DisplayName("Counterparty")]
        [IsoXmlTag("CtrPty")]
        public required Counterparty39 Counterparty { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identification of the collateral portfolio.
        /// </summary>
        [IsoId("_SMF4Ccg2EeuGrNSsxk3B0A")]
        [DisplayName("Collateral Portfolio Identification")]
        [IsoXmlTag("CollPrtflId")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        public required IsoMax52Text CollateralPortfolioIdentification { get; init; } 
        
        /// <summary>
        /// Information on posted collateral and margin.
        /// </summary>
        [IsoId("_SMF4C8g2EeuGrNSsxk3B0A")]
        [DisplayName("Posted Margin Or Collateral")]
        [IsoXmlTag("PstdMrgnOrColl")]
        public PostedMarginOrCollateral4? PostedMarginOrCollateral { get; init; } 
        
        /// <summary>
        /// Information on received collateral and margin.
        /// </summary>
        [IsoId("_SMF4Dcg2EeuGrNSsxk3B0A")]
        [DisplayName("Received Margin Or Collateral")]
        [IsoXmlTag("RcvdMrgnOrColl")]
        public ReceivedMarginOrCollateral4? ReceivedMarginOrCollateral { get; init; } 
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_SMF4D8g2EeuGrNSsxk3B0A")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
