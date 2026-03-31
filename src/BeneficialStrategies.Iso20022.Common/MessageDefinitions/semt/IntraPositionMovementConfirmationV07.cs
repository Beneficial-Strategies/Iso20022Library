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

namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.015.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a IntraPositionMovementConfirmation to an account owner to confirm the movement of securities within its holding from one sub-balance to another, for example, blocking of securities.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
///
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|An account servicer sends a IntraPositionMovementConfirmation to an account owner to confirm the movement of securities within its holding from one sub-balance to another, for example, blocking of securities. |The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header."
)]
[IsoId("_jtD9caN9EeeNVLC-L_hywg")]
[DisplayName("Intra Position Movement Confirmation V")]
public record IntraPositionMovementConfirmationV07 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.015.001.07";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraPosMvmntConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.015.001.07";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Additional parameters to the transaction.
    /// </summary>
    [IsoId("_jtD9c6N9EeeNVLC-L_hywg")]
    [DisplayName("Additional Parameters")]
    [IsoXmlTag("AddtlParams")]
    public AdditionalParameters21? AdditionalParameters { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_jtD9daN9EeeNVLC-L_hywg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification92Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_jtD9d6N9EeeNVLC-L_hywg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_jtD9eaN9EeeNVLC-L_hywg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat10Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_jtD9e6N9EeeNVLC-L_hywg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_jtD9faN9EeeNVLC-L_hywg")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes92? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Intra-position movement transaction details.
    /// </summary>
    [IsoId("_jtD9f6N9EeeNVLC-L_hywg")]
    [DisplayName("Intra Position Details")]
    [IsoXmlTag("IntraPosDtls")]
    public required IntraPositionDetails46 IntraPositionDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jtD9gaN9EeeNVLC-L_hywg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since IntraPositionMovementConfirmationV07Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IntraPositionMovementConfirmationV07.
