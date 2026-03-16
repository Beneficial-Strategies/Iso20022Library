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
[IsoId("_VYZmHNp-Ed-ak6NoX_4Aeg_696692429")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction17
{
    /// <summary>
    /// Amount of money to be transferred between the debtor and creditor before bank transaction charges.
    /// </summary>
    [IsoId("_VYZmHdp-Ed-ak6NoX_4Aeg_696692431")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Date on which the first agent expects the cash to be available to the final agent.
    /// </summary>
    [IsoId("_VYjXENp-Ed-ak6NoX_4Aeg_696692464")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Choice between types of payment instrument, ie, cheque, credit transfer, direct debit, investment account or payment card.
    /// </summary>
    [IsoId("_VYjXEdp-Ed-ak6NoX_4Aeg_696692550")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public PaymentInstrument9Choice_? PaymentInstrument { get; init; }
}
