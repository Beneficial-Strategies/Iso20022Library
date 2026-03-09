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
/// Network management transaction.
/// </summary>
[IsoId("_xpB0YYv7EeumSPwlS1PkxQ")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction134
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction134 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction134( TransactionIdentification12 reqTransactionIdentification )
    {
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of network management service.
    /// ISO 8583:87/93 bit 24
    /// ISO 8583:2003 bit 70
    /// </summary>
    [IsoId("_xuMBMYv7EeumSPwlS1PkxQ")]
    [DisplayName("Network Management Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtwkMgmtTp")]
    #endif
    [IsoXmlTag("NtwkMgmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkManagementType1Code? NetworkManagementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkManagementType1Code? NetworkManagementType { get; init; } 
    #else
    public NetworkManagementType1Code? NetworkManagementType { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of network management in free text.
    /// </summary>
    [IsoId("_xuMBM4v7EeumSPwlS1PkxQ")]
    [DisplayName("Other Network Management Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrNtwkMgmtTp")]
    #endif
    [IsoXmlTag("OthrNtwkMgmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherNetworkManagementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherNetworkManagementType { get; init; } 
    #else
    public System.String? OtherNetworkManagementType { get; set; } 
    #endif
    
    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_8-H8d8sJEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRsn")]
    #endif
    [IsoXmlTag("MsgRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO8583MessageReasonCode? MessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? MessageReason { get; init; } 
    #else
    public string? MessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Supports message reason codes that are not defined in external code list. 
    /// </summary>
    [IsoId("_xuMBN4v7EeumSPwlS1PkxQ")]
    [DisplayName("Alternate Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnMsgRsn")]
    #endif
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? AlternateMessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternateMessageReason { get; init; } 
    #else
    public System.String? AlternateMessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_xuMBOYv7EeumSPwlS1PkxQ")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentification12 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentification12 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification12 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification12 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number of messages in the store and forward queue.
    /// </summary>
    [IsoId("_xuMBO4v7EeumSPwlS1PkxQ")]
    [DisplayName("Number Of Messages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfMsgs")]
    #endif
    [IsoXmlTag("NbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfMessages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfMessages { get; init; } 
    #else
    public System.UInt64? NumberOfMessages { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of messages in the store and forward queue.
    /// </summary>
    [IsoId("_xuMBPYv7EeumSPwlS1PkxQ")]
    [DisplayName("Maximum Number Of Messages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxNbOfMsgs")]
    #endif
    [IsoXmlTag("MaxNbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumNumberOfMessages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumNumberOfMessages { get; init; } 
    #else
    public System.UInt64? MaximumNumberOfMessages { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_xuMBP4v7EeumSPwlS1PkxQ")]
    [DisplayName("Additional Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFee")]
    #endif
    [IsoXmlTag("AddtlFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee2? AdditionalFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee2? AdditionalFee { get; init; } 
    #else
    public AdditionalFee2? AdditionalFee { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information pertaining to the network management type or function being performed.
    /// </summary>
    [IsoId("_xuMBQYv7EeumSPwlS1PkxQ")]
    [DisplayName("Transaction Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDesc")]
    #endif
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1000Text? TransactionDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionDescription { get; init; } 
    #else
    public System.String? TransactionDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_xuMBQ4v7EeumSPwlS1PkxQ")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
