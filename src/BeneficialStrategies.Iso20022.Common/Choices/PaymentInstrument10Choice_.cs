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
    /// Choice between types of payment instrument, ie, credit transfer, cheque, payment card, investment cash account or direct debit.
    /// </summary>
    [KnownType(typeof(PaymentInstrument10Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument10Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument10Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument10Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument10Choice.AccountDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument10Choice.PaymentCardDetails),nameof(PaymentInstrument10Choice.PaymentCardDetails))]
    [JsonDerivedType(typeof(PaymentInstrument10Choice.CreditTransferDetails),nameof(PaymentInstrument10Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument10Choice.DirectDebitDetails),nameof(PaymentInstrument10Choice.DirectDebitDetails))]
    [JsonDerivedType(typeof(PaymentInstrument10Choice.ChequeDetails),nameof(PaymentInstrument10Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument10Choice.AccountDetails),nameof(PaymentInstrument10Choice.AccountDetails))]
    #endif
    [IsoId("_VKY_Rtp-Ed-ak6NoX_4Aeg_734057873")]
    [DisplayName("Payment Instrument 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument10Choice_
    #else
    public abstract partial class PaymentInstrument10Choice_
    #endif
    {
    }
}
