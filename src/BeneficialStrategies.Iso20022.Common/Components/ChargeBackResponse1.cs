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
[IsoId("_RVofAVZhEeen1vB4iz5SyA")]
[DisplayName("Charge Back Response")]
public record ChargeBackResponse1
{
    /// <summary>
    /// Environment of the chargeback.
    /// </summary>
    [IsoId("_Rh-48VZhEeen1vB4iz5SyA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment14 Environment { get; init; }

    /// <summary>
    /// Context of the chargeback transaction.
    /// </summary>
    [IsoId("_Rh-481ZhEeen1vB4iz5SyA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context9 Context { get; init; }

    /// <summary>
    /// Chargeback transaction details.
    /// </summary>
    [IsoId("_Rh-49VZhEeen1vB4iz5SyA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction97 Transaction { get; init; }

    /// <summary>
    /// Result of the chargeback verification provided in the chargeback status.
    /// </summary>
    [IsoId("_Rh-491ZhEeen1vB4iz5SyA")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult7 ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_YAr-UdXwEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_-fU7kaK4EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
