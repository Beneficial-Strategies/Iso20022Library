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
/// This record is an implementation of the sese.019.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountHoldingInformationRequest message is sent by an instructing party, for example, a (new) plan manager (transferee), to the executing party, for example, a (old) plan manager (transferor), on behalf of the initiating party, for example, an investor (client), to request information about financial instruments held on behalf of the client.
/// Usage
/// The AccountHoldingInformationRequest message is used to request information about assets held on behalf of the client for which it intends to instruct a portfolio transfer at a later time.
/// </summary>
[Description(
    @"Scope|The AccountHoldingInformationRequest message is sent by an instructing party, for example, a (new) plan manager (transferee), to the executing party, for example, a (old) plan manager (transferor), on behalf of the initiating party, for example, an investor (client), to request information about financial instruments held on behalf of the client.|Usage|The AccountHoldingInformationRequest message is used to request information about assets held on behalf of the client for which it intends to instruct a portfolio transfer at a later time."
)]
[IsoId("_wElHYZDhEem7fvtoGpNpow")]
[DisplayName("Account Holding Information Request V")]
public record AccountHoldingInformationRequestV07 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.019.001.07";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctHldgInfReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.07";

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
    [IsoId("_wElHaZDhEem7fvtoGpNpow")]
    [DisplayName("Message Reference")]
    [IsoXmlTag("MsgRef")]
    public required MessageIdentification1 MessageReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_wElHa5DhEem7fvtoGpNpow")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference11? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_wElHbZDhEem7fvtoGpNpow")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference10? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_wElHb5DhEem7fvtoGpNpow")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference10? RelatedReference { get; init; }

    /// <summary>
    /// Business flow direction (assets to be delivered or received).
    /// </summary>
    [IsoId("_wElHcZDhEem7fvtoGpNpow")]
    [DisplayName("Business Flow Direction Type")]
    [IsoXmlTag("BizFlowDrctnTp")]
    public BusinessFlowDirectionType1Code? BusinessFlowDirectionType { get; init; }

    /// <summary>
    /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_wElHc5DhEem7fvtoGpNpow")]
    [DisplayName("Primary Individual Investor")]
    [IsoXmlTag("PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_wElHdZDhEem7fvtoGpNpow")]
    [DisplayName("Secondary Individual Investor")]
    [IsoXmlTag("ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the other individual investors, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_wElHd5DhEem7fvtoGpNpow")]
    [DisplayName("Other Individual Investor")]
    [IsoXmlTag("OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the primary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_wElHeZDhEem7fvtoGpNpow")]
    [DisplayName("Primary Corporate Investor")]
    [IsoXmlTag("PmryCorpInvstr")]
    public Organisation36? PrimaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_wElHe5DhEem7fvtoGpNpow")]
    [DisplayName("Secondary Corporate Investor")]
    [IsoXmlTag("ScndryCorpInvstr")]
    public Organisation36? SecondaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the other corporate investors, for example, name and address.
    /// </summary>
    [IsoId("_wElHfZDhEem7fvtoGpNpow")]
    [DisplayName("Other Corporate Investor")]
    [IsoXmlTag("OthrCorpInvstr")]
    public Organisation36? OtherCorporateInvestor { get; init; }

    /// <summary>
    /// Identification of the account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_wElHf5DhEem7fvtoGpNpow")]
    [DisplayName("Transferor Account")]
    [IsoXmlTag("TrfrAcct")]
    public required InvestmentAccount69 TransferorAccount { get; init; }

    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_wElHgZDhEem7fvtoGpNpow")]
    [DisplayName("Nominee Account")]
    [IsoXmlTag("NmneeAcct")]
    public InvestmentAccount69? NomineeAccount { get; init; }

    /// <summary>
    /// Identification of the institution to which the financial instrument is to be transferred. This may also be known as the new plan manager.
    /// </summary>
    [IsoId("_wElHg5DhEem7fvtoGpNpow")]
    [DisplayName("Transferee")]
    [IsoXmlTag("Trfee")]
    public required PartyIdentification132 Transferee { get; init; }

    /// <summary>
    /// Information about the portfolio and assets.
    /// </summary>
    [IsoId("_wElHhZDhEem7fvtoGpNpow")]
    [DisplayName("Product Transfer")]
    [IsoXmlTag("PdctTrf")]
    public required PortfolioTransfer6 ProductTransfer { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_wElHh5DhEem7fvtoGpNpow")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_wElHiZDhEem7fvtoGpNpow")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since AccountHoldingInformationRequestV07Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountHoldingInformationRequestV07.
