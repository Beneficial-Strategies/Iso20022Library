// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade settlement monetary summation specified for this supply chain trade settlement.
/// </summary>
[IsoId("_SucoHAEcEeCQm6a_G2yO_w_1990739481")]
[DisplayName("Line Item Monetary Summation")]
public record LineItemMonetarySummation1
{
    /// <summary>
    /// Monetary value of the line amount total being reported in this trade settlement monetary summation.
    /// </summary>
    [IsoId("_SucoHQEcEeCQm6a_G2yO_w_203579898")]
    [DisplayName("Line Total Amount")]
    [IsoXmlTag("LineTtlAmt")]
    public CurrencyAndAmount? LineTotalAmount { get; init; }

    /// <summary>
    /// Monetary value of the total of all allowance amounts being reported in this line item monetary summation.
    /// </summary>
    [IsoId("_SucoHgEcEeCQm6a_G2yO_w_-156792154")]
    [DisplayName("Allowance Total Amount")]
    [IsoXmlTag("AllwncTtlAmt")]
    public CurrencyAndAmount? AllowanceTotalAmount { get; init; }

    /// <summary>
    /// Monetary value of the total of all charge amounts being reported in this line item monetary summation.
    /// </summary>
    [IsoId("_SucoHwEcEeCQm6a_G2yO_w_197422641")]
    [DisplayName("Charge Total Amount")]
    [IsoXmlTag("ChrgTtlAmt")]
    public CurrencyAndAmount? ChargeTotalAmount { get; init; }

    /// <summary>
    /// Monetary value of the total of all tax amounts being reported in this line item monetary summation.
    /// </summary>
    [IsoId("_SucoIAEcEeCQm6a_G2yO_w_1261442565")]
    [DisplayName("Tax Total Amount")]
    [IsoXmlTag("TaxTtlAmt")]
    public CurrencyAndAmount? TaxTotalAmount { get; init; }

    /// <summary>
    /// Monetary value of the total of all tax basis amounts being reported in this line item monetary summation.
    /// </summary>
    [IsoId("_SumZEAEcEeCQm6a_G2yO_w_-860871799")]
    [DisplayName("Tax Basis Total Amount")]
    [IsoXmlTag("TaxBsisTtlAmt")]
    public CurrencyAndAmount? TaxBasisTotalAmount { get; init; }

    /// <summary>
    /// Monetary value of an amount being reported for information in this line item monetary summation.
    /// </summary>
    [IsoId("_SumZEQEcEeCQm6a_G2yO_w_1109201490")]
    [DisplayName("Information Amount")]
    [IsoXmlTag("InfAmt")]
    public CurrencyAndAmount? InformationAmount { get; init; }
}
