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
/// This record is an implementation of the seev.021.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to an issuer (or its agent) to confirm the settlement of resource movements.
/// Usage
/// This message is used to confirm the settlement of the movements resulting from an:
/// - Agent Corporate Action Movement Instruction message. It confirms the settlement of the exercised resources and/or proceeds movements in which case the building block Agent Corporate Action Movement Instruction Identification must be present. An Agent Corporate Action Movement Instruction message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.
/// - Agent Corporate Action Global Distribution Status Advice authorising the global distribution. It confirms the settlement of the exercised resources and/or proceeds movements. The building block Agent Corporate Action Global Distribution Status Advice Identification must be present. An Agent Corporate Action Global Distribution Status Advice message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.
/// - Agent Corporate Action Election Status Advice that rejects an election advice. It confirms the return of the exercised resources. The building block Agent Corporate Action Election Status Advice Identification must be present. An Agent Corporate Action Election Status Advice message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.
/// - Agent Corporate Action Election Status Advice where an election cancellation request has been accepted. It confirms the return of the exercised resources. The building block Agent Corporate Action Election Status Advice Identification must be present. An Agent Corporate Action Election Status Advice message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.
/// </summary>
[Description(
    @"Scope|This message is sent by a CSD to an issuer (or its agent) to confirm the settlement of resource movements.|Usage|This message is used to confirm the settlement of the movements resulting from an:|- Agent Corporate Action Movement Instruction message. It confirms the settlement of the exercised resources and/or proceeds movements in which case the building block Agent Corporate Action Movement Instruction Identification must be present. An Agent Corporate Action Movement Instruction message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.|- Agent Corporate Action Global Distribution Status Advice authorising the global distribution. It confirms the settlement of the exercised resources and/or proceeds movements. The building block Agent Corporate Action Global Distribution Status Advice Identification must be present. An Agent Corporate Action Global Distribution Status Advice message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.|- Agent Corporate Action Election Status Advice that rejects an election advice. It confirms the return of the exercised resources. The building block Agent Corporate Action Election Status Advice Identification must be present. An Agent Corporate Action Election Status Advice message may be responded to by more than one Agent Corporate Action Movement Confirmation messages.|- Agent Corporate Action Election Status Advice where an election cancellation request has been accepted. It confirms the return of the exercised resources. The building block Agent Corporate Action Election Status Advice Identification must be present. An Agent Corporate Action Election Status Advice message may be responded to by more than one Agent Corporate Action Movement Confirmation messages."
)]
[IsoId("_TOf2vdEwEd-BzquC8wXy7w_550595772")]
[DisplayName("Agent CA Movement Confirmation V")]
public record AgentCAMovementConfirmationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.021.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAMvmntConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.021.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the confirmation.
    /// </summary>
    [IsoId("_TOpAoNEwEd-BzquC8wXy7w_2121112833")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; }

    /// <summary>
    /// Identification of the Agent CA Movement Instruction that triggered the movement(s).
    /// </summary>
    [IsoId("_TOpAodEwEd-BzquC8wXy7w_2124804747")]
    [DisplayName("Agent CA Movement Instruction Identification")]
    [IsoXmlTag("AgtCAMvmntInstrId")]
    public required DocumentIdentification8 AgentCAMovementInstructionIdentification { get; init; }

    /// <summary>
    /// Identification of the Agent CA Election Status Advice that triggered the movement(s).
    /// </summary>
    [IsoId("_TOpAotEwEd-BzquC8wXy7w_-1143801782")]
    [DisplayName("Agent CA Election Status Advice Identification")]
    [IsoXmlTag("AgtCAElctnStsAdvcId")]
    public required DocumentIdentification8 AgentCAElectionStatusAdviceIdentification { get; init; }

    /// <summary>
    /// Identification of the Agent CA Global Distribution Status Advice that triggered the movement(s).
    /// </summary>
    [IsoId("_TOpAo9EwEd-BzquC8wXy7w_1161636580")]
    [DisplayName("Agent CA Global Distribution Status Advice Identification")]
    [IsoXmlTag("AgtCAGblDstrbtnStsAdvcId")]
    public required DocumentIdentification8 AgentCAGlobalDistributionStatusAdviceIdentification { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TOpApNEwEd-BzquC8wXy7w_-279320255")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Information about the securities movements.
    /// </summary>
    [IsoId("_TOpApdEwEd-BzquC8wXy7w_1725377056")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public CorporateActionSecuritiesMovement1? SecuritiesMovementDetails { get; init; }

    /// <summary>
    /// Information about the cash movement.
    /// </summary>
    [IsoId("_TQR_YNEwEd-BzquC8wXy7w_-1609125049")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public CashMovement3? CashMovementDetails { get; init; }
}

// Since AgentCAMovementConfirmationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAMovementConfirmationV01.
