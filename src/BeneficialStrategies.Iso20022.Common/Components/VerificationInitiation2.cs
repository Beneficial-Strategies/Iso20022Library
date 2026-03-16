// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the verification initiation message.
/// </summary>
[IsoId("_9_sxcYELEeu6D49Gi-ZPwQ")]
[DisplayName("Verification Initiation")]
public record VerificationInitiation2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_-FFnwYELEeu6D49Gi-ZPwQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment31 Environment { get; init; }

    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_-FFnw4ELEeu6D49Gi-ZPwQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context11 Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_-FFnxYELEeu6D49Gi-ZPwQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction146 Transaction { get; init; }

    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages
    /// </summary>
    [IsoId("_a6DEwCX7Eeym0KcvJF9aDQ")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public AddendumData5? AddendumData { get; init; }

    /// <summary>
    /// Outcome of the processing of the verification.
    /// </summary>
    [IsoId("_-FFnx4ELEeu6D49Gi-ZPwQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult12? ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_-FFnyYELEeu6D49Gi-ZPwQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_-FFny4ELEeu6D49Gi-ZPwQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_-FFnzYELEeu6D49Gi-ZPwQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
