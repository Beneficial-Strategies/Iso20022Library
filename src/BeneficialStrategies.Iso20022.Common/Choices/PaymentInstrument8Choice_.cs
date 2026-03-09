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
    [KnownType(typeof(PaymentInstrument8Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument8Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument8Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument8Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument8Choice.AccountDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument8Choice.PaymentCardDetails),nameof(PaymentInstrument8Choice.PaymentCardDetails))]
    [JsonDerivedType(typeof(PaymentInstrument8Choice.CreditTransferDetails),nameof(PaymentInstrument8Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument8Choice.DirectDebitDetails),nameof(PaymentInstrument8Choice.DirectDebitDetails))]
    [JsonDerivedType(typeof(PaymentInstrument8Choice.ChequeDetails),nameof(PaymentInstrument8Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument8Choice.AccountDetails),nameof(PaymentInstrument8Choice.AccountDetails))]
    #endif
    [IsoId("_VKshQdp-Ed-ak6NoX_4Aeg_-704155609")]
    [DisplayName("Payment Instrument 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument8Choice_
    #else
    public abstract partial class PaymentInstrument8Choice_
    #endif
    {
    }
}
