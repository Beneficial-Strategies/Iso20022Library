// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
[IsoId("_VY2SANp-Ed-ak6NoX_4Aeg_1640076187")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction14
{
    /// <summary>
    /// Amount of money to be transferred between the debtor and creditor before bank transaction charges.
    /// </summary>
    [IsoId("_VY2SAdp-Ed-ak6NoX_4Aeg_1640076247")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Date on which the first agent expects the cash to be available to the final agent.
    /// </summary>
    [IsoId("_VY2SAtp-Ed-ak6NoX_4Aeg_1640076264")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Choice between cash-in or cash-out.
    /// </summary>
    [IsoId("_VY2SA9p-Ed-ak6NoX_4Aeg_1640076311")]
    [DisplayName("Cash In Or Out Choice")]
    [IsoXmlTag("CshInOrOutChc")]
    public CashInOrOut3Choice_? CashInOrOutChoice { get; init; }
}
