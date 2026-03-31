// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of a payment instrument for the cash-in flow or cash-out flow.
    /// </summary>
    [KnownType(typeof(CashInOrOut6Choice.CashInPaymentInstrument))]
    [KnownType(typeof(CashInOrOut6Choice.CashOutPaymentInstrument))]
    [JsonDerivedType(
        typeof(CashInOrOut6Choice.CashInPaymentInstrument),
        nameof(CashInOrOut6Choice.CashInPaymentInstrument)
    )]
    [JsonDerivedType(
        typeof(CashInOrOut6Choice.CashOutPaymentInstrument),
        nameof(CashInOrOut6Choice.CashOutPaymentInstrument)
    )]
    [IsoId("_SBhw6Np-Ed-ak6NoX_4Aeg_885994005")]
    [DisplayName("Cash In Or Out 6 Choice")]
    public abstract record CashInOrOut6Choice_ { }
}
