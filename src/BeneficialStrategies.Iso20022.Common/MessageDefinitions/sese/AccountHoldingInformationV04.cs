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
/// This record is an implementation of the sese.018.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a (old) plan manager (Transferor), sends the AccountHoldingInformation message to the instructing party, for example, a (new) plan manager (Transferee), to provide information about financial instruments held on behalf of a client.
/// Usage
/// The AccountHoldingInformation message is used to provide information about one or more ISA or portfolio products held in a client&apos;s account.
/// </summary>
[Description(
    @"Scope|An executing party, for example, a (old) plan manager (Transferor), sends the AccountHoldingInformation message to the instructing party, for example, a (new) plan manager (Transferee), to provide information about financial instruments held on behalf of a client.|Usage|The AccountHoldingInformation message is used to provide information about one or more ISA or portfolio products held in a client's account."
)]
[IsoId("_F5S5wRXfEeOocOqSQt5Jbw")]
[DisplayName("Account Holding Information V")]
public record AccountHoldingInformationV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.018.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctHldgInf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.018.001.04";

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
    [IsoId("_F5S5yxXfEeOocOqSQt5Jbw")]
    [DisplayName("Message Reference")]
    [IsoXmlTag("MsgRef")]
    public required MessageIdentification1 MessageReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_F5S5zRXfEeOocOqSQt5Jbw")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_F5S5zxXfEeOocOqSQt5Jbw")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_F5S50RXfEeOocOqSQt5Jbw")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// Identifies the business flow direction type (assets to be delivered or received).
    /// </summary>
    [IsoId("_F5S50xXfEeOocOqSQt5Jbw")]
    [DisplayName("Business Flow Direction Type")]
    [IsoXmlTag("BizFlowDrctnTp")]
    public BusinessFlowDirectionType1Code? BusinessFlowDirectionType { get; init; }

    /// <summary>
    /// Information identifying the primary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_F5S51RXfEeOocOqSQt5Jbw")]
    [DisplayName("Primary Individual Investor")]
    [IsoXmlTag("PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_F5S51xXfEeOocOqSQt5Jbw")]
    [DisplayName("Secondary Individual Investor")]
    [IsoXmlTag("ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying other individual investors, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_F5S52RXfEeOocOqSQt5Jbw")]
    [DisplayName("Other Individual Investor")]
    [IsoXmlTag("OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; }

    /// <summary>
    /// Information identifying the primary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_F5S52xXfEeOocOqSQt5Jbw")]
    [DisplayName("Primary Corporate Investor")]
    [IsoXmlTag("PmryCorpInvstr")]
    public Organisation4? PrimaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the secondary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_F5S53RXfEeOocOqSQt5Jbw")]
    [DisplayName("Secondary Corporate Investor")]
    [IsoXmlTag("ScndryCorpInvstr")]
    public Organisation4? SecondaryCorporateInvestor { get; init; }

    /// <summary>
    /// Information identifying the other corporate investors, eg, name and address.
    /// </summary>
    [IsoId("_F5S53xXfEeOocOqSQt5Jbw")]
    [DisplayName("Other Corporate Investor")]
    [IsoXmlTag("OthrCorpInvstr")]
    public Organisation4? OtherCorporateInvestor { get; init; }

    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_F5S54RXfEeOocOqSQt5Jbw")]
    [DisplayName("Transferor Account")]
    [IsoXmlTag("TrfrAcct")]
    public required Account15 TransferorAccount { get; init; }

    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_F5S54xXfEeOocOqSQt5Jbw")]
    [DisplayName("Nominee Account")]
    [IsoXmlTag("NmneeAcct")]
    public Account16? NomineeAccount { get; init; }

    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_F5S55RXfEeOocOqSQt5Jbw")]
    [DisplayName("Transferee")]
    [IsoXmlTag("Trfee")]
    public required PartyIdentification2Choice_ Transferee { get; init; }

    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_F5S55xXfEeOocOqSQt5Jbw")]
    [DisplayName("Product Transfer")]
    [IsoXmlTag("PdctTrf")]
    public required ISATransfer14 ProductTransfer { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_VYsdUBw9EeOIveEnnb_1-A")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_F5S56RXfEeOocOqSQt5Jbw")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since AccountHoldingInformationV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountHoldingInformationV04.
