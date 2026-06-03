// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data elements of a system abort message.
/// </summary>
[IsoId("_DR-kYbYDEfCUZfsQO4rYeA")]
[DisplayName("System Abort9")]
public record SystemAbort9
{
    [IsoId("_DR-kYbYDEfCUZfsQO4rYeA-env")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    [IsoId("_DR-kYbYDEfCUZfsQO4rYeA-ctx")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required PaymentContext30 Context { get; init; }

    [IsoId("_DR-kYbYDEfCUZfsQO4rYeA-abt")]
    [DisplayName("System Abort")]
    [IsoXmlTag("SysAbrt")]
    public required AbortData7 SystemAbort { get; init; }

    [IsoId("_DR-kYbYDEfCUZfsQO4rYeA-sup")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
