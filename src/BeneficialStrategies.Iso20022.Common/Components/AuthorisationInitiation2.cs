// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the authorisation initiation message.
/// </summary>
[IsoId("_KnK6MYEKEeu6D49Gi-ZPwQ")]
[DisplayName("Authorisation Initiation")]
public record AuthorisationInitiation2
{
    /// <summary>
    /// Contains or describes the information pertaining to the actors interacting with the transaction.
    /// </summary>
    [IsoId("_KsgGIYEKEeu6D49Gi-ZPwQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment17 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_KsgGI4EKEeu6D49Gi-ZPwQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context10 Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_KsgGJYEKEeu6D49Gi-ZPwQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction142 Transaction { get; init; }

    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages.
    /// </summary>
    [IsoId("_KsgGJ4EKEeu6D49Gi-ZPwQ")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public AddendumData3? AddendumData { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_KsgGKYEKEeu6D49Gi-ZPwQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult16? ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_KsgGK4EKEeu6D49Gi-ZPwQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_KsgGLYEKEeu6D49Gi-ZPwQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_KsgGL4EKEeu6D49Gi-ZPwQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
