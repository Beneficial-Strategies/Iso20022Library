// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between types of payment instrument, that is, cheque, credit transfer, direct debit, investment account or payment card.
    /// </summary>
    [KnownType(typeof(PaymentInstrument20Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument20Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument20Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument20Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument20Choice.BankersDraftDetails))]
    [KnownType(typeof(PaymentInstrument20Choice.CashAccountDetails))]
    [JsonDerivedType(typeof(PaymentInstrument20Choice.PaymentCardDetails),nameof(PaymentInstrument20Choice.PaymentCardDetails))]
    [JsonDerivedType(typeof(PaymentInstrument20Choice.CreditTransferDetails),nameof(PaymentInstrument20Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument20Choice.DirectDebitDetails),nameof(PaymentInstrument20Choice.DirectDebitDetails))]
    [JsonDerivedType(typeof(PaymentInstrument20Choice.ChequeDetails),nameof(PaymentInstrument20Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument20Choice.BankersDraftDetails),nameof(PaymentInstrument20Choice.BankersDraftDetails))]
    [JsonDerivedType(typeof(PaymentInstrument20Choice.CashAccountDetails),nameof(PaymentInstrument20Choice.CashAccountDetails))]
    [IsoId("_wFdXNzbsEead9bDRE_1DAQ")]
    [DisplayName("Payment Instrument 20 Choice")]
    public abstract partial record PaymentInstrument20Choice_
    {
    }
}
