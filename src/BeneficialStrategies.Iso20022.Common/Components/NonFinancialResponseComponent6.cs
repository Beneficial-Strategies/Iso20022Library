// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to a non financial request.
/// </summary>
[IsoId("_au8sgbYAEfCUZfsQO4rYeA")]
[DisplayName("Non Financial Response Component6")]
public record NonFinancialResponseComponent6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_av2EZbYAEfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    /// <summary>
    /// Response of the non financial request.
    /// </summary>
    [IsoId("_av2Ea7YAEfCUZfsQO4rYeA")]
    [DisplayName("Response Content")]
    [IsoXmlTag("RspnCntt")]
    [MinLength(1)]
    public ValueList<NonFinancialResponseContentComponent6> ResponseContent { get; init; } = [];

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_av2EcbYAEfCUZfsQO4rYeA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_av2Ed7YAEfCUZfsQO4rYeA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
