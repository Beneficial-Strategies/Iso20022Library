// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of a payment instrument for the cash-in flow or cash-out flow.
    /// </summary>
    [KnownType(typeof(CashInOrOut3Choice.CashInPaymentInstrument))]
    [KnownType(typeof(CashInOrOut3Choice.CashOutPaymentInstrument))]
    [JsonDerivedType(
        typeof(CashInOrOut3Choice.CashInPaymentInstrument),
        nameof(CashInOrOut3Choice.CashInPaymentInstrument)
    )]
    [JsonDerivedType(
        typeof(CashInOrOut3Choice.CashOutPaymentInstrument),
        nameof(CashInOrOut3Choice.CashOutPaymentInstrument)
    )]
    [IsoId("_VKGEX9p-Ed-ak6NoX_4Aeg_2056585648")]
    [DisplayName("Cash In Or Out 3 Choice")]
    public abstract record CashInOrOut3Choice_ { }
}
