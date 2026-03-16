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
/// This record is an implementation of the sese.018.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountHoldingInformation message is sent by an executing party, for example, a (old) plan manager (transferor), to the instructing party, for example, a (new) plan manager (transferee), to provide information about financial instruments held on behalf of a client.
/// Usage
/// The AccountHoldingInformation message is used to provide information about one or more ISA or portfolio products held in a client&apos;s account.
/// </summary>
[Description(
    @"Scope|The AccountHoldingInformation message is sent by an executing party, for example, a (old) plan manager (transferor), to the instructing party, for example, a (new) plan manager (transferee), to provide information about financial instruments held on behalf of a client.|Usage|The AccountHoldingInformation message is used to provide information about one or more ISA or portfolio products held in a client's account."
)]
[IsoId("_jcYo4YZMEeemXK0UETsSiA")]
[DisplayName("Account Holding Information V")]
public record AccountHoldingInformationV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.018.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctHldgInf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.018.001.06";

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
    [IsoId("_jcYo74ZMEeemXK0UETsSiA")]
    [DisplayName("Message Reference")]
    [IsoXmlTag("MsgRef")]
    public required MessageIdentification1 MessageReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_jcYo8YZMEeemXK0UETsSiA")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference9? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_jcYo84ZMEeemXK0UETsSiA")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference8? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_jcYo9YZMEeemXK0UETsSiA")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference8? RelatedReference { get; init; }

    /// <summary>
    /// Identifies the business flow direction (assets to be delivered or received).
    /// </summary>
    [IsoId("_jcYo94ZMEeemXK0UETsSiA")]
    [DisplayName("Business Flow Direction Type")]
    [IsoXmlTag("BizFlowDrctnTp")]
    public BusinessFlowDirectionType1Code? BusinessFlowDirectionType { get; init; }

    /// <summary>
    /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_jcYo-YZMEeemXK0UETsSiA")]
    [DisplayName("Primary Individual Investor")]
    [IsoXmlTag("PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_jcYo-4ZMEeemXK0UETsSiA")]
    [DisplayName("Secondary Individual Investor")]
    [IsoXmlTag("ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying other individual investors, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_jcYo_YZMEeemXK0UETsSiA")]
    [DisplayName("Other Individual Investor")]
    [IsoXmlTag("OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the primary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_jcYo_4ZMEeemXK0UETsSiA")]
    [DisplayName("Primary Corporate Investor")]
    [IsoXmlTag("PmryCorpInvstr")]
    public Organisation31? PrimaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_jcYpAYZMEeemXK0UETsSiA")]
    [DisplayName("Secondary Corporate Investor")]
    [IsoXmlTag("ScndryCorpInvstr")]
    public Organisation31? SecondaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the other corporate investors, for example, name and address.
    /// </summary>
    [IsoId("_jcYpA4ZMEeemXK0UETsSiA")]
    [DisplayName("Other Corporate Investor")]
    [IsoXmlTag("OthrCorpInvstr")]
    public Organisation31? OtherCorporateInvestor { get; init; }

    /// <summary>
    /// Identification of the account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_jcYpBYZMEeemXK0UETsSiA")]
    [DisplayName("Transferor Account")]
    [IsoXmlTag("TrfrAcct")]
    public required Account24 TransferorAccount { get; init; }

    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_jcYpB4ZMEeemXK0UETsSiA")]
    [DisplayName("Nominee Account")]
    [IsoXmlTag("NmneeAcct")]
    public Account24? NomineeAccount { get; init; }

    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_jcYpCYZMEeemXK0UETsSiA")]
    [DisplayName("Transferee")]
    [IsoXmlTag("Trfee")]
    public required PartyIdentification113 Transferee { get; init; }

    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_jcYpC4ZMEeemXK0UETsSiA")]
    [DisplayName("Product Transfer")]
    [IsoXmlTag("PdctTrf")]
    public required ISATransfer30 ProductTransfer { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_jcYpDYZMEeemXK0UETsSiA")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_jcYpD4ZMEeemXK0UETsSiA")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since AccountHoldingInformationV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountHoldingInformationV06.
