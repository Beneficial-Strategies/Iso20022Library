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
/// This record is an implementation of the sese.018.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a (old) plan manager (Transferor), sends the AccountHoldingInformation message to the instructing party, for example, a (new) plan manager (Transferee), to provide information about financial instruments held on behalf of a client.
/// Usage
/// The AccountHoldingInformation message is used to provide information about one or more ISA or portfolio products held in a client&apos;s account.
/// </summary>
[Description(@"Scope|An executing party, for example, a (old) plan manager (Transferor), sends the AccountHoldingInformation message to the instructing party, for example, a (new) plan manager (Transferee), to provide information about financial instruments held on behalf of a client.|Usage|The AccountHoldingInformation message is used to provide information about one or more ISA or portfolio products held in a client's account.")]
[IsoId("_9tiTYR8OEeWpZde3LQh6dg")]
[DisplayName("Account Holding Information V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountHoldingInformationV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.018.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctHldgInf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.018.001.05";
    
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
    /// Constructs a AccountHoldingInformationV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountHoldingInformationV05( MessageIdentification1 reqMessageReference,Account19 reqTransferorAccount,PartyIdentification70Choice_ reqTransferee,ISATransfer23 reqProductTransfer )
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
    [IsoId("_9tiTbx8OEeWpZde3LQh6dg")]
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
    [IsoId("_9tiTcR8OEeWpZde3LQh6dg")]
    [DisplayName("Pool Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolRef")]
    #endif
    [IsoXmlTag("PoolRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference6? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference6? PoolReference { get; init; } 
    #else
    public AdditionalReference6? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_9tiTcx8OEeWpZde3LQh6dg")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference6? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference6? PreviousReference { get; init; } 
    #else
    public AdditionalReference6? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_9tiTdR8OEeWpZde3LQh6dg")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference6? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference6? RelatedReference { get; init; } 
    #else
    public AdditionalReference6? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the business flow direction type (assets to be delivered or received).
    /// </summary>
    [IsoId("_9tiTdx8OEeWpZde3LQh6dg")]
    [DisplayName("Business Flow Direction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizFlowDrctnTp")]
    #endif
    [IsoXmlTag("BizFlowDrctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessFlowDirectionType1Code? BusinessFlowDirectionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessFlowDirectionType1Code? BusinessFlowDirectionType { get; init; } 
    #else
    public BusinessFlowDirectionType1Code? BusinessFlowDirectionType { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_9tiTeR8OEeWpZde3LQh6dg")]
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
    [IsoId("_9tiTex8OEeWpZde3LQh6dg")]
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
    /// Information identifying other individual investors, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_9tiTfR8OEeWpZde3LQh6dg")]
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
    [IsoId("_9tiTfx8OEeWpZde3LQh6dg")]
    [DisplayName("Primary Corporate Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryCorpInvstr")]
    #endif
    [IsoXmlTag("PmryCorpInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation21? PrimaryCorporateInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation21? PrimaryCorporateInvestor { get; init; } 
    #else
    public Organisation21? PrimaryCorporateInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the secondary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_9tiTgR8OEeWpZde3LQh6dg")]
    [DisplayName("Secondary Corporate Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryCorpInvstr")]
    #endif
    [IsoXmlTag("ScndryCorpInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation21? SecondaryCorporateInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation21? SecondaryCorporateInvestor { get; init; } 
    #else
    public Organisation21? SecondaryCorporateInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying the other corporate investors, for example, name and address.
    /// </summary>
    [IsoId("_9tiTgx8OEeWpZde3LQh6dg")]
    [DisplayName("Other Corporate Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCorpInvstr")]
    #endif
    [IsoXmlTag("OthrCorpInvstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation21? OtherCorporateInvestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation21? OtherCorporateInvestor { get; init; } 
    #else
    public Organisation21? OtherCorporateInvestor { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_9tiThR8OEeWpZde3LQh6dg")]
    [DisplayName("Transferor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfrAcct")]
    #endif
    [IsoXmlTag("TrfrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Account19 TransferorAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Account19 TransferorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account19 TransferorAccount { get; init; } 
    #else
    public Account19 TransferorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_9tiThx8OEeWpZde3LQh6dg")]
    [DisplayName("Nominee Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmneeAcct")]
    #endif
    [IsoXmlTag("NmneeAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account19? NomineeAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account19? NomineeAccount { get; init; } 
    #else
    public Account19? NomineeAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_9tiTiR8OEeWpZde3LQh6dg")]
    [DisplayName("Transferee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trfee")]
    #endif
    [IsoXmlTag("Trfee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification70Choice_ Transferee { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification70Choice_ Transferee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification70Choice_ Transferee { get; init; } 
    #else
    public PartyIdentification70Choice_ Transferee { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_9tiTix8OEeWpZde3LQh6dg")]
    [DisplayName("Product Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctTrf")]
    #endif
    [IsoXmlTag("PdctTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ISATransfer23 ProductTransfer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ISATransfer23 ProductTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ISATransfer23 ProductTransfer { get; init; } 
    #else
    public ISATransfer23 ProductTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_9tiTjR8OEeWpZde3LQh6dg")]
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
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_9tiTjx8OEeWpZde3LQh6dg")]
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


// Since AccountHoldingInformationV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountHoldingInformationV05.

