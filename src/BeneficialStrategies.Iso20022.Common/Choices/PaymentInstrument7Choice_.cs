// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between types of payment instrument, ie, cheque, credit transfer or investment account.
    /// </summary>
    [KnownType(typeof(PaymentInstrument7Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument7Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument7Choice.AccountDetails))]
    [JsonDerivedType(typeof(PaymentInstrument7Choice.CreditTransferDetails),nameof(PaymentInstrument7Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument7Choice.ChequeDetails),nameof(PaymentInstrument7Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument7Choice.AccountDetails),nameof(PaymentInstrument7Choice.AccountDetails))]
    [IsoId("_VKiwRtp-Ed-ak6NoX_4Aeg_-1553198103")]
    [DisplayName("Payment Instrument 7 Choice")]
    public abstract partial record PaymentInstrument7Choice_
    {
    }
}
