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
/// This record is an implementation of the sese.019.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, a (new) plan manager (Transferee) sends the AccountHoldingInformationRequest message to the executing party, for example, a (old) plan manager (Transferor), on behalf of the initiating party, for example, an investor (client), to request information about financial instruments held on behalf of the client.
/// Usage
/// The AccountHoldingInformationRequest message is used to request information about one or more ISA or portfolio products held in a client&apos;s account for which it intends to instruct a transfer at a later time.
/// </summary>
[Description(
    @"Scope|An instructing party, for example, a (new) plan manager (Transferee) sends the AccountHoldingInformationRequest message to the executing party, for example, a (old) plan manager (Transferor), on behalf of the initiating party, for example, an investor (client), to request information about financial instruments held on behalf of the client.|Usage|The AccountHoldingInformationRequest message is used to request information about one or more ISA or portfolio products held in a client's account for which it intends to instruct a transfer at a later time."
)]
[IsoId("_CpsEUR8PEeWpZde3LQh6dg")]
[DisplayName("Account Holding Information Request V")]
public record AccountHoldingInformationRequestV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.019.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctHldgInfReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_CpsEXx8PEeWpZde3LQh6dg")]
    [DisplayName("Message Reference")]
    [IsoXmlTag("MsgRef")]
    public required MessageIdentification1 MessageReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_CpsEYR8PEeWpZde3LQh6dg")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference6? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_CpsEYx8PEeWpZde3LQh6dg")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference6? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_CpsEZR8PEeWpZde3LQh6dg")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference6? RelatedReference { get; init; }

    /// <summary>
    /// Identifies the business flow type (assets to be delivered or received).
    /// </summary>
    [IsoId("_CpsEZx8PEeWpZde3LQh6dg")]
    [DisplayName("Business Flow Direction Type")]
    [IsoXmlTag("BizFlowDrctnTp")]
    public BusinessFlowDirectionType1Code? BusinessFlowDirectionType { get; init; }

    /// <summary>
    /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_CpsEaR8PEeWpZde3LQh6dg")]
    [DisplayName("Primary Individual Investor")]
    [IsoXmlTag("PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_CpsEax8PEeWpZde3LQh6dg")]
    [DisplayName("Secondary Individual Investor")]
    [IsoXmlTag("ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying other individual investors, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_CpsEbR8PEeWpZde3LQh6dg")]
    [DisplayName("Other Individual Investor")]
    [IsoXmlTag("OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the primary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_CpsEbx8PEeWpZde3LQh6dg")]
    [DisplayName("Primary Corporate Investor")]
    [IsoXmlTag("PmryCorpInvstr")]
    public Organisation21? PrimaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_CpsEcR8PEeWpZde3LQh6dg")]
    [DisplayName("Secondary Corporate Investor")]
    [IsoXmlTag("ScndryCorpInvstr")]
    public Organisation21? SecondaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the other corporate investors, for example, name and address.
    /// </summary>
    [IsoId("_CpsEcx8PEeWpZde3LQh6dg")]
    [DisplayName("Other Corporate Investor")]
    [IsoXmlTag("OthrCorpInvstr")]
    public Organisation21? OtherCorporateInvestor { get; init; }

    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_CpsEdR8PEeWpZde3LQh6dg")]
    [DisplayName("Transferor Account")]
    [IsoXmlTag("TrfrAcct")]
    public required Account19 TransferorAccount { get; init; }

    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_CpsEdx8PEeWpZde3LQh6dg")]
    [DisplayName("Nominee Account")]
    [IsoXmlTag("NmneeAcct")]
    public Account19? NomineeAccount { get; init; }

    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_CpsEeR8PEeWpZde3LQh6dg")]
    [DisplayName("Transferee")]
    [IsoXmlTag("Trfee")]
    public required PartyIdentification70Choice_ Transferee { get; init; }

    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_CpsEex8PEeWpZde3LQh6dg")]
    [DisplayName("Product Transfer")]
    [IsoXmlTag("PdctTrf")]
    public required ISATransfer27 ProductTransfer { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_CpsEfR8PEeWpZde3LQh6dg")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_CpsEfx8PEeWpZde3LQh6dg")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since AccountHoldingInformationRequestV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountHoldingInformationRequestV04.
