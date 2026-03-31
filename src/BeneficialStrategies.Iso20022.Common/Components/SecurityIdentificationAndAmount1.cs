// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the current valuation of a security.
/// </summary>
[IsoId("_HfBSwK_7EeaE9YROwd69hA")]
[DisplayName("Security Identification And Amount")]
public record SecurityIdentificationAndAmount1
{
    /// <summary>
    /// ISIN of the outright investment.
    /// </summary>
    [IsoId("_RK0CoK_7EeaE9YROwd69hA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier Identification { get; init; }

    /// <summary>
    /// Value of the outright investment according to the CCP’s system of record.
    /// </summary>
    [IsoId("_ULeXQK_7EeaE9YROwd69hA")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public required ActiveCurrencyAnd24Amount MarketValue { get; init; }

    /// <summary>
    /// Type of a financial instrument: an equity, bond or other.
    /// </summary>
    [IsoId("_kn10ADXsEemdWfjs3tykFQ")]
    [DisplayName("Financial Instrument Type")]
    [IsoXmlTag("FinInstrmTp")]
    public required ProductType7Code FinancialInstrumentType { get; init; }
}
