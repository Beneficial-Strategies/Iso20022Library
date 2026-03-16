// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card used to represent a financial account for the purpose of payment settlement.
/// </summary>
[IsoId("_Sp--1gEcEeCQm6a_G2yO_w_-1939966628")]
[DisplayName("Financial Card")]
public record FinancialCard1
{
    /// <summary>
    /// Monetary value of the credit limit for this financial card.
    /// </summary>
    [IsoId("_Sp--1wEcEeCQm6a_G2yO_w_-447801115")]
    [DisplayName("Credit Limit Amount")]
    [IsoXmlTag("CdtLmtAmt")]
    public CurrencyAndAmount? CreditLimitAmount { get; init; }

    /// <summary>
    /// Monetary value of the credit available for this financial card.
    /// </summary>
    [IsoId("_Sp--2AEcEeCQm6a_G2yO_w_-496515812")]
    [DisplayName("Credit Available Amount")]
    [IsoXmlTag("CdtAvlblAmt")]
    public CurrencyAndAmount? CreditAvailableAmount { get; init; }

    /// <summary>
    /// Interest rate expressed as a percentage for this financial card.
    /// </summary>
    [IsoId("_Sp--2QEcEeCQm6a_G2yO_w_1183955283")]
    [DisplayName("Interest Rate Percent")]
    [IsoXmlTag("IntrstRatePct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InterestRatePercent { get; init; }
}
