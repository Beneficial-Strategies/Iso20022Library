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

namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.050.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope and Usage
/// The MarketClaimCreation message is sent by an account servicer to an account holder to advise of the creation of a market claim transaction on a securities account, for example by a CSD that has automatically generated market claims on a mandatory distribution type of corporate action event. The MarketClaimCreation message may also be sent by an account holder to its account holder, to instruct settlement of a bilaterally agreed (as opposed to centrally generated) market claim for a corporate action event.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Description(
    @"Scope and Usage|The MarketClaimCreation message is sent by an account servicer to an account holder to advise of the creation of a market claim transaction on a securities account, for example by a CSD that has automatically generated market claims on a mandatory distribution type of corporate action event. The MarketClaimCreation message may also be sent by an account holder to its account holder, to instruct settlement of a bilaterally agreed (as opposed to centrally generated) market claim for a corporate action event.|This message definition is intended for use with the Business Application Header (BAH)."
)]
[IsoId("_PT1lANsDEeqmdMJWobugpw")]
[DisplayName("Market Claim Creation V")]
public record MarketClaimCreationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.050.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MktClmCre";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.050.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_0BRJstsYEeqmdMJWobugpw")]
    [DisplayName("Transaction Reference")]
    [IsoXmlTag("TxRef")]
    public required References25 TransactionReference { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_BA078dsPEeqmdMJWobugpw")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation157 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Information about the related settlement instruction for which the market claim has been created.
    /// </summary>
    [IsoId("_SOQsMC2sEeuVt5XRmyhHiA")]
    [DisplayName("Related Settlement Instruction Details")]
    [IsoXmlTag("RltdSttlmInstrDtls")]
    public required RelatedSettlementInstruction1 RelatedSettlementInstructionDetails { get; init; }

    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_GfnaodvlEeqmdMJWobugpw")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountIdentification46 AccountDetails { get; init; }

    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_uBOHsC2qEeuVt5XRmyhHiA")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction59? CorporateActionDetails { get; init; }

    /// <summary>
    /// Type of market claim creation requested.
    /// </summary>
    [IsoId("_-UDPQC2lEeuVt5XRmyhHiA")]
    [DisplayName("Market Claim Type")]
    [IsoXmlTag("MktClmTp")]
    public required MarketClaimType1Code MarketClaimType { get; init; }

    /// <summary>
    /// Detailed information about the related corporate action option and related movements to which the market claim is linked.
    /// </summary>
    [IsoId("_Lxm88NsaEeqmdMJWobugpw")]
    [DisplayName("Market Claim Details")]
    [IsoXmlTag("MktClmDtls")]
    public required CorporateActionOption185 MarketClaimDetails { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_otNmFNsZEeqmdMJWobugpw")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties75? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_7yIv1NvaEeqmdMJWobugpw")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties75? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_hhuxcdsGEeqmdMJWobugpw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MarketClaimCreationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarketClaimCreationV01.
