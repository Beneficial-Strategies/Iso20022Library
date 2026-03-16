// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response to a batch management initiation message.
/// </summary>
[IsoId("_o8RFgYdOEeuBS50MFjViNw")]
[DisplayName("Batch Management Response")]
public record BatchManagementResponse2
{
    /// <summary>
    /// Environment of the batch management transaction.
    /// </summary>
    [IsoId("_pBgK0YdOEeuBS50MFjViNw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment33 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_pBgK04dOEeuBS50MFjViNw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; }

    /// <summary>
    /// Details about the batch management transaction.
    /// </summary>
    [IsoId("_pBgK1YdOEeuBS50MFjViNw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction151 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing.
    /// </summary>
    [IsoId("_pBgK14dOEeuBS50MFjViNw")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult13 ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_pBgK2YdOEeuBS50MFjViNw")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_pBgK24dOEeuBS50MFjViNw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
