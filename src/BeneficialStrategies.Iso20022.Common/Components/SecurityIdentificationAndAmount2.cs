// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security Identification And Amount2.
/// </summary>
[IsoId("_OJbUwYrZEe-RMan1tLkKgA")]
[DisplayName("Security Identification And Amount2")]
public record SecurityIdentificationAndAmount2
{
    /// <summary>
    /// Debt Issuer Type.
    /// </summary>
    [DisplayName("Debt Issuer Type")]
    [IsoXmlTag("DebtIssrTp")]
    public DebtIssuerType1Code? DebtIssuerType { get; init; }

    /// <summary>
    /// Financial Instrument Type.
    /// </summary>
    [DisplayName("Financial Instrument Type")]
    [IsoXmlTag("FinInstrmTp")]
    public required ProductType6Code FinancialInstrumentType { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoISINOct2015Identifier Identification { get; init; }

    /// <summary>
    /// Market Value.
    /// </summary>
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public required ActiveCurrencyAnd24Amount MarketValue { get; init; }
}
