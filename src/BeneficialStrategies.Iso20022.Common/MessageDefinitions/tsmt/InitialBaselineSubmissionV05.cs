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


namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.019.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The InitialBaselineSubmission message is sent by the initiator of a transaction to the matching application.
/// This message is used to initiate a transaction.
/// Usage
/// The InitialBaselineSubmission message can be sent by a party to register a transaction in the matching application. The message can be submitted with either lodge or push-through instruction.
/// When the push-through instruction is present, the matching application acknowledges the receipt of the message to the sender by sending an Acknowledgement message, stores the submitted information and informs the counterparty about the registration of the transaction by sending a FullPushThroughReport message. With the BaselineReSubmission message the counterparty responds with matching baseline information in order to establish the transaction (baseline).
/// When the lodge instruction is present, the matching application acknowledges the receipt of the message to the sender by sending an Acknowledgement message and stores the submitted information. No matching of the submitted baseline data with other baseline information will take place. For example the submission of an InitialBaselineSubmission message containing a lodge instruction establishes the transaction (baseline) in the matching application.
/// The InitialBaselineSubmission message consists of data which relates to the purchasing agreement covered by the transaction, for example line item details, shipping details.
/// </summary>
[Description(@"Scope|The InitialBaselineSubmission message is sent by the initiator of a transaction to the matching application.|This message is used to initiate a transaction.|Usage|The InitialBaselineSubmission message can be sent by a party to register a transaction in the matching application. The message can be submitted with either lodge or push-through instruction.|When the push-through instruction is present, the matching application acknowledges the receipt of the message to the sender by sending an Acknowledgement message, stores the submitted information and informs the counterparty about the registration of the transaction by sending a FullPushThroughReport message. With the BaselineReSubmission message the counterparty responds with matching baseline information in order to establish the transaction (baseline).|When the lodge instruction is present, the matching application acknowledges the receipt of the message to the sender by sending an Acknowledgement message and stores the submitted information. No matching of the submitted baseline data with other baseline information will take place. For example the submission of an InitialBaselineSubmission message containing a lodge instruction establishes the transaction (baseline) in the matching application.|The InitialBaselineSubmission message consists of data which relates to the purchasing agreement covered by the transaction, for example line item details, shipping details.")]
[IsoId("_a0GHAQgGEeSeS5xdjFfOTw")]
[DisplayName("Initial Baseline Submission V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InitialBaselineSubmissionV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.019.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InitlBaselnSubmissn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.019.001.05";
    
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
    /// Constructs a InitialBaselineSubmissionV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InitialBaselineSubmissionV05( MessageIdentification1 reqSubmissionIdentification,SimpleIdentificationInformation reqSubmitterTransactionReference,InstructionType1 reqInstruction,Baseline5 reqBaseline,BankContactPerson1Choice_ reqBankContactPerson )
    {
        SubmissionIdentification = reqSubmissionIdentification;
        SubmitterTransactionReference = reqSubmitterTransactionReference;
        Instruction = reqInstruction;
        Baseline = reqBaseline;
        BankContactPerson = reqBankContactPerson;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the submitted information.
    /// </summary>
    [IsoId("_a0GHBQgGEeSeS5xdjFfOTw")]
    [DisplayName("Submission Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmissnId")]
    #endif
    [IsoXmlTag("SubmissnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 SubmissionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 SubmissionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 SubmissionIdentification { get; init; } 
    #else
    public MessageIdentification1 SubmissionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_a0GHBwgGEeSeS5xdjFfOTw")]
    [DisplayName("Submitter Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitrTxRef")]
    #endif
    [IsoXmlTag("SubmitrTxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SimpleIdentificationInformation SubmitterTransactionReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SimpleIdentificationInformation SubmitterTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation SubmitterTransactionReference { get; init; } 
    #else
    public SimpleIdentificationInformation SubmitterTransactionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the instruction requested by the submitter by means of a code.
    /// </summary>
    [IsoId("_a0GHCQgGEeSeS5xdjFfOTw")]
    [DisplayName("Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instr")]
    #endif
    [IsoXmlTag("Instr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructionType1 Instruction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstructionType1 Instruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionType1 Instruction { get; init; } 
    #else
    public InstructionType1 Instruction { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the commercial details of the underlying transaction.
    /// </summary>
    [IsoId("_a0GHCwgGEeSeS5xdjFfOTw")]
    [DisplayName("Baseline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Baseln")]
    #endif
    [IsoXmlTag("Baseln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Baseline5 Baseline { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Baseline5 Baseline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Baseline5 Baseline { get; init; } 
    #else
    public Baseline5 Baseline { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in the organisation of the buyer.
    /// </summary>
    [IsoId("_a0GHDQgGEeSeS5xdjFfOTw")]
    [DisplayName("Buyer Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrCtctPrsn")]
    #endif
    [IsoXmlTag("BuyrCtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification1? BuyerContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification1? BuyerContactPerson { get; init; } 
    #else
    public ContactIdentification1? BuyerContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in the organisation of the seller.
    /// </summary>
    [IsoId("_a0GHDwgGEeSeS5xdjFfOTw")]
    [DisplayName("Seller Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrCtctPrsn")]
    #endif
    [IsoXmlTag("SellrCtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification1? SellerContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification1? SellerContactPerson { get; init; } 
    #else
    public ContactIdentification1? SellerContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in the seller&apos;s bank or buyer&apos;s bank.
    /// </summary>
    [IsoId("_a0GHEQgGEeSeS5xdjFfOTw")]
    [DisplayName("Bank Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkCtctPrsn")]
    #endif
    [IsoXmlTag("BkCtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BankContactPerson1Choice_ BankContactPerson { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BankContactPerson1Choice_ BankContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankContactPerson1Choice_ BankContactPerson { get; init; } 
    #else
    public BankContactPerson1Choice_ BankContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in another bank than seller or buyer&apos;s bank.
    /// </summary>
    [IsoId("_a0GHEwgGEeSeS5xdjFfOTw")]
    [DisplayName("Other Bank Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrBkCtctPrsn")]
    #endif
    [IsoXmlTag("OthrBkCtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification3? OtherBankContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification3? OtherBankContactPerson { get; init; } 
    #else
    public ContactIdentification3? OtherBankContactPerson { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since InitialBaselineSubmissionV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InitialBaselineSubmissionV05.

