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

namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.058.001.01 ISO standard message type.
/// Scope|The receiver of a StandingSettlementInstruction message sends the StandingSettlementInstructionStatusAdvice message to the instructing party (sender of the StandingSettlementInstruction message) to provide the status of a previously received StandingSettlementInstruction, StandingSettlementInstructionCancellation or StandingSettlementInstructionDeletion message.||Usage|The StandingSettlementInstructionStatusAdvice message is used to report one of the following statuses:|- a received status, or, |- an accepted status, or,|- a rejected status, or,|- a pending processing status, or,|- a proprietary status.
/// </summary>
[Description(
    @"Scope|The receiver of a StandingSettlementInstruction message sends the StandingSettlementInstructionStatusAdvice message to the instructing party (sender of the StandingSettlementInstruction message) to provide the status of a previously received StandingSettlementInstruction, StandingSettlementInstructionCancellation or StandingSettlementInstructionDeletion message.||Usage|The StandingSettlementInstructionStatusAdvice message is used to report one of the following statuses:|- a received status, or, |- an accepted status, or,|- a rejected status, or,|- a pending processing status, or,|- a proprietary status."
)]
[IsoId("_5gmxoPRnEeK8G5J12Bcx2g")]
[DisplayName("Standing Settlement Instruction Status Advice V01")]
public record StandingSettlementInstructionStatusAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.058.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StgSttlmInstrStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.058.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Date on which the SSI is effective.
    /// </summary>
    [IsoId("_QP7bYPXrEeKpFY1yaoww4A")]
    [DisplayName("Effective Date Details")]
    [IsoXmlTag("FctvDtDtls")]
    public EffectiveDate1? EffectiveDateDetails { get; init; }

    /// <summary>
    /// Unique and unambiguous master identification known to the sender (or its authorised agent) and receiver (or its authorised agent), below which the SSI will be lodged. This may be an account number or reference to a fund.|If no account or reference is available then “NONREF” must be specified.
    /// </summary>
    [IsoId("_QP7bYfXrEeKpFY1yaoww4A")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [MinLength(1)]
    public ValueList<AccountIdentification26> AccountIdentification { get; init; } = [];

    /// <summary>
    /// Identifies the market for the standing settlement instruction.
    /// </summary>
    [IsoId("_Va68wVK1EeOsJr32EK1NAQ")]
    [DisplayName("Market Identification")]
    [IsoXmlTag("MktId")]
    public required MarketIdentificationOrCashPurpose1Choice_ MarketIdentification { get; init; }

    /// <summary>
    /// Settlement information that helps to identify the standing settlement instruction, cancellation or deletion for which the status is sent.
    /// </summary>
    [IsoId("_jd-AwVK1EeOsJr32EK1NAQ")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required PartyOrCurrency1Choice_ SettlementDetails { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_z8NGwPm-EeKDvJTxb9tKVw")]
    [DisplayName("Related Message Reference")]
    [IsoXmlTag("RltdMsgRef")]
    public required Max35Text RelatedMessageReference { get; init; }

    /// <summary>
    /// Status of the standing settlement instruction, deletion or cancellation.
    /// </summary>
    [IsoId("__JwQcFhJEeOMYfRGLS0NbA")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required ProcessingStatus43Choice_ ProcessingStatus { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_1jvlQfXtEeKpFY1yaoww4A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
