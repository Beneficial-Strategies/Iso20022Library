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
/// This record is an implementation of the seev.063.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_6g6F8LbeEe-NMoTZ6Byg6A")]
[DisplayName("Buyer Protection Instruction Cancellation Request Status Advice V01")]
public record BuyerProtectionInstructionCancellationRequestStatusAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.063.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BuyrPrtcnInstrCxlReqStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.063.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public SecuritiesAccountIdentification1Choice_? AccountIdentification { get; init; }

    /// <summary>
    /// Buyer Protection Instruction Identification.
    /// </summary>
    [DisplayName("Buyer Protection Instruction Identification")]
    [IsoXmlTag("BuyrPrtcnInstrId")]
    public required DocumentIdentification57 BuyerProtectionInstructionIdentification { get; init; }

    /// <summary>
    /// Corporate Action Election.
    /// </summary>
    [DisplayName("Corporate Action Election")]
    [IsoXmlTag("CorpActnElctn")]
    public CorporateActionElection4? CorporateActionElection { get; init; }

    /// <summary>
    /// Corporate Action General Information.
    /// </summary>
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation195 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Instruction Cancellation Request Status.
    /// </summary>
    [DisplayName("Instruction Cancellation Request Status")]
    [IsoXmlTag("InstrCxlReqSts")]
    public ValueList<InstructionCancellationRequestStatus20Choice_> InstructionCancellationRequestStatus { get; init; } = [];

    /// <summary>
    /// Processor Transaction Identification.
    /// </summary>
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Related Settlement Instruction.
    /// </summary>
    [DisplayName("Related Settlement Instruction")]
    [IsoXmlTag("RltdSttlmInstr")]
    public RelatedSettlementInstruction4? RelatedSettlementInstruction { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}

// Since BuyerProtectionInstructionCancellationRequestStatusAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BuyerProtectionInstructionCancellationRequestStatusAdviceV01.
