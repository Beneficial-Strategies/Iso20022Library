// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the non financial request.
/// </summary>
[IsoId("_7jU_AbX0EfCUZfsQO4rYeA")]
[DisplayName("Non Financial Request Component6")]
public record NonFinancialRequestComponent6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_7kZWBbX0EfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_7kZWC7X0EfCUZfsQO4rYeA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required PaymentContext30 Context { get; init; }

    /// <summary>
    /// Aim of the non financial request.
    /// </summary>
    [IsoId("_7kZWEbX0EfCUZfsQO4rYeA")]
    [DisplayName("Non Financial Request Content")]
    [IsoXmlTag("NonFinReqCntt")]
    public required NonFinancialRequestContentComponent6 NonFinancialRequestContent { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_7kZWF7X0EfCUZfsQO4rYeA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
