// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between types of payment instrument, ie, cheque, credit transfer, direct debit, investment account or payment card.
    /// </summary>
    [KnownType(typeof(PaymentInstrument6Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument6Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument6Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument6Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument6Choice.AccountDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument6Choice.PaymentCardDetails),nameof(PaymentInstrument6Choice.PaymentCardDetails))]
    [JsonDerivedType(typeof(PaymentInstrument6Choice.CreditTransferDetails),nameof(PaymentInstrument6Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument6Choice.DirectDebitDetails),nameof(PaymentInstrument6Choice.DirectDebitDetails))]
    [JsonDerivedType(typeof(PaymentInstrument6Choice.ChequeDetails),nameof(PaymentInstrument6Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument6Choice.AccountDetails),nameof(PaymentInstrument6Choice.AccountDetails))]
    #endif
    [IsoId("_VKiwQNp-Ed-ak6NoX_4Aeg_-620434673")]
    [DisplayName("Payment Instrument 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument6Choice_
    #else
    public abstract partial class PaymentInstrument6Choice_
    #endif
    {
    }
}
