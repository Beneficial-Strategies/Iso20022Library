// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non Financial Response Component5.
/// </summary>
[IsoId("_sT6jgaEsEe-MRKYsaX6JDg")]
[DisplayName("Non Financial Response Component5")]
public record NonFinancialResponseComponent5
{
    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment81 Environment { get; init; }

    /// <summary>
    /// Response.
    /// </summary>
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Response Content.
    /// </summary>
    [DisplayName("Response Content")]
    [IsoXmlTag("RspnCntt")]
    public ValueList<NonFinancialResponseContentComponent5> ResponseContent { get; init; } = [];

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
