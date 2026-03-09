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
[IsoId("_3WR4AQ-tEeuE0Pnt-OcNOA")]
[DisplayName("Reorganisation Instruction SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReorganisationInstructionSD10
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
    [IsoId("_3rjkcQ-tEeuE0Pnt-OcNOA")]
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
    [IsoId("_3rjkcw-tEeuE0Pnt-OcNOA")]
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
    [IsoId("_3rjkdQ-tEeuE0Pnt-OcNOA")]
    [DisplayName("Transaction Sequence")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSeq")]
    #endif
    [IsoXmlTag("TxSeq")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<InstructionsTransactionsSequence1> TransactionSequence { get; init; } = new ValueList<InstructionsTransactionsSequence1>(){};
    
    /// <summary>
    /// Total oversubscription quantity of all transaction sequence instructions.
    /// </summary>
    [IsoId("_3rjkdw-tEeuE0Pnt-OcNOA")]
    [DisplayName("Total Oversubscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlOvrsbcptQty")]
    #endif
    [IsoXmlTag("TtlOvrsbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Acknowledgement information relative to corporate action reorganisation instructions.
    /// </summary>
    [IsoId("_3rjkeQ-tEeuE0Pnt-OcNOA")]
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
    [IsoId("_3rjkew-tEeuE0Pnt-OcNOA")]
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
    [IsoId("_3rjkfQ-tEeuE0Pnt-OcNOA")]
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
    [IsoId("_3rjkfw-tEeuE0Pnt-OcNOA")]
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
    [IsoId("_3rjkgQ-tEeuE0Pnt-OcNOA")]
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
    [IsoId("_3rjkhQ-tEeuE0Pnt-OcNOA")]
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
    [IsoId("_3rjkhw-tEeuE0Pnt-OcNOA")]
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
    
    
    #nullable disable
    
}
