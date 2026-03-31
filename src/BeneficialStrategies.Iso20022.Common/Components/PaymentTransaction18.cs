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
[IsoId("_VYjXEtp-Ed-ak6NoX_4Aeg_1604186994")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction18
{
    /// <summary>
    /// Amount of money to be transferred between the debtor and creditor before bank transaction charges.
    /// </summary>
    [IsoId("_VYjXE9p-Ed-ak6NoX_4Aeg_1604187037")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Date on which the first agent expects the cash to be available to the final agent.
    /// </summary>
    [IsoId("_VYjXFNp-Ed-ak6NoX_4Aeg_1604187133")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Choice between types of payment instrument, ie, cheque, credit transfer or investment account.
    /// </summary>
    [IsoId("_VYjXFdp-Ed-ak6NoX_4Aeg_-1396931773")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public required PaymentInstrument7Choice_ PaymentInstrument { get; init; }
}
