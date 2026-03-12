// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of a payment instrument for the cash-in flow or cash-out flow.
    /// </summary>
    [KnownType(typeof(CashInOrOut7Choice.CashInPaymentInstrument))]
    [KnownType(typeof(CashInOrOut7Choice.CashOutPaymentInstrument))]
    [JsonDerivedType(typeof(CashInOrOut7Choice.CashInPaymentInstrument),nameof(CashInOrOut7Choice.CashInPaymentInstrument))]
    [JsonDerivedType(typeof(CashInOrOut7Choice.CashOutPaymentInstrument),nameof(CashInOrOut7Choice.CashOutPaymentInstrument))]
    [IsoId("_3a23dTbsEead9bDRE_1DAQ")]
    [DisplayName("Cash In Or Out 7 Choice")]
    public abstract partial record CashInOrOut7Choice_
    {
    }
}
