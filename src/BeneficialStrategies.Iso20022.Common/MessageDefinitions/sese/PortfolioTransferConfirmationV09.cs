// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.013.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The PortfolioTransferConfirmation message is sent by an executing party, for example, a (old) plan manager (transferor), to the instructing party for example, a (new) plan manager (transferee), to confirm the transfer of financial instruments from the client’s account at the old plan manager (transferor) to the clients account at the new plan manager (transferee).
/// Usage
/// The PortfolioTransferConfirmation message is used to confirm one or more portfolio transfers for one client.
/// The reference of each portfolio transfer confirmation is identified in TransferConfirmationIdentification. The reference of the original portfolio transfer as assigned by the instructing party is specified in TransferInstructionReference. The message identification of the PortfolioTransferInstruction message in which the portfolio transfers were conveyed may also be quoted in RelatedReference but this is not recommended.
/// </summary>
[Description(
    @"Scope|The PortfolioTransferConfirmation message is sent by an executing party, for example, a (old) plan manager (transferor), to the instructing party for example, a (new) plan manager (transferee), to confirm the transfer of financial instruments from the client’s account at the old plan manager (transferor) to the clients account at the new plan manager (transferee). |Usage|The PortfolioTransferConfirmation message is used to confirm one or more portfolio transfers for one client.|The reference of each portfolio transfer confirmation is identified in TransferConfirmationIdentification. The reference of the original portfolio transfer as assigned by the instructing party is specified in TransferInstructionReference. The message identification of the PortfolioTransferInstruction message in which the portfolio transfers were conveyed may also be quoted in RelatedReference but this is not recommended."
)]
[IsoId("_9xnhsUyFEeir2sRRVd9XhA")]
[DisplayName("Portfolio Transfer Confirmation V")]
public record PortfolioTransferConfirmationV09 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.013.001.09";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtflTrfConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.013.001.09";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_9xnhv0yFEeir2sRRVd9XhA")]
    [DisplayName("Message Reference")]
    [IsoXmlTag("MsgRef")]
    public required MessageIdentification1 MessageReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_9xnhwUyFEeir2sRRVd9XhA")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference11? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_9xnhw0yFEeir2sRRVd9XhA")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference10? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_9xnhxUyFEeir2sRRVd9XhA")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference10? RelatedReference { get; init; }

    /// <summary>
    /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_9xnhx0yFEeir2sRRVd9XhA")]
    [DisplayName("Primary Individual Investor")]
    [IsoXmlTag("PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; }

    /// <summary>
    /// Official registered holder information.
    /// </summary>
    [IsoId("_ohJB0FLUEeiSDqv62fL07g")]
    [DisplayName("Registered Holder")]
    [IsoXmlTag("RegdHldr")]
    public IndividualPerson8? RegisteredHolder { get; init; }

    /// <summary>
    /// Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_9xnhyUyFEeir2sRRVd9XhA")]
    [DisplayName("Secondary Individual Investor")]
    [IsoXmlTag("ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the other individual investors, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_9xnhy0yFEeir2sRRVd9XhA")]
    [DisplayName("Other Individual Investor")]
    [IsoXmlTag("OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the primary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_9xnhzUyFEeir2sRRVd9XhA")]
    [DisplayName("Primary Corporate Investor")]
    [IsoXmlTag("PmryCorpInvstr")]
    public Organisation36? PrimaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_9xnhz0yFEeir2sRRVd9XhA")]
    [DisplayName("Secondary Corporate Investor")]
    [IsoXmlTag("ScndryCorpInvstr")]
    public Organisation36? SecondaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the other corporate investors, for example, name and address.
    /// </summary>
    [IsoId("_9xnh0UyFEeir2sRRVd9XhA")]
    [DisplayName("Other Corporate Investor")]
    [IsoXmlTag("OthrCorpInvstr")]
    public Organisation36? OtherCorporateInvestor { get; init; }

    /// <summary>
    /// Identification of the account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_9xnh00yFEeir2sRRVd9XhA")]
    [DisplayName("Transferor Account")]
    [IsoXmlTag("TrfrAcct")]
    public required InvestmentAccount69 TransferorAccount { get; init; }

    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_9xnh1UyFEeir2sRRVd9XhA")]
    [DisplayName("Nominee Account")]
    [IsoXmlTag("NmneeAcct")]
    public InvestmentAccount69? NomineeAccount { get; init; }

    /// <summary>
    /// Identification of the institution to which the financial instrument is to be transferred. This may also be known as the new plan manager.
    /// </summary>
    [IsoId("_9xnh10yFEeir2sRRVd9XhA")]
    [DisplayName("Transferee")]
    [IsoXmlTag("Trfee")]
    public required PartyIdentification132 Transferee { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_9xnh2UyFEeir2sRRVd9XhA")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public Intermediary43? IntermediaryInformation { get; init; }

    /// <summary>
    /// Information about the portfolio and assets.
    /// </summary>
    [IsoId("_9xnh3UyFEeir2sRRVd9XhA")]
    [DisplayName("Product Transfer")]
    [IsoXmlTag("PdctTrf")]
    public required PortfolioTransfer4 ProductTransfer { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_9xnh30yFEeir2sRRVd9XhA")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_9xnh4UyFEeir2sRRVd9XhA")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since PortfolioTransferConfirmationV09Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PortfolioTransferConfirmationV09.
