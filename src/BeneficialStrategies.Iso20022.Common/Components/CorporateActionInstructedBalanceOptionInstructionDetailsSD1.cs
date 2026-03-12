// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action instructed balance details at option level.
/// </summary>
[IsoId("_sIx_1pH9EeaNbfbSYshZYw")]
[DisplayName("Corporate Action Instructed Balance Option Instruction Details SD")]
public partial record CorporateActionInstructedBalanceOptionInstructionDetailsSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_sIx_2pH9EeaNbfbSYshZYw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_D1jXJJH-EeaNbfbSYshZYw")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    
    /// <summary>
    /// Unique number assigned by the Depository. Transaction identification will be either the DTC Instruction Reference Number for reorganisation instructions (VOI) or the DAM Reference Number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_VkuHlJH-EeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public required IsoMax15Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Number which further identifies DTC intsruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_VkuHlZH-EeaNbfbSYshZYw")]
    [DisplayName("Transaction Sequence Number")]
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; } 
    
    /// <summary>
    /// Instruction date and time for reorganisation instructions or the deposit date for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_VkuHlpH-EeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification Date")]
    [IsoXmlTag("TxIdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TransactionIdentificationDate { get; init; } 
    
    /// <summary>
    /// Contra CUSIP Identification of the option instruction.
    /// </summary>
    [IsoId("_gtfN8JINEeaNbfbSYshZYw")]
    [DisplayName("Transaction Contra CUSIP")]
    [IsoXmlTag("TxContraCUSIP")]
    public OtherIdentification2? TransactionContraCUSIP { get; init; } 
    
    /// <summary>
    /// Instructed quantity for reorganisation instructions or the deposit quantity for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_z6q0gZINEeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification Quantity")]
    [IsoXmlTag("TxIdQty")]
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    
    /// <summary>
    /// Quantity relating only to the oversubscription.
    /// </summary>
    [IsoId("_I9r7UJIOEeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification Oversubscription Quantity")]
    [IsoXmlTag("TxIdOvrsbcptQty")]
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_SleU8JIOEeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification Status")]
    [IsoXmlTag("TxIdSts")]
    public required DTCInstructionStatus2Code TransactionIdentificationStatus { get; init; } 
    
    /// <summary>
    /// Date and time of the protect instruction.
    /// </summary>
    [IsoId("_ltwNYJIOEeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification Protect Date")]
    [IsoXmlTag("TxIdPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransactionIdentificationProtectDate { get; init; } 
    
    /// <summary>
    /// Date and time of the cover protect.
    /// </summary>
    [IsoId("_1DOikJIOEeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification Cover Protect Date")]
    [IsoXmlTag("TxIdCoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransactionIdentificationCoverProtectDate { get; init; } 
    
    /// <summary>
    /// Conditional quantity on the instruction.
    /// </summary>
    [IsoId("_8FL3gJIQEeaNbfbSYshZYw")]
    [DisplayName("Transaction Conditional Quantity")]
    [IsoXmlTag("TxCondlQty")]
    public FinancialInstrumentQuantity15Choice_? TransactionConditionalQuantity { get; init; } 
    
    /// <summary>
    /// Tender bid price of the instruction.
    /// </summary>
    [IsoId("_GBpgoJIREeaNbfbSYshZYw")]
    [DisplayName("Transaction Tender Bid Price")]
    [IsoXmlTag("TxTndrBidPric")]
    public PriceFormat57Choice_? TransactionTenderBidPrice { get; init; } 
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_VkuHl5H-EeaNbfbSYshZYw")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public IsoMax15Text? CustomerReferenceIdentification { get; init; } 
    
    
    #nullable disable
    
}
