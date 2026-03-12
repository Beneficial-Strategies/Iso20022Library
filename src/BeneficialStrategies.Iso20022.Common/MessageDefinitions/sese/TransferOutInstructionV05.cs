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


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.001.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the TransferOutInstruction message to the executing party, for example, a transfer agent, to instruct the delivery of a financial instrument, free of payment, on a given date from a specified party.
/// This message may also be used to instruct the delivery of a financial instrument, free of payment, to another of the instructing parties own accounts or to a third party.
/// Usage
/// The TransferOutInstruction message is used to instruct the withdrawal of a financial instrument from one account and deliver it to either another account or to a third party.
/// </summary>
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the TransferOutInstruction message to the executing party, for example, a transfer agent, to instruct the delivery of a financial instrument, free of payment, on a given date from a specified party.|This message may also be used to instruct the delivery of a financial instrument, free of payment, to another of the instructing parties own accounts or to a third party.|Usage|The TransferOutInstruction message is used to instruct the withdrawal of a financial instrument from one account and deliver it to either another account or to a third party.")]
[IsoId("__fxhARXgEeOocOqSQt5Jbw")]
[DisplayName("Transfer Out Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferOutInstructionV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.001.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfOutInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.001.001.05";
    
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
    /// Constructs a TransferOutInstructionV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferOutInstructionV05( MessageIdentification1 reqMessageIdentification,Transfer27 reqTransferDetails,InvestmentAccount40 reqAccountDetails )
    {
        MessageIdentification = reqMessageIdentification;
        TransferDetails = reqTransferDetails;
        AccountDetails = reqAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("__fxhBRXgEeOocOqSQt5Jbw")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("__fxhBxXgEeOocOqSQt5Jbw")]
    [DisplayName("Pool Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolRef")]
    #endif
    [IsoXmlTag("PoolRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? PoolReference { get; init; } 
    #else
    public AdditionalReference2? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the linked message that was previously sent.
    /// </summary>
    [IsoId("__fxhCRXgEeOocOqSQt5Jbw")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? PreviousReference { get; init; } 
    #else
    public AdditionalReference2? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("__fxhCxXgEeOocOqSQt5Jbw")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? RelatedReference { get; init; } 
    #else
    public AdditionalReference2? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("__fxhDRXgEeOocOqSQt5Jbw")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Requested date at which the instructing party places the transfer instruction.
    /// </summary>
    [IsoId("__fxhDxXgEeOocOqSQt5Jbw")]
    [DisplayName("Requested Transfer Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdTrfDt")]
    #endif
    [IsoXmlTag("ReqdTrfDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat1Choice_? RequestedTransferDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat1Choice_? RequestedTransferDate { get; init; } 
    #else
    public DateFormat1Choice_? RequestedTransferDate { get; set; } 
    #endif
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("__fxhERXgEeOocOqSQt5Jbw")]
    [DisplayName("Transfer Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfDtls")]
    #endif
    [IsoXmlTag("TrfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Transfer27 TransferDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Transfer27 TransferDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transfer27 TransferDetails { get; init; } 
    #else
    public Transfer27 TransferDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the account from which the financial instrument is to be withdrawn.
    /// </summary>
    [IsoId("__fxhExXgEeOocOqSQt5Jbw")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount40 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccount40 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount40 AccountDetails { get; init; } 
    #else
    public InvestmentAccount40 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("__fxhFRXgEeOocOqSQt5Jbw")]
    [DisplayName("Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDtls")]
    #endif
    [IsoXmlTag("SttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReceiveInformation13? SettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceiveInformation13? SettlementDetails { get; init; } 
    #else
    public ReceiveInformation13? SettlementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_zukhgBw7EeOIveEnnb_1-A")]
    [DisplayName("Market Practice Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktPrctcVrsn")]
    #endif
    [IsoXmlTag("MktPrctcVrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    #else
    public MarketPracticeVersion1? MarketPracticeVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("__fxhFxXgEeOocOqSQt5Jbw")]
    [DisplayName("Copy Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyDtls")]
    #endif
    [IsoXmlTag("CpyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CopyInformation2? CopyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CopyInformation2? CopyDetails { get; init; } 
    #else
    public CopyInformation2? CopyDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("__fxhGRXgEeOocOqSQt5Jbw")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since TransferOutInstructionV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferOutInstructionV05.

