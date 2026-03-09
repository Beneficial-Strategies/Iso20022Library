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
/// Provides additional information regarding corporate action instructed balance details at option protect level.
/// </summary>
[IsoId("_KY-t8b-0Eeeb2ZBoAlSG1Q")]
[DisplayName("Corporate Action Instructed Balance Option Protect Instruction Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionInstructedBalanceOptionProtectInstructionDetailsSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionInstructedBalanceOptionProtectInstructionDetailsSD2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionInstructedBalanceOptionProtectInstructionDetailsSD2( OptionNumber1Choice_ reqOptionNumber,System.String reqProtectIdentification,System.DateTime reqProtectDate,FinancialInstrumentQuantity15Choice_ reqProtectIdentificationQuantity )
    {
        OptionNumber = reqOptionNumber;
        ProtectIdentification = reqProtectIdentification;
        ProtectDate = reqProtectDate;
        ProtectIdentificationQuantity = reqProtectIdentificationQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_KoTjYb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Option number of the protect instruction.
    /// </summary>
    [IsoId("_KoTjZ7-0Eeeb2ZBoAlSG1Q")]
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
    /// Instruction reference number assigned by DTC to the uncovered protect instruction.
    /// </summary>
    [IsoId("_KoTjY7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctId")]
    #endif
    [IsoXmlTag("PrtctId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15Text ProtectIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProtectIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProtectIdentification { get; init; } 
    #else
    public System.String ProtectIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// For cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account. The protect safekeeping account will be the account which submitted the original protect instruction.
    /// </summary>
    [IsoId("_5vrDseZSEeewObBhnieI_A")]
    [DisplayName("Protect Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctSfkpgAcct")]
    #endif
    [IsoXmlTag("PrtctSfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINMax35Text? ProtectSafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProtectSafekeepingAccount { get; init; } 
    #else
    public System.String? ProtectSafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Additional reference number used to uniquely identify uncovered protect instruction.
    /// </summary>
    [IsoId("_KoTjZb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctSeqNb")]
    #endif
    [IsoXmlTag("PrtctSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? ProtectSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProtectSequenceNumber { get; init; } 
    #else
    public System.String? ProtectSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the protect instruction.
    /// </summary>
    [IsoId("_KoTjb7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctDt")]
    #endif
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ProtectDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ProtectDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ProtectDate { get; init; } 
    #else
    public System.DateTime ProtectDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the cover protect. Will be the latest cover date if partial cover transaction occurs.
    /// </summary>
    [IsoId("_KoTjcb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Cover Protect Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CoverPrtctDt")]
    #endif
    [IsoXmlTag("CoverPrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? CoverProtectDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? CoverProtectDate { get; init; } 
    #else
    public System.DateTime? CoverProtectDate { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of the protect instruction. For protects which are partially covered, the quantity will be reduced by the amount partially covered.
    /// </summary>
    [IsoId("_KoTjc7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Identification Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctIdQty")]
    #endif
    [IsoXmlTag("PrtctIdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity15Choice_ ProtectIdentificationQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity15Choice_ ProtectIdentificationQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_ ProtectIdentificationQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_ ProtectIdentificationQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of the protect instruction which has not been covered.
    /// </summary>
    [IsoId("_KoTjdb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Identification Uncovered Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctIdUcvrdQty")]
    #endif
    [IsoXmlTag("PrtctIdUcvrdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationUncoveredQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationUncoveredQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationUncoveredQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Protect oversubscription quantity.
    /// </summary>
    [IsoId("_KoTjd7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Identification Oversubscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctIdOvrsbcptQty")]
    #endif
    [IsoXmlTag("PrtctIdOvrsbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationOversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationOversubscriptionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationOversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the protect instruction.
    /// </summary>
    [IsoId("_KoTjeb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Identification Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctIdSts")]
    #endif
    [IsoXmlTag("PrtctIdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCProtectInstructionStatus1Code? ProtectIdentificationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCProtectInstructionStatus1Code? ProtectIdentificationStatus { get; init; } 
    #else
    public DTCProtectInstructionStatus1Code? ProtectIdentificationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Conditional quantity for the protect instruction.
    /// </summary>
    [IsoId("_KoTje7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Conditional Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctCondlQty")]
    #endif
    [IsoXmlTag("PrtctCondlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? ProtectConditionalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? ProtectConditionalQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? ProtectConditionalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Tender bid price of the protect instruction.
    /// </summary>
    [IsoId("_KoTjfb-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Protect Tender Bid Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctTndrBidPric")]
    #endif
    [IsoXmlTag("PrtctTndrBidPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat57Choice_? ProtectTenderBidPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat57Choice_? ProtectTenderBidPrice { get; init; } 
    #else
    public PriceFormat57Choice_? ProtectTenderBidPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_KoTjf7-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Customer Reference Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrRefId")]
    #endif
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax30Text? CustomerReferenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerReferenceIdentification { get; init; } 
    #else
    public System.String? CustomerReferenceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Client free format instruction narrative information. Will be 80 characters for tender instructions, 150 characters for rights instructions and 20 characters for put instructions.
    /// </summary>
    [IsoId("_252Z8b_uEeeb2ZBoAlSG1Q")]
    [DisplayName("Instruction Comments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrCmnts")]
    #endif
    [IsoXmlTag("InstrCmnts")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? InstructionComments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionComments { get; init; } 
    #else
    public System.String? InstructionComments { get; set; } 
    #endif
    
    
    #nullable disable
    
}
