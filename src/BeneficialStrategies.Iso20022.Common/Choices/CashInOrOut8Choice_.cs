// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of a payment instrument for the cash-in flow or cash-out flow.
    /// </summary>
    [KnownType(typeof(CashInOrOut8Choice.CashInPaymentInstrument))]
    [KnownType(typeof(CashInOrOut8Choice.CashOutPaymentInstrument))]
    [JsonDerivedType(typeof(CashInOrOut8Choice.CashInPaymentInstrument), nameof(CashInOrOut8Choice.CashInPaymentInstrument))]
    [JsonDerivedType(typeof(CashInOrOut8Choice.CashOutPaymentInstrument), nameof(CashInOrOut8Choice.CashOutPaymentInstrument))]
    [IsoId("ef3ddde2-6cf5-4c52-ad50-c9d85638d499")]
    [DisplayName("CashInOrOut8Choice")]
    public abstract record CashInOrOut8Choice_ { }
}
