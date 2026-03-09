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
/// Provides additional information regarding corporate action reorganisation instruction details.
/// </summary>
[IsoId("_oxhkuTDtEey2N-DB7H7A5A")]
[DisplayName("Reorganisation Instruction SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReorganisationInstructionSD13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_pHueMTDtEey2N-DB7H7A5A")]
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
    /// Identifies the reorganisation transaction type.
    /// </summary>
    [IsoId("_pHueMzDtEey2N-DB7H7A5A")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReorganisationTransactionType2Code? TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReorganisationTransactionType2Code? TransactionType { get; init; } 
    #else
    public ReorganisationTransactionType2Code? TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Enable input of multiple voluntary instructions for rights or voluntary puts events via a single instruction message through using Transaction Sequence Number.
    /// </summary>
    [IsoId("_pHueNTDtEey2N-DB7H7A5A")]
    [DisplayName("Transaction Sequence")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSeq")]
    #endif
    [IsoXmlTag("TxSeq")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<InstructionsTransactionsSequence2> TransactionSequence { get; init; } = new ValueList<InstructionsTransactionsSequence2>(){};
    
    /// <summary>
    /// Total oversubscription quantity of all transaction sequence instructions.
    /// </summary>
    [IsoId("_pHueNzDtEey2N-DB7H7A5A")]
    [DisplayName("Total Oversubscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlOvrsbcptQty")]
    #endif
    [IsoXmlTag("TtlOvrsbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity31Choice_? TotalOversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity31Choice_? TotalOversubscriptionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity31Choice_? TotalOversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Acknowledgement information relative to corporate action reorganisation instructions.
    /// </summary>
    [IsoId("_pHueOTDtEey2N-DB7H7A5A")]
    [DisplayName("Acknowledgement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AckDtls")]
    #endif
    [IsoXmlTag("AckDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionAcknowledgementSD1? AcknowledgementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionAcknowledgementSD1? AcknowledgementDetails { get; init; } 
    #else
    public CorporateActionAcknowledgementSD1? AcknowledgementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party contact information for the given instruction; required for a voluntary offer instruction transaction (VOIT), protect transaction (PROT) and protect on behalf of another participant transaction (PROP); not required for cover protect instructions like a cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    [IsoId("_pHueOzDtEey2N-DB7H7A5A")]
    [DisplayName("Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctPrsn")]
    #endif
    [IsoXmlTag("CtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification5? ContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification5? ContactPerson { get; init; } 
    #else
    public ContactIdentification5? ContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    [IsoId("_pHuePTDtEey2N-DB7H7A5A")]
    [DisplayName("User Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrRefNb")]
    #endif
    [IsoXmlTag("UsrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax6Text? UserReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UserReferenceNumber { get; init; } 
    #else
    public System.String? UserReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Warrant subscription amount entered by client when instructing on a warrant exercise instruction.
    /// </summary>
    [IsoId("_pHuePzDtEey2N-DB7H7A5A")]
    [DisplayName("Warrant Subscription Charge Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WarrtSbcptChrgAmt")]
    #endif
    [IsoXmlTag("WarrtSbcptChrgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? WarrantSubscriptionChargeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? WarrantSubscriptionChargeAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? WarrantSubscriptionChargeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the DTC participant is willing to accept penalties as a result of processing instructions prior to maturity of CD redemptions events.
    /// Yes: participant accepts penalties.
    /// No: participant does not accept penalties.
    /// </summary>
    [IsoId("_pHueQTDtEey2N-DB7H7A5A")]
    [DisplayName("Non Exempt Instructions Allowed Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonXmptInstrsAllwdInd")]
    #endif
    [IsoXmlTag("NonXmptInstrsAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NonExemptInstructionsAllowedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonExemptInstructionsAllowedIndicator { get; init; } 
    #else
    public System.String? NonExemptInstructionsAllowedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate information for a given instruction.
    /// </summary>
    [IsoId("_pHueQzDtEey2N-DB7H7A5A")]
    [DisplayName("Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cert")]
    #endif
    [IsoXmlTag("Cert")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionCertificateSD1? Certificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionCertificateSD1? Certificate { get; init; } 
    #else
    public CorporateActionCertificateSD1? Certificate { get; set; } 
    #endif
    
    /// <summary>
    /// Beneficial owner information related to CD early redemption instructions.
    /// </summary>
    [IsoId("_pHueRTDtEey2N-DB7H7A5A")]
    [DisplayName("Deceased Beneficial Owner Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DcsdBnfclOwnrDtls")]
    #endif
    [IsoXmlTag("DcsdBnfclOwnrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeceasedStatusSD1? DeceasedBeneficialOwnerDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeceasedStatusSD1? DeceasedBeneficialOwnerDetails { get; init; } 
    #else
    public DeceasedStatusSD1? DeceasedBeneficialOwnerDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_hpJ-YTDuEey2N-DB7H7A5A")]
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
    
    
    #nullable disable
    
}
