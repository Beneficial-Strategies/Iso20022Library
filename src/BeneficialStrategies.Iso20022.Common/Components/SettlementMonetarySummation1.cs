// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a collection of monetary totals for this settlement.
/// </summary>
[IsoId("_S-ZInQEcEeCQm6a_G2yO_w_-2077201907")]
[DisplayName("Settlement Monetary Summation")]
public record SettlementMonetarySummation1
{
    /// <summary>
    /// Monetary value of the line amount total being reported for this settlement.
    /// </summary>
    [IsoId("_S-ZIngEcEeCQm6a_G2yO_w_-1438063154")]
    [DisplayName("Line Total Amount")]
    [IsoXmlTag("LineTtlAmt")]
    public CurrencyAndAmount? LineTotalAmount { get; init; }

    /// <summary>
    /// Monetary value of the allowance total being reported for this settlement.
    /// </summary>
    [IsoId("_S-i5kAEcEeCQm6a_G2yO_w_-1976793835")]
    [DisplayName("Allowance Total Amount")]
    [IsoXmlTag("AllwncTtlAmt")]
    public CurrencyAndAmount? AllowanceTotalAmount { get; init; }

    /// <summary>
    /// Monetary value of the total discount being reported for this settlement.
    /// </summary>
    [IsoId("_S-i5kQEcEeCQm6a_G2yO_w_427851198")]
    [DisplayName("Total Discount Amount")]
    [IsoXmlTag("TtlDscntAmt")]
    public CurrencyAndAmount? TotalDiscountAmount { get; init; }

    /// <summary>
    /// Monetary value of the charge amount total being reported for this settlement.
    /// </summary>
    [IsoId("_S-i5kgEcEeCQm6a_G2yO_w_1451423672")]
    [DisplayName("Charge Total Amount")]
    [IsoXmlTag("ChrgTtlAmt")]
    public CurrencyAndAmount? ChargeTotalAmount { get; init; }

    /// <summary>
    /// Monetary value of the total prepaid amount being reported for this settlement.
    /// </summary>
    [IsoId("_S-i5kwEcEeCQm6a_G2yO_w_1675528526")]
    [DisplayName("Total Prepaid Amount")]
    [IsoXmlTag("TtlPrepdAmt")]
    public CurrencyAndAmount? TotalPrepaidAmount { get; init; }

    /// <summary>
    /// Monetary value of the total of all tax basis amounts being reported for this settlement.
    /// </summary>
    [IsoId("_S-i5lAEcEeCQm6a_G2yO_w_-1622081227")]
    [DisplayName("Tax Total Amount")]
    [IsoXmlTag("TaxTtlAmt")]
    public CurrencyAndAmount? TaxTotalAmount { get; init; }

    /// <summary>
    /// Monetary value of the total of all tax basis amounts being reported for this settlement.
    /// </summary>
    [IsoId("_S-i5lQEcEeCQm6a_G2yO_w_1868239250")]
    [DisplayName("Tax Basis Amount")]
    [IsoXmlTag("TaxBsisAmt")]
    public CurrencyAndAmount? TaxBasisAmount { get; init; }

    /// <summary>
    /// Monetary value of a rounding amount being applied and reported for this settlement.
    /// </summary>
    [IsoId("_S-i5lgEcEeCQm6a_G2yO_w_-575396775")]
    [DisplayName("Rounding Amount")]
    [IsoXmlTag("RndgAmt")]
    public CurrencyAndAmount? RoundingAmount { get; init; }

    /// <summary>
    /// Monetary value of the grand total being reported for this settlement, to include addition and subtraction of individual summation amounts.
    /// </summary>
    [IsoId("_S-i5lwEcEeCQm6a_G2yO_w_-444855441")]
    [DisplayName("Grand Total Amount")]
    [IsoXmlTag("GrdTtlAmt")]
    public CurrencyAndAmount? GrandTotalAmount { get; init; }

    /// <summary>
    /// Monetary value of an amount being reported as information for this settlement.
    /// </summary>
    [IsoId("_S-i5mAEcEeCQm6a_G2yO_w_310144010")]
    [DisplayName("Information Amount")]
    [IsoXmlTag("InfAmt")]
    public CurrencyAndAmount? InformationAmount { get; init; }
}
