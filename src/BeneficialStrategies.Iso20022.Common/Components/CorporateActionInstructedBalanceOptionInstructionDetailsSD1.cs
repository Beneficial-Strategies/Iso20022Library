// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action instructed balance details at option level.
/// </summary>
[IsoId("_sIx_1pH9EeaNbfbSYshZYw")]
[DisplayName("Corporate Action Instructed Balance Option Instruction Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionInstructedBalanceOptionInstructionDetailsSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionInstructedBalanceOptionInstructionDetailsSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionInstructedBalanceOptionInstructionDetailsSD1( System.String reqPlaceAndName,OptionNumber1Choice_ reqOptionNumber,System.String reqTransactionIdentification,System.DateTime reqTransactionIdentificationDate,FinancialInstrumentQuantity15Choice_ reqTransactionIdentificationQuantity,DTCInstructionStatus2Code reqTransactionIdentificationStatus )
    {
        PlaceAndName = reqPlaceAndName;
        OptionNumber = reqOptionNumber;
        TransactionIdentification = reqTransactionIdentification;
        TransactionIdentificationDate = reqTransactionIdentificationDate;
        TransactionIdentificationQuantity = reqTransactionIdentificationQuantity;
        TransactionIdentificationStatus = reqTransactionIdentificationStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_sIx_2pH9EeaNbfbSYshZYw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_D1jXJJH-EeaNbfbSYshZYw")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionNumber1Choice_ OptionNumber { get; init; } 
    #else
    public OptionNumber1Choice_ OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number assigned by the Depository. Transaction identification will be either the DTC Instruction Reference Number for reorganisation instructions (VOI) or the DAM Reference Number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_VkuHlJH-EeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number which further identifies DTC intsruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_VkuHlZH-EeaNbfbSYshZYw")]
    [DisplayName("Transaction Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSeqNb")]
    #endif
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionSequenceNumber { get; init; } 
    #else
    public System.String? TransactionSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Instruction date and time for reorganisation instructions or the deposit date for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_VkuHlpH-EeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdDt")]
    #endif
    [IsoXmlTag("TxIdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TransactionIdentificationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TransactionIdentificationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TransactionIdentificationDate { get; init; } 
    #else
    public System.DateTime TransactionIdentificationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Contra CUSIP Identification of the option instruction.
    /// </summary>
    [IsoId("_gtfN8JINEeaNbfbSYshZYw")]
    [DisplayName("Transaction Contra CUSIP")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxContraCUSIP")]
    #endif
    [IsoXmlTag("TxContraCUSIP")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherIdentification2? TransactionContraCUSIP { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherIdentification2? TransactionContraCUSIP { get; init; } 
    #else
    public OtherIdentification2? TransactionContraCUSIP { get; set; } 
    #endif
    
    /// <summary>
    /// Instructed quantity for reorganisation instructions or the deposit quantity for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_z6q0gZINEeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdQty")]
    #endif
    [IsoXmlTag("TxIdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity relating only to the oversubscription.
    /// </summary>
    [IsoId("_I9r7UJIOEeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification Oversubscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdOvrsbcptQty")]
    #endif
    [IsoXmlTag("TxIdOvrsbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_SleU8JIOEeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdSts")]
    #endif
    [IsoXmlTag("TxIdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DTCInstructionStatus2Code TransactionIdentificationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DTCInstructionStatus2Code TransactionIdentificationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCInstructionStatus2Code TransactionIdentificationStatus { get; init; } 
    #else
    public DTCInstructionStatus2Code TransactionIdentificationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the protect instruction.
    /// </summary>
    [IsoId("_ltwNYJIOEeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification Protect Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdPrtctDt")]
    #endif
    [IsoXmlTag("TxIdPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TransactionIdentificationProtectDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TransactionIdentificationProtectDate { get; init; } 
    #else
    public System.DateTime? TransactionIdentificationProtectDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the cover protect.
    /// </summary>
    [IsoId("_1DOikJIOEeaNbfbSYshZYw")]
    [DisplayName("Transaction Identification Cover Protect Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdCoverPrtctDt")]
    #endif
    [IsoXmlTag("TxIdCoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TransactionIdentificationCoverProtectDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TransactionIdentificationCoverProtectDate { get; init; } 
    #else
    public System.DateTime? TransactionIdentificationCoverProtectDate { get; set; } 
    #endif
    
    /// <summary>
    /// Conditional quantity on the instruction.
    /// </summary>
    [IsoId("_8FL3gJIQEeaNbfbSYshZYw")]
    [DisplayName("Transaction Conditional Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCondlQty")]
    #endif
    [IsoXmlTag("TxCondlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? TransactionConditionalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? TransactionConditionalQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? TransactionConditionalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Tender bid price of the instruction.
    /// </summary>
    [IsoId("_GBpgoJIREeaNbfbSYshZYw")]
    [DisplayName("Transaction Tender Bid Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTndrBidPric")]
    #endif
    [IsoXmlTag("TxTndrBidPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat57Choice_? TransactionTenderBidPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat57Choice_? TransactionTenderBidPrice { get; init; } 
    #else
    public PriceFormat57Choice_? TransactionTenderBidPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_VkuHl5H-EeaNbfbSYshZYw")]
    [DisplayName("Customer Reference Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrRefId")]
    #endif
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15Text? CustomerReferenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerReferenceIdentification { get; init; } 
    #else
    public System.String? CustomerReferenceIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
