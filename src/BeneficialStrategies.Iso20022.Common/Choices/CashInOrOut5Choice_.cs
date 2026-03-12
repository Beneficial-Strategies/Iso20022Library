// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of a payment instrument for the cash-in flow or cash-out flow.
    /// </summary>
    [KnownType(typeof(CashInOrOut5Choice.CashInPaymentInstrument))]
    [KnownType(typeof(CashInOrOut5Choice.CashOutPaymentInstrument))]
    [JsonDerivedType(typeof(CashInOrOut5Choice.CashInPaymentInstrument),nameof(CashInOrOut5Choice.CashInPaymentInstrument))]
    [JsonDerivedType(typeof(CashInOrOut5Choice.CashOutPaymentInstrument),nameof(CashInOrOut5Choice.CashOutPaymentInstrument))]
    [IsoId("_SBq60tp-Ed-ak6NoX_4Aeg_1170439952")]
    [DisplayName("Cash In Or Out 5 Choice")]
    public abstract partial record CashInOrOut5Choice_
    {
    }
}
