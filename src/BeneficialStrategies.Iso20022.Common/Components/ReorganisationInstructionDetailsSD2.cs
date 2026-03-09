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
[IsoId("_QNHyY8YAEeexPc-mfUU5zQ")]
[DisplayName("Reorganisation Instruction Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReorganisationInstructionDetailsSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReorganisationInstructionDetailsSD2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReorganisationInstructionDetailsSD2( System.String reqProtectIdentification,System.DateOnly reqProtectDate )
    {
        ProtectIdentification = reqProtectIdentification;
        ProtectDate = reqProtectDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_QNHyZcYAEeexPc-mfUU5zQ")]
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
    [IsoId("_QNHyZ8YAEeexPc-mfUU5zQ")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReorganisationTransactionType1Code? TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReorganisationTransactionType1Code? TransactionType { get; init; } 
    #else
    public ReorganisationTransactionType1Code? TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_QNHyZMYAEeexPc-mfUU5zQ")]
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
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_QNHybsYAEeexPc-mfUU5zQ")]
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
    /// Unique identifier for each customer in a transaction.
    /// </summary>
    [IsoId("_QNHydcYAEeexPc-mfUU5zQ")]
    [DisplayName("Customer Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrSeqNb")]
    #endif
    [IsoXmlTag("CstmrSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax9NumericText? CustomerSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerSequenceNumber { get; init; } 
    #else
    public System.String? CustomerSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_2kqqEcYCEeexPc-mfUU5zQ")]
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
    /// Status of the Protect Instruction.
    /// </summary>
    [IsoId("_VtVLMcYDEeexPc-mfUU5zQ")]
    [DisplayName("Protect Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctTxSts")]
    #endif
    [IsoXmlTag("PrtctTxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCProtectInstructionStatus1Code? ProtectTransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCProtectInstructionStatus1Code? ProtectTransactionStatus { get; init; } 
    #else
    public DTCProtectInstructionStatus1Code? ProtectTransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for which an inbound instruction message or a cancellation instruction message is rejected.
    /// </summary>
    [IsoId("_XR8e8MYLEeexPc-mfUU5zQ")]
    [DisplayName("Rejection Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnRsn")]
    #endif
    [IsoXmlTag("RjctnRsn")]
    [MinLength(0)]
    [MaxLength(6)]
    public SimpleValueList<InstructionRejectionReason1Code> RejectionReason { get; init; } = new SimpleValueList<InstructionRejectionReason1Code>(){};
    
    /// <summary>
    /// Identifies the protect itself or of that is being covered. It is required for the function types cover protect (COVR), cover protect directly to agent (COVA) and cover on behalf of another participant (COVP).
    /// </summary>
    [IsoId("_QNHyZsYAEeexPc-mfUU5zQ")]
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
    [IsoId("_ZdaAwOZTEeewObBhnieI_A")]
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
    /// Date on which the protect was created. It is required for transaction types cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and 
    /// cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    [IsoId("_QNHyc8YAEeexPc-mfUU5zQ")]
    [DisplayName("Protect Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctDt")]
    #endif
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ProtectDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ProtectDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ProtectDate { get; init; } 
    #else
    public System.DateOnly ProtectDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_QNHyaMYAEeexPc-mfUU5zQ")]
    [DisplayName("Securities Quantity Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQtyDtls")]
    #endif
    [IsoXmlTag("SctiesQtyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesQuantityDetailsSD4? SecuritiesQuantityDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesQuantityDetailsSD4? SecuritiesQuantityDetails { get; init; } 
    #else
    public SecuritiesQuantityDetailsSD4? SecuritiesQuantityDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Warrant subscription amount entered by client when instructing on a warrant exercise instruction.
    /// </summary>
    [IsoId("_QNHydMYAEeexPc-mfUU5zQ")]
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
    /// Indicates whether the tender offer accepts odd lots. 
    /// Yes: tender offer accepts odd lots.
    /// No: tender offer does not accept odd lots.
    /// </summary>
    [IsoId("_QNHyb8YAEeexPc-mfUU5zQ")]
    [DisplayName("Tender Odd Lot Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TndrOddLotInd")]
    #endif
    [IsoXmlTag("TndrOddLotInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TenderOddLotIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TenderOddLotIndicator { get; init; } 
    #else
    public System.String? TenderOddLotIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate information for a given instruction.
    /// </summary>
    [IsoId("_QNHyacYAEeexPc-mfUU5zQ")]
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
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_QNHybMYAEeexPc-mfUU5zQ")]
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
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    [IsoId("_QNHyasYAEeexPc-mfUU5zQ")]
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
    /// Party contact information for the given instruction; required for voluntary offer instruction transaction (VOIT), protect transaction (PROT) and protect on behalf of another participant transaction (PROP); not required for cover protect instructions like cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    [IsoId("_QNHybcYAEeexPc-mfUU5zQ")]
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
    /// Acknowledgement information relative to corporate action reorganisation instructions.
    /// </summary>
    [IsoId("_QNHyccYAEeexPc-mfUU5zQ")]
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
    /// Beneficial owner information related to CD early redemption instructions.
    /// </summary>
    [IsoId("_QNHycsYAEeexPc-mfUU5zQ")]
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
    [IsoId("_JsgVQMYREeexPc-mfUU5zQ")]
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
    
    
    #nullable disable
    
}
