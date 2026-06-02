// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Disposition of previously submitted fraud report message.
/// </summary>
[IsoId("_gRLGcRNTEfC1ZfCQz0xB3g")]
[DisplayName("Fraud Disposition Status3")]
public record FraudDispositionStatus3
{
    /// <summary>
    /// Indicates the action taken as a disposition of the previously fraud report message.
    /// </summary>
    [IsoId("_gZIIkRNTEfC1ZfCQz0xB3g")]
    [DisplayName("Action Taken")]
    [IsoXmlTag("ActnTaken")]
    public required ActionTaken2Code ActionTaken { get; init; }

    /// <summary>
    /// Contains errors found in the submitted fraud report message.
    /// </summary>
    [IsoId("_gZIIlRNTEfC1ZfCQz0xB3g")]
    [DisplayName("Error Data")]
    [IsoXmlTag("ErrData")]
    public SimpleValueList<IsoMax256Text> ErrorData { get; init; } = [];

    /// <summary>
    /// Contains warnings found in the submitted fraud report message.
    /// </summary>
    [IsoId("_gZIIlxNTEfC1ZfCQz0xB3g")]
    [DisplayName("Warning Data")]
    [IsoXmlTag("WrngData")]
    public SimpleValueList<IsoMax256Text> WarningData { get; init; } = [];
}
