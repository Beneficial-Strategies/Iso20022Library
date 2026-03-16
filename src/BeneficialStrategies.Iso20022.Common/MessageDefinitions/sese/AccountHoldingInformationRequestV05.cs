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
/// This record is an implementation of the sese.019.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountHoldingInformationRequest message is sent by an instructing party, for example, a (new) plan manager (transferee), to the executing party, for example, a (old) plan manager (transferor), on behalf of the initiating party, for example, an investor (client), to request information about financial instruments held on behalf of the client.
/// Usage
/// The AccountHoldingInformationRequest message is used to request information about one or more ISA or portfolio products held in a client&apos;s account for which it intends to instruct a transfer at a later time.
/// </summary>
[Description(
    @"Scope|The AccountHoldingInformationRequest message is sent by an instructing party, for example, a (new) plan manager (transferee), to the executing party, for example, a (old) plan manager (transferor), on behalf of the initiating party, for example, an investor (client), to request information about financial instruments held on behalf of the client.|Usage|The AccountHoldingInformationRequest message is used to request information about one or more ISA or portfolio products held in a client's account for which it intends to instruct a transfer at a later time."
)]
[IsoId("_mLpEcYZMEeemXK0UETsSiA")]
[DisplayName("Account Holding Information Request V")]
public record AccountHoldingInformationRequestV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.019.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctHldgInfReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.05";

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
    [IsoId("_mLpEf4ZMEeemXK0UETsSiA")]
    [DisplayName("Message Reference")]
    [IsoXmlTag("MsgRef")]
    public required MessageIdentification1 MessageReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_mLpEgYZMEeemXK0UETsSiA")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference9? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_mLpEg4ZMEeemXK0UETsSiA")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference8? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_mLpEhYZMEeemXK0UETsSiA")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference8? RelatedReference { get; init; }

    /// <summary>
    /// Identifies the business flow direction (assets to be delivered or received).
    /// </summary>
    [IsoId("_mLpEh4ZMEeemXK0UETsSiA")]
    [DisplayName("Business Flow Direction Type")]
    [IsoXmlTag("BizFlowDrctnTp")]
    public BusinessFlowDirectionType1Code? BusinessFlowDirectionType { get; init; }

    /// <summary>
    /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_mLpEiYZMEeemXK0UETsSiA")]
    [DisplayName("Primary Individual Investor")]
    [IsoXmlTag("PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_mLpEi4ZMEeemXK0UETsSiA")]
    [DisplayName("Secondary Individual Investor")]
    [IsoXmlTag("ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying other individual investors, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_mLpEjYZMEeemXK0UETsSiA")]
    [DisplayName("Other Individual Investor")]
    [IsoXmlTag("OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the primary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_mLpEj4ZMEeemXK0UETsSiA")]
    [DisplayName("Primary Corporate Investor")]
    [IsoXmlTag("PmryCorpInvstr")]
    public Organisation31? PrimaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_mLpEkYZMEeemXK0UETsSiA")]
    [DisplayName("Secondary Corporate Investor")]
    [IsoXmlTag("ScndryCorpInvstr")]
    public Organisation31? SecondaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the other corporate investors, for example, name and address.
    /// </summary>
    [IsoId("_mLpEk4ZMEeemXK0UETsSiA")]
    [DisplayName("Other Corporate Investor")]
    [IsoXmlTag("OthrCorpInvstr")]
    public Organisation31? OtherCorporateInvestor { get; init; }

    /// <summary>
    /// Identification of the account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_mLpElYZMEeemXK0UETsSiA")]
    [DisplayName("Transferor Account")]
    [IsoXmlTag("TrfrAcct")]
    public required Account24 TransferorAccount { get; init; }

    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_mLpEl4ZMEeemXK0UETsSiA")]
    [DisplayName("Nominee Account")]
    [IsoXmlTag("NmneeAcct")]
    public Account24? NomineeAccount { get; init; }

    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_mLpEmYZMEeemXK0UETsSiA")]
    [DisplayName("Transferee")]
    [IsoXmlTag("Trfee")]
    public required PartyIdentification113 Transferee { get; init; }

    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_mLpEm4ZMEeemXK0UETsSiA")]
    [DisplayName("Product Transfer")]
    [IsoXmlTag("PdctTrf")]
    public required ISATransfer31 ProductTransfer { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_mLpEnYZMEeemXK0UETsSiA")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_mLpEn4ZMEeemXK0UETsSiA")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since AccountHoldingInformationRequestV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountHoldingInformationRequestV05.
