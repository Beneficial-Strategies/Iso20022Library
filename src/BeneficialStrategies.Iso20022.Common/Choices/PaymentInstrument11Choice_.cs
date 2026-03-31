// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between types of payment instrument, ie, cheque, credit transfer or investment account.
    /// </summary>
    [KnownType(typeof(PaymentInstrument11Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument11Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument11Choice.BankersDraftDetails))]
    [KnownType(typeof(PaymentInstrument11Choice.CashAccountDetails))]
    [JsonDerivedType(
        typeof(PaymentInstrument11Choice.CreditTransferDetails),
        nameof(PaymentInstrument11Choice.CreditTransferDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument11Choice.ChequeDetails),
        nameof(PaymentInstrument11Choice.ChequeDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument11Choice.BankersDraftDetails),
        nameof(PaymentInstrument11Choice.BankersDraftDetails)
    )]
    [JsonDerivedType(
        typeof(PaymentInstrument11Choice.CashAccountDetails),
        nameof(PaymentInstrument11Choice.CashAccountDetails)
    )]
    [IsoId("_SBhw49p-Ed-ak6NoX_4Aeg_112681457")]
    [DisplayName("Payment Instrument 11 Choice")]
    public abstract record PaymentInstrument11Choice_ { }
}
