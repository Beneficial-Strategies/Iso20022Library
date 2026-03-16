// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to network management services.
/// </summary>
[IsoId("_9m_bMYv7EeumSPwlS1PkxQ")]
[DisplayName("Network Management Initiation")]
public record NetworkManagementInitiation2
{
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_9sMEQYv7EeumSPwlS1PkxQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; }

    /// <summary>
    /// Details of an exchange or interaction between parties to perform a specific function.
    /// </summary>
    [IsoId("_9sMEQ4v7EeumSPwlS1PkxQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction134 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation
    /// </summary>
    [IsoId("_9sMERYv7EeumSPwlS1PkxQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult16? ProcessingResult { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_9sMER4v7EeumSPwlS1PkxQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
