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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.029.001.13 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_R3S73TEZEe6kQ-WGAhcVPQ")]
[DisplayName("Resolution Of Investigation V13")]
public record ResolutionOfInvestigationV13 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.029.001.13";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RsltnOfInvstgtn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.029.001.13";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Assignment.
    /// </summary>
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment6 Assignment { get; init; }

    /// <summary>
    /// Cancellation Details.
    /// </summary>
    [DisplayName("Cancellation Details")]
    [IsoXmlTag("CxlDtls")]
    public ValueList<UnderlyingTransaction32> CancellationDetails { get; init; } = [];

    /// <summary>
    /// Claim Non Receipt Details.
    /// </summary>
    [DisplayName("Claim Non Receipt Details")]
    [IsoXmlTag("ClmNonRctDtls")]
    public ClaimNonReceipt3Choice_? ClaimNonReceiptDetails { get; init; }

    /// <summary>
    /// Correction Transaction.
    /// </summary>
    [DisplayName("Correction Transaction")]
    [IsoXmlTag("CrrctnTx")]
    public CorrectiveTransaction5Choice_? CorrectionTransaction { get; init; }

    /// <summary>
    /// Modification Details.
    /// </summary>
    [DisplayName("Modification Details")]
    [IsoXmlTag("ModDtls")]
    public PaymentTransaction157? ModificationDetails { get; init; }

    /// <summary>
    /// Resolution Related Information.
    /// </summary>
    [DisplayName("Resolution Related Information")]
    [IsoXmlTag("RsltnRltdInf")]
    public ResolutionData5? ResolutionRelatedInformation { get; init; }

    /// <summary>
    /// Resolved Case.
    /// </summary>
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case6? ResolvedCase { get; init; }

    /// <summary>
    /// Statement Details.
    /// </summary>
    [DisplayName("Statement Details")]
    [IsoXmlTag("StmtDtls")]
    public StatementResolutionEntry5? StatementDetails { get; init; }

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required InvestigationStatus6Choice_ Status { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}

// Since ResolutionOfInvestigationV13Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ResolutionOfInvestigationV13.
