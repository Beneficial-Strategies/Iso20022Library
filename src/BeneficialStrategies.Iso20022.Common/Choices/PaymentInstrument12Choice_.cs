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
    [KnownType(typeof(PaymentInstrument12Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument12Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument12Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument12Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument12Choice.BankersDraftDetails))]
    [KnownType(typeof(PaymentInstrument12Choice.CashAccountDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument12Choice.PaymentCardDetails),nameof(PaymentInstrument12Choice.PaymentCardDetails))]
    [JsonDerivedType(typeof(PaymentInstrument12Choice.CreditTransferDetails),nameof(PaymentInstrument12Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument12Choice.DirectDebitDetails),nameof(PaymentInstrument12Choice.DirectDebitDetails))]
    [JsonDerivedType(typeof(PaymentInstrument12Choice.ChequeDetails),nameof(PaymentInstrument12Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument12Choice.BankersDraftDetails),nameof(PaymentInstrument12Choice.BankersDraftDetails))]
    [JsonDerivedType(typeof(PaymentInstrument12Choice.CashAccountDetails),nameof(PaymentInstrument12Choice.CashAccountDetails))]
    #endif
    [IsoId("_SBX_6Np-Ed-ak6NoX_4Aeg_1545982824")]
    [DisplayName("Payment Instrument 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument12Choice_
    #else
    public abstract partial class PaymentInstrument12Choice_
    #endif
    {
    }
}
