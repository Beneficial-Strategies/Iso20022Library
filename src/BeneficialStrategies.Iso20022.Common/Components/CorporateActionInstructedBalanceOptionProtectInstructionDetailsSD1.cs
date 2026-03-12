// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action instructed balance details at option protect level.
/// </summary>
[IsoId("_5CUCwJIYEeaNbfbSYshZYw")]
[DisplayName("Corporate Action Instructed Balance Option Protect Instruction Details SD")]
public partial record CorporateActionInstructedBalanceOptionProtectInstructionDetailsSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_RUIA0ZIZEeaNbfbSYshZYw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Instruction reference number assigned by DTC to the uncovered protect instruction.
    /// </summary>
    [IsoId("_gYy54JIZEeaNbfbSYshZYw")]
    [DisplayName("Protect Identification")]
    [IsoXmlTag("PrtctId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public required IsoMax15Text ProtectIdentification { get; init; } 
    
    /// <summary>
    /// Additional Reference number used to uniquely identify uncovered protect instruction.
    /// </summary>
    [IsoId("_twZ0MJIZEeaNbfbSYshZYw")]
    [DisplayName("Protect Sequence Number")]
    [IsoXmlTag("PrtctSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? ProtectSequenceNumber { get; init; } 
    
    /// <summary>
    /// Option number of the protect instruction.
    /// </summary>
    [IsoId("_2wBalJIZEeaNbfbSYshZYw")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    
    /// <summary>
    /// Date and time of the protect instruction.
    /// </summary>
    [IsoId("_m15qwJIaEeaNbfbSYshZYw")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ProtectDate { get; init; } 
    
    /// <summary>
    /// Date and time of the cover protect. Will be the latest cover date if partial cover transaction occurs.
    /// </summary>
    [IsoId("_4sWH4JIaEeaNbfbSYshZYw")]
    [DisplayName("Cover Protect Date")]
    [IsoXmlTag("CoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CoverProtectDate { get; init; } 
    
    /// <summary>
    /// Quantity of the protect instruction. For protects which are partially covered, the quanitity will be reduced by the amount partially covered.
    /// </summary>
    [IsoId("_GIIXkJIbEeaNbfbSYshZYw")]
    [DisplayName("Protect Identification Quantity")]
    [IsoXmlTag("PrtctIdQty")]
    public required FinancialInstrumentQuantity15Choice_ ProtectIdentificationQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of the Protect instruction which has not been covered.
    /// </summary>
    [IsoId("_RDSdkJIbEeaNbfbSYshZYw")]
    [DisplayName("Protect Identification Uncovered Quantity")]
    [IsoXmlTag("PrtctIdUcvrdQty")]
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationUncoveredQuantity { get; init; } 
    
    /// <summary>
    /// Protect oversubscription quantity.
    /// </summary>
    [IsoId("_cr2cIJIbEeaNbfbSYshZYw")]
    [DisplayName("Protect Identification Oversubscription Quantity")]
    [IsoXmlTag("PrtctIdOvrsbcptQty")]
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationOversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// Status of the Protect Instruction.
    /// </summary>
    [IsoId("_krJ1AJIbEeaNbfbSYshZYw")]
    [DisplayName("Protect Identification Status")]
    [IsoXmlTag("PrtctIdSts")]
    public DTCProtectInstructionStatus1Code? ProtectIdentificationStatus { get; init; } 
    
    /// <summary>
    /// Conditional Quantity for the Protect Instruction.
    /// </summary>
    [IsoId("_uSAagJIbEeaNbfbSYshZYw")]
    [DisplayName("Protect Conditional Quantity")]
    [IsoXmlTag("PrtctCondlQty")]
    public FinancialInstrumentQuantity15Choice_? ProtectConditionalQuantity { get; init; } 
    
    /// <summary>
    /// Tender bid price of the protect instruction.
    /// </summary>
    [IsoId("_7ceQsJIbEeaNbfbSYshZYw")]
    [DisplayName("Protect Tender Bid Price")]
    [IsoXmlTag("PrtctTndrBidPric")]
    public PriceFormat57Choice_? ProtectTenderBidPrice { get; init; } 
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_MOtJsZIaEeaNbfbSYshZYw")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public IsoMax15Text? CustomerReferenceIdentification { get; init; } 
    
    
    #nullable disable
    
}
