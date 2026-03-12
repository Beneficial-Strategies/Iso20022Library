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
/// This record is an implementation of the sese.012.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, a (new) plan manager (Transferee), sends the PortfolioTransferInstruction message to the executing party, for example, a (old) plan manager (Transferor), on behalf of the initiating party, for example, an investor (client), to instruct the transfer of financial instruments from the clients account at the old plan manager (Transferor) to the clients account at the new plan manager (Transferee) through a nominee account.
/// Usage
/// The PortfolioTransferInstruction message is used to instruct the withdrawal of one or more ISA or portfolio products from one account and deliver them to another account.
/// The PortfolioTransferInstruction message is used to instruct one or more transfers for one client. Each transfer is for delivery to the same account. The account may be owned by one or more individual investors or one or more corporate investors. Each transfer is identified in TransferIdentification.
/// If the instructing party does not have enough information to instruct the transfer, then it must first send a AccountHoldingInformationRequest message to the executing party in order to receive a AccountHoldingInformation message.
/// </summary>
[Description(@"Scope|An instructing party, for example, a (new) plan manager (Transferee), sends the PortfolioTransferInstruction message to the executing party, for example, a (old) plan manager (Transferor), on behalf of the initiating party, for example, an investor (client), to instruct the transfer of financial instruments from the clients account at the old plan manager (Transferor) to the clients account at the new plan manager (Transferee) through a nominee account.|Usage|The PortfolioTransferInstruction message is used to instruct the withdrawal of one or more ISA or portfolio products from one account and deliver them to another account.|The PortfolioTransferInstruction message is used to instruct one or more transfers for one client. Each transfer is for delivery to the same account. The account may be owned by one or more individual investors or one or more corporate investors. Each transfer is identified in TransferIdentification.|If the instructing party does not have enough information to instruct the transfer, then it must first send a AccountHoldingInformationRequest message to the executing party in order to receive a AccountHoldingInformation message.")]
[IsoId("_5biYIQgLEeSFYfyUKDXKaw")]
[DisplayName("Portfolio Transfer Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PortfolioTransferInstructionV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.012.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtflTrfInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.012.001.06";
    
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
    /// Constructs a PortfolioTransferInstructionV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PortfolioTransferInstructionV06( MessageIdentification1 reqMessageReference,Account15 reqTransferorAccount,PartyIdentification2Choice_ reqTransferee,ISATransfer18 reqProductTransfer )
    {
        MessageReference = reqMessageReference;
        TransferorAccount = reqTransferorAccount;
        Transferee = reqTransferee;
        ProductTransfer = reqProductTransfer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_5biYLwgLEeSFYfyUKDXKaw")]
    [DisplayName("Message Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRef")]
    #endif
    [IsoXmlTag("MsgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageReference { get; init; } 
    #else
    public MessageIdentification1 MessageReference { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_5biYMQgLEeSFYfyUKDXKaw")]
    [DisplayName("Pool Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolRef")]
    #endif
    [IsoXmlTag("PoolRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PoolReference { get; init; } 
    #else
    public AdditionalReference3? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_5biYMwgLEeSFYfyUKDXKaw")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PreviousReference { get; init; } 
    #else
    public AdditionalReference3? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_5biYNQgLEeSFYfyUKDXKaw")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? RelatedReference { get; init; } 
    #else
    public AdditionalReference3? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_5biYNwgLEeSFYfyUKDXKaw")]
    [DisplayName("Primary Individual Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryIndvInvstr")]
    #endif
    [IsoXmlTag("PmryIndvInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
    #else
    public IndividualPerson8? PrimaryIndividualInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_5biYOQgLEeSFYfyUKDXKaw")]
    [DisplayName("Secondary Individual Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryIndvInvstr")]
    #endif
    [IsoXmlTag("ScndryIndvInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
    #else
    public IndividualPerson8? SecondaryIndividualInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the other individual investors, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_5biYOwgLEeSFYfyUKDXKaw")]
    [DisplayName("Other Individual Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrIndvInvstr")]
    #endif
    [IsoXmlTag("OthrIndvInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson8? OtherIndividualInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson8? OtherIndividualInvestor { get; init; } 
    #else
    public IndividualPerson8? OtherIndividualInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the primary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_5biYPQgLEeSFYfyUKDXKaw")]
    [DisplayName("Primary Corporate Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryCorpInvstr")]
    #endif
    [IsoXmlTag("PmryCorpInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation4? PrimaryCorporateInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation4? PrimaryCorporateInvestor { get; init; } 
    #else
    public Organisation4? PrimaryCorporateInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the secondary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_5biYPwgLEeSFYfyUKDXKaw")]
    [DisplayName("Secondary Corporate Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryCorpInvstr")]
    #endif
    [IsoXmlTag("ScndryCorpInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation4? SecondaryCorporateInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation4? SecondaryCorporateInvestor { get; init; } 
    #else
    public Organisation4? SecondaryCorporateInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the other corporate investors, for example, name and address.
    /// </summary>
    [IsoId("_5biYQQgLEeSFYfyUKDXKaw")]
    [DisplayName("Other Corporate Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCorpInvstr")]
    #endif
    [IsoXmlTag("OthrCorpInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation4? OtherCorporateInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation4? OtherCorporateInvestor { get; init; } 
    #else
    public Organisation4? OtherCorporateInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_5biYQwgLEeSFYfyUKDXKaw")]
    [DisplayName("Transferor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfrAcct")]
    #endif
    [IsoXmlTag("TrfrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Account15 TransferorAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Account15 TransferorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account15 TransferorAccount { get; init; } 
    #else
    public Account15 TransferorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_5biYRQgLEeSFYfyUKDXKaw")]
    [DisplayName("Nominee Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmneeAcct")]
    #endif
    [IsoXmlTag("NmneeAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account16? NomineeAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account16? NomineeAccount { get; init; } 
    #else
    public Account16? NomineeAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_5biYRwgLEeSFYfyUKDXKaw")]
    [DisplayName("Transferee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trfee")]
    #endif
    [IsoXmlTag("Trfee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification2Choice_ Transferee { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification2Choice_ Transferee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_ Transferee { get; init; } 
    #else
    public PartyIdentification2Choice_ Transferee { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).
    /// </summary>
    [IsoId("_5biYSQgLEeSFYfyUKDXKaw")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount29? CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount29? CashAccount { get; init; } 
    #else
    public CashAccount29? CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_5biYSwgLEeSFYfyUKDXKaw")]
    [DisplayName("Product Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctTrf")]
    #endif
    [IsoXmlTag("PdctTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ISATransfer18 ProductTransfer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ISATransfer18 ProductTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ISATransfer18 ProductTransfer { get; init; } 
    #else
    public ISATransfer18 ProductTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_5biYTQgLEeSFYfyUKDXKaw")]
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
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5biYTwgLEeSFYfyUKDXKaw")]
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


// Since PortfolioTransferInstructionV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PortfolioTransferInstructionV06.

