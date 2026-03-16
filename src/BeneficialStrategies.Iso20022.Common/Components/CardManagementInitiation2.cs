// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the card management initiation message.
/// </summary>
[IsoId("_Mirn0YEOEeu6D49Gi-ZPwQ")]
[DisplayName("Card Management Initiation")]
public record CardManagementInitiation2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_MnTCEYEOEeu6D49Gi-ZPwQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment18 Environment { get; init; }

    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_MnTCE4EOEeu6D49Gi-ZPwQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context11 Context { get; init; }

    /// <summary>
    /// Card management initiation transaction.
    /// </summary>
    [IsoId("_MnTCFYEOEeu6D49Gi-ZPwQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction152 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_MnTCF4EOEeu6D49Gi-ZPwQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult16? ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_MnTCGYEOEeu6D49Gi-ZPwQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_MnTCG4EOEeu6D49Gi-ZPwQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_MnTCHYEOEeu6D49Gi-ZPwQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
