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
[IsoId("_Iqu6Aef6Eei5aPS232E3Mw")]
[DisplayName("Reorganisation Instruction SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReorganisationInstructionSD8
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
    [IsoId("_JSKGYef6Eei5aPS232E3Mw")]
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
    /// Identifies the reorganisation withdrawal transaction type.
    /// </summary>
    [IsoId("_JSKGY-f6Eei5aPS232E3Mw")]
    [DisplayName("Withdrawal Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WdrwlTxTp")]
    #endif
    [IsoXmlTag("WdrwlTxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReorganisationWithdrawalTransactionType2Code? WithdrawalTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReorganisationWithdrawalTransactionType2Code? WithdrawalTransactionType { get; init; } 
    #else
    public ReorganisationWithdrawalTransactionType2Code? WithdrawalTransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_JSKGZef6Eei5aPS232E3Mw")]
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
    [IsoId("_JSKGZ-f6Eei5aPS232E3Mw")]
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
    /// Status of the instruction.
    /// </summary>
    [IsoId("_JSKGaef6Eei5aPS232E3Mw")]
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
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_JSKGc-f6Eei5aPS232E3Mw")]
    [DisplayName("Securities Quantity Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQtyDtls")]
    #endif
    [IsoXmlTag("SctiesQtyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesQuantitySD6? SecuritiesQuantityDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesQuantitySD6? SecuritiesQuantityDetails { get; init; } 
    #else
    public SecuritiesQuantitySD6? SecuritiesQuantityDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for which an inbound instruction message or a cancellation instruction message is rejected.
    /// </summary>
    [IsoId("_JSKGbef6Eei5aPS232E3Mw")]
    [DisplayName("Rejection Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnRsn")]
    #endif
    [IsoXmlTag("RjctnRsn")]
    [MinLength(0)]
    [MaxLength(6)]
    public SimpleValueList<InstructionRejectionReason1Code> RejectionReason { get; init; } = new SimpleValueList<InstructionRejectionReason1Code>(){};
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_JSKGd-f6Eei5aPS232E3Mw")]
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
    /// Party contact information for the given instruction.
    /// </summary>
    [IsoId("_JSKGdef6Eei5aPS232E3Mw")]
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
    [IsoId("_JSKGeef6Eei5aPS232E3Mw")]
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
    /// For cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account. The protect safekeeping account will be the account which submitted the original protect instruction.
    /// </summary>
    [IsoId("_JSKGcef6Eei5aPS232E3Mw")]
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
    /// Status of the protect instruction.
    /// </summary>
    [IsoId("_JSKGa-f6Eei5aPS232E3Mw")]
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
    
    
    #nullable disable
    
}
