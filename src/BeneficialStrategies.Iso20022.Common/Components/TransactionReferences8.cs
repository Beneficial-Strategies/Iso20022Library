// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction References8.
/// </summary>
[IsoId("_24TmtzEyEe6g-ffJsqGiSA")]
[DisplayName("Transaction References8")]
public record TransactionReferences8
{
    /// <summary>
    /// Creditor Scheme Identification.
    /// </summary>
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification272? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// End To End Identification.
    /// </summary>
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    public required IsoMax35Text EndToEndIdentification { get; init; }

    /// <summary>
    /// Instruction Identification.
    /// </summary>
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public IsoMax35Text? InstructionIdentification { get; init; }

    /// <summary>
    /// Mandate Identification.
    /// </summary>
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <summary>
    /// Payment Information Identification.
    /// </summary>
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public IsoMax35Text? TransactionIdentification { get; init; }

    /// <summary>
    /// UETR.
    /// </summary>
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    public IsoUUIDv4Identifier? UETR { get; init; }
}
