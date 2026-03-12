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



namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.012.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The PortfolioTransferInstruction message is sent by an instructing party, for example, a (new) plan manager (transferee), to the executing party, for example, a (old) plan manager (transferor), on behalf of the initiating party, for example, an investor (client), to instruct the transfer of financial instruments from the client’s account at the old plan manager (transferor) to the clients account at the new plan manager (transferee). 
/// Usage
/// The PortfolioTransferInstruction message is used to instruct one or more portfolio transfers for one client. Each portfolio transfer is for delivery to the same account. The account may be owned by one or more individual investors or one or more corporate investors.
/// If the instructing party does not have enough information to instruct the portfolio transfer, then it must first send an AccountHoldingInformationRequest message to the executing party in order to receive an AccountHoldingInformation message.
/// </summary>
[Description(@"Scope|The PortfolioTransferInstruction message is sent by an instructing party, for example, a (new) plan manager (transferee), to the executing party, for example, a (old) plan manager (transferor), on behalf of the initiating party, for example, an investor (client), to instruct the transfer of financial instruments from the client’s account at the old plan manager (transferor) to the clients account at the new plan manager (transferee). |Usage|The PortfolioTransferInstruction message is used to instruct one or more portfolio transfers for one client. Each portfolio transfer is for delivery to the same account. The account may be owned by one or more individual investors or one or more corporate investors.|If the instructing party does not have enough information to instruct the portfolio transfer, then it must first send an AccountHoldingInformationRequest message to the executing party in order to receive an AccountHoldingInformation message.")]
[IsoId("_63pq8UyFEeir2sRRVd9XhA")]
[DisplayName("Portfolio Transfer Instruction V")]
public partial record PortfolioTransferInstructionV09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.012.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtflTrfInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.012.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_63pq_0yFEeir2sRRVd9XhA")]
    [DisplayName("Message Reference")]
    [IsoXmlTag("MsgRef")]
    public required MessageIdentification1 MessageReference { get; init; } 
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_63prAUyFEeir2sRRVd9XhA")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference11? PoolReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_63prA0yFEeir2sRRVd9XhA")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference10? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_63prBUyFEeir2sRRVd9XhA")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference10? RelatedReference { get; init; } 
    
    /// <summary>
    /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_63prB0yFEeir2sRRVd9XhA")]
    [DisplayName("Primary Individual Investor")]
    [IsoXmlTag("PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_63prCUyFEeir2sRRVd9XhA")]
    [DisplayName("Secondary Individual Investor")]
    [IsoXmlTag("ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying the other individual investors, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_63prC0yFEeir2sRRVd9XhA")]
    [DisplayName("Other Individual Investor")]
    [IsoXmlTag("OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying the primary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_63prDUyFEeir2sRRVd9XhA")]
    [DisplayName("Primary Corporate Investor")]
    [IsoXmlTag("PmryCorpInvstr")]
    public Organisation36? PrimaryCorporateInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying the secondary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_63prD0yFEeir2sRRVd9XhA")]
    [DisplayName("Secondary Corporate Investor")]
    [IsoXmlTag("ScndryCorpInvstr")]
    public Organisation36? SecondaryCorporateInvestor { get; init; } 
    
    /// <summary>
    /// Information identifying the other corporate investors, for example, name and address.
    /// </summary>
    [IsoId("_63prEUyFEeir2sRRVd9XhA")]
    [DisplayName("Other Corporate Investor")]
    [IsoXmlTag("OthrCorpInvstr")]
    public Organisation36? OtherCorporateInvestor { get; init; } 
    
    /// <summary>
    /// Identification of the account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_63prE0yFEeir2sRRVd9XhA")]
    [DisplayName("Transferor Account")]
    [IsoXmlTag("TrfrAcct")]
    public required InvestmentAccount69 TransferorAccount { get; init; } 
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_63prFUyFEeir2sRRVd9XhA")]
    [DisplayName("Nominee Account")]
    [IsoXmlTag("NmneeAcct")]
    public InvestmentAccount69? NomineeAccount { get; init; } 
    
    /// <summary>
    /// Identification of the institution to which the financial instrument is to be transferred. This may also be known as the new plan manager.
    /// </summary>
    [IsoId("_63prF0yFEeir2sRRVd9XhA")]
    [DisplayName("Transferee")]
    [IsoXmlTag("Trfee")]
    public required PartyIdentification132 Transferee { get; init; } 
    
    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_63prGUyFEeir2sRRVd9XhA")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public Intermediary43? IntermediaryInformation { get; init; } 
    
    /// <summary>
    /// Information about the portfolio and assets.
    /// </summary>
    [IsoId("_63prHUyFEeir2sRRVd9XhA")]
    [DisplayName("Product Transfer")]
    [IsoXmlTag("PdctTrf")]
    public required PortfolioTransfer3 ProductTransfer { get; init; } 
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_63prH0yFEeir2sRRVd9XhA")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_63prIUyFEeir2sRRVd9XhA")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since PortfolioTransferInstructionV09Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PortfolioTransferInstructionV09.

