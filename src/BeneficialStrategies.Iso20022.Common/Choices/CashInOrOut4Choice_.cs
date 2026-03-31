// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of a payment instrument for the cash-in flow or cash-out flow.
    /// </summary>
    [KnownType(typeof(CashInOrOut4Choice.CashInPaymentInstrument))]
    [KnownType(typeof(CashInOrOut4Choice.CashOutPaymentInstrument))]
    [JsonDerivedType(
        typeof(CashInOrOut4Choice.CashInPaymentInstrument),
        nameof(CashInOrOut4Choice.CashInPaymentInstrument)
    )]
    [JsonDerivedType(
        typeof(CashInOrOut4Choice.CashOutPaymentInstrument),
        nameof(CashInOrOut4Choice.CashOutPaymentInstrument)
    )]
    [IsoId("_VKP1Utp-Ed-ak6NoX_4Aeg_-1582566074")]
    [DisplayName("Cash In Or Out 4 Choice")]
    public abstract record CashInOrOut4Choice_ { }
}
