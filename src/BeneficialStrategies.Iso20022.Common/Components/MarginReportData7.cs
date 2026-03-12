// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the margin data.
/// </summary>
[IsoId("_o0L6kVosEe23K4GXSpBSeg")]
[DisplayName("Margin Report Data")]
public partial record MarginReportData7
{
    #nullable enable
    
    /// <summary>
    /// Date and time of submission of the report to the trade repository.
    /// </summary>
    [IsoId("_o13VkVosEe23K4GXSpBSeg")]
    [DisplayName("Reporting Time Stamp")]
    [IsoXmlTag("RptgTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ReportingTimeStamp { get; init; } 
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_o13Vk1osEe23K4GXSpBSeg")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required TradeCounterpartyReport20 CounterpartyIdentification { get; init; } 
    
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    [IsoId("_o13VlVosEe23K4GXSpBSeg")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EventDate { get; init; } 
    
    /// <summary>
    /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier as agreed with the counterparty. 
    /// </summary>
    [IsoId("_o13Vl1osEe23K4GXSpBSeg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public UniqueTransactionIdentifier2Choice_? TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Information related to collateral agreement existing between counterparties.
    /// </summary>
    [IsoId("_o13VmVosEe23K4GXSpBSeg")]
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public required MarginCollateralReport4 Collateral { get; init; } 
    
    /// <summary>
    /// Information on posted collateral and margin.
    /// </summary>
    [IsoId("_o13Vm1osEe23K4GXSpBSeg")]
    [DisplayName("Posted Margin Or Collateral")]
    [IsoXmlTag("PstdMrgnOrColl")]
    public PostedMarginOrCollateral6? PostedMarginOrCollateral { get; init; } 
    
    /// <summary>
    /// Information on received collateral and margin.
    /// </summary>
    [IsoId("_o13VnVosEe23K4GXSpBSeg")]
    [DisplayName("Received Margin Or Collateral")]
    [IsoXmlTag("RcvdMrgnOrColl")]
    public ReceivedMarginOrCollateral6? ReceivedMarginOrCollateral { get; init; } 
    
    /// <summary>
    /// Indicates if a counterparty rating trigger is agreed by the counterparties for the collateral posted by the reporting counterparty.
    /// Usage: If the element is not present, the CounterpartyRatingTrigger is False.
    /// </summary>
    [IsoId("_o13Vn1osEe23K4GXSpBSeg")]
    [DisplayName("Counterparty Rating Trigger Indicator")]
    [IsoXmlTag("CtrPtyRatgTrggrInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CounterpartyRatingTriggerIndicator { get; init; } 
    
    /// <summary>
    /// Indicates if a counterparty rating trigger includes a threshold that increases collateral requirements when the counterparty falls below the single-A rating or equivalent.
    /// Usage: If the CounterpartyRatingTrigger indicator is false, this element is omitted.
    /// </summary>
    [IsoId("_o13VoVosEe23K4GXSpBSeg")]
    [DisplayName("Counterparty Rating Threshold Indicator")]
    [IsoXmlTag("CtrPtyRatgThrshldInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CounterpartyRatingThresholdIndicator { get; init; } 
    
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    [IsoId("_o13Vo1osEe23K4GXSpBSeg")]
    [DisplayName("Technical Attributes")]
    [IsoXmlTag("TechAttrbts")]
    public TechnicalAttributes6? TechnicalAttributes { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_o13VpVosEe23K4GXSpBSeg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
