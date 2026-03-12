// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.023.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BackupPayment message is sent by a member to the transaction administrator.
/// It is used to request a liquidity transfer from the member to another participant in the system when the user is in recovery mode.
/// Usage
/// Under very specific circumstances, the transaction administrator can accept direct input of transactions as part of its cash management functionalities. This possibility is available only when a declared incident has been reported to the transaction administrator This could be the case, for example, when the internal systems of the member are having problems sending out payments or when the continuity of the whole system is put at risk.
/// The purpose of the BackupPayment message is to prevent the consequences of a specific failure affecting not only the member experiencing problems but also its counterparties. Members can therefore input transactions directly in order to ensure the stability of the system and smooth exchanges.
/// At any time during the operating hours of the system, and under the agreed circumstances, the member can request a backup payment to be effected.
/// The member can request the transfer by identifying the following elements:
/// - party (account owner) that will receive the funds
/// - the financial institution that will receive the funds on behalf of the account owner
/// Based on the criteria received within the BackupPayment message, the transaction administrator will execute or reject the requested funds transfer.
/// The transaction administrator may send a Receipt message as a reply to the BackupPayment request.
/// To verify the outcome of the request, the member may submit a GetTransaction or GetAccount message with the appropriate search criteria.
/// </summary>
[Description(@"Scope|The BackupPayment message is sent by a member to the transaction administrator.|It is used to request a liquidity transfer from the member to another participant in the system when the user is in recovery mode.|Usage|Under very specific circumstances, the transaction administrator can accept direct input of transactions as part of its cash management functionalities. This possibility is available only when a declared incident has been reported to the transaction administrator This could be the case, for example, when the internal systems of the member are having problems sending out payments or when the continuity of the whole system is put at risk.|The purpose of the BackupPayment message is to prevent the consequences of a specific failure affecting not only the member experiencing problems but also its counterparties. Members can therefore input transactions directly in order to ensure the stability of the system and smooth exchanges.|At any time during the operating hours of the system, and under the agreed circumstances, the member can request a backup payment to be effected.|The member can request the transfer by identifying the following elements:|- party (account owner) that will receive the funds|- the financial institution that will receive the funds on behalf of the account owner|Based on the criteria received within the BackupPayment message, the transaction administrator will execute or reject the requested funds transfer.|The transaction administrator may send a Receipt message as a reply to the BackupPayment request.|To verify the outcome of the request, the member may submit a GetTransaction or GetAccount message with the appropriate search criteria.")]
[IsoId("_jwlbMRbvEeiyVv5j1vf1VQ")]
[DisplayName("Backup Payment V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BackupPaymentV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.023.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BckpPmt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.023.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BackupPaymentV07 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BackupPaymentV07( MessageHeader1 reqMessageHeader,Amount2Choice_ reqTransferredAmount,SystemMember3 reqCreditor )
    {
        MessageHeader = reqMessageHeader;
        TransferredAmount = reqTransferredAmount;
        Creditor = reqCreditor;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbMxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader1 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader1 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader1 MessageHeader { get; init; } 
    #else
    public MessageHeader1 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the original message identification.|This was formerly the PaymentInstructionReference.
    /// </summary>
    [IsoId("_jwlbNRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Original Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgId")]
    #endif
    [IsoXmlTag("OrgnlMsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageHeader1? OriginalMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader1? OriginalMessageIdentification { get; init; } 
    #else
    public MessageHeader1? OriginalMessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the execution and type of payment contained in the instruction.
    /// </summary>
    [IsoId("_jwlbNxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Instruction Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrInf")]
    #endif
    [IsoXmlTag("InstrInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstruction13? InstructionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstruction13? InstructionInformation { get; init; } 
    #else
    public PaymentInstruction13? InstructionInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of cash that the transaction administrator transfers from one account to another.
    /// </summary>
    [IsoId("_jwlbORbvEeiyVv5j1vf1VQ")]
    [DisplayName("Transferred Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfdAmt")]
    #endif
    [IsoXmlTag("TrfdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount2Choice_ TransferredAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount2Choice_ TransferredAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2Choice_ TransferredAmount { get; init; } 
    #else
    public Amount2Choice_ TransferredAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives an amount of money from the debtor.
    /// </summary>
    [IsoId("_jwlbOxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemMember3 Creditor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemMember3 Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemMember3 Creditor { get; init; } 
    #else
    public SystemMember3 Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of an account owner, or other nominated party, and credits the account.
    /// </summary>
    [IsoId("_jwlbPRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemMember3? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemMember3? CreditorAgent { get; init; } 
    #else
    public SystemMember3? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.
    /// </summary>
    [IsoId("_jwlbPxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemMember3? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemMember3? DebtorAgent { get; init; } 
    #else
    public SystemMember3? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbQRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since BackupPaymentV07Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BackupPaymentV07.

