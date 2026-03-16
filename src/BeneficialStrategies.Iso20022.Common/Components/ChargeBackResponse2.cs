// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the chargeback response transaction.
/// </summary>
[IsoId("_tWE3AIdREeuBS50MFjViNw")]
[DisplayName("Charge Back Response")]
public record ChargeBackResponse2
{
    /// <summary>
    /// Environment of the chargeback.
    /// </summary>
    [IsoId("_ta00IYdREeuBS50MFjViNw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment29 Environment { get; init; }

    /// <summary>
    /// Context of the chargeback transaction.
    /// </summary>
    [IsoId("_ta00I4dREeuBS50MFjViNw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context16 Context { get; init; }

    /// <summary>
    /// Chargeback transaction details.
    /// </summary>
    [IsoId("_ta00JYdREeuBS50MFjViNw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction154 Transaction { get; init; }

    /// <summary>
    /// Result of the chargeback verification provided in the chargeback status.
    /// </summary>
    [IsoId("_ta00J4dREeuBS50MFjViNw")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult15 ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_ta00KYdREeuBS50MFjViNw")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_ta00K4dREeuBS50MFjViNw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
