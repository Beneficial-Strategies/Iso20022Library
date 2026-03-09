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
[IsoId("_oFasoTDtEey2N-DB7H7A5A")]
[DisplayName("Reorganisation Instruction SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReorganisationInstructionSD12
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
    [IsoId("_ocESETDtEey2N-DB7H7A5A")]
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
    /// Unique number assigned by the depository. Transaction identification will be either the DTC instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody/reorganisation deposits.
    /// </summary>
    [IsoId("_ocESEzDtEey2N-DB7H7A5A")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15Text? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionIdentification { get; init; } 
    #else
    public System.String? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Enable input of multiple voluntary instructions for rights or voluntary puts events via a single instruction message through using transaction sequence number.
    /// </summary>
    [IsoId("_ocESFTDtEey2N-DB7H7A5A")]
    [DisplayName("Transaction Sequence")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSeq")]
    #endif
    [IsoXmlTag("TxSeq")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<InstructionsTransactionsSequence2> TransactionSequence { get; init; } = new ValueList<InstructionsTransactionsSequence2>(){};
    
    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_ocESFzDtEey2N-DB7H7A5A")]
    [DisplayName("Transaction Identification Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdSts")]
    #endif
    [IsoXmlTag("TxIdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCInstructionStatus2Code? TransactionIdentificationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCInstructionStatus2Code? TransactionIdentificationStatus { get; init; } 
    #else
    public DTCInstructionStatus2Code? TransactionIdentificationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the protect instruction.
    /// </summary>
    [IsoId("_ocESGTDtEey2N-DB7H7A5A")]
    [DisplayName("Protect Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctTxSts")]
    #endif
    [IsoXmlTag("PrtctTxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCProtectInstructionStatus3Code? ProtectTransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCProtectInstructionStatus3Code? ProtectTransactionStatus { get; init; } 
    #else
    public DTCProtectInstructionStatus3Code? ProtectTransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for which an inbound instruction message or a cancellation instruction message is pending or rejected.
    /// </summary>
    [IsoId("_ocESGzDtEey2N-DB7H7A5A")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    [MinLength(0)]
    [MaxLength(6)]
    public SimpleValueList<InstructionReason4Code> Reason { get; init; } = new SimpleValueList<InstructionReason4Code>(){};
    
    /// <summary>
    /// Provides further information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_ocESHTDtEey2N-DB7H7A5A")]
    [DisplayName("Securities Quantity Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQtyDtls")]
    #endif
    [IsoXmlTag("SctiesQtyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesQuantitySD9? SecuritiesQuantityDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesQuantitySD9? SecuritiesQuantityDetails { get; init; } 
    #else
    public SecuritiesQuantitySD9? SecuritiesQuantityDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Customer identification entered by the client upon instruction submission.
    /// </summary>
    [IsoId("_ocESHzDtEey2N-DB7H7A5A")]
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
    /// Acknowledgement information relative to corporate action reorganisation instructions.
    /// </summary>
    [IsoId("_ocESITDtEey2N-DB7H7A5A")]
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
    [IsoId("_ocESIzDtEey2N-DB7H7A5A")]
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
    /// Warrant subscription amount entered by client when instructing on a warrant exercise instruction.
    /// </summary>
    [IsoId("_ocESJTDtEey2N-DB7H7A5A")]
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
    /// Certificate information for a given instruction.
    /// </summary>
    [IsoId("_ocESJzDtEey2N-DB7H7A5A")]
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
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    [IsoId("_ocESKTDtEey2N-DB7H7A5A")]
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
    /// Beneficial owner information related to CD early redemption instructions.
    /// </summary>
    [IsoId("_ocESKzDtEey2N-DB7H7A5A")]
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
    /// Transaction record number for ATAM or ART system which may be causing pending status. Corresponds to ATP RBN number.
    /// </summary>
    [IsoId("_ocESLTDtEey2N-DB7H7A5A")]
    [DisplayName("Transaction Record Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRcrdNb")]
    #endif
    [IsoXmlTag("TxRcrdNb")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? TransactionRecordNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionRecordNumber { get; init; } 
    #else
    public System.String? TransactionRecordNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Bid price of the instruction.
    /// </summary>
    [IsoId("_ocESLzDtEey2N-DB7H7A5A")]
    [DisplayName("Bid Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BidPric")]
    #endif
    [IsoXmlTag("BidPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat63Choice_? BidPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat63Choice_? BidPrice { get; init; } 
    #else
    public PriceFormat63Choice_? BidPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Reference number assigned to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code).
    /// </summary>
    [IsoId("_ocESMTDtEey2N-DB7H7A5A")]
    [DisplayName("Shareholder Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrhldrNb")]
    #endif
    [IsoXmlTag("ShrhldrNb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax25Text)]
    [StringLength(maximumLength: 25 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax25Text? ShareholderNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShareholderNumber { get; init; } 
    #else
    public System.String? ShareholderNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
