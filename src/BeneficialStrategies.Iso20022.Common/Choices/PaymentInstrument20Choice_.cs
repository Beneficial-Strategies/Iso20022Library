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
    /// Choice between types of payment instrument, that is, cheque, credit transfer, direct debit, investment account or payment card.
    /// </summary>
    [KnownType(typeof(PaymentInstrument20Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument20Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument20Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument20Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument20Choice.BankersDraftDetails))]
    [KnownType(typeof(PaymentInstrument20Choice.CashAccountDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument20Choice.PaymentCardDetails),nameof(PaymentInstrument20Choice.PaymentCardDetails))]
    [JsonDerivedType(typeof(PaymentInstrument20Choice.CreditTransferDetails),nameof(PaymentInstrument20Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument20Choice.DirectDebitDetails),nameof(PaymentInstrument20Choice.DirectDebitDetails))]
    [JsonDerivedType(typeof(PaymentInstrument20Choice.ChequeDetails),nameof(PaymentInstrument20Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument20Choice.BankersDraftDetails),nameof(PaymentInstrument20Choice.BankersDraftDetails))]
    [JsonDerivedType(typeof(PaymentInstrument20Choice.CashAccountDetails),nameof(PaymentInstrument20Choice.CashAccountDetails))]
    #endif
    [IsoId("_wFdXNzbsEead9bDRE_1DAQ")]
    [DisplayName("Payment Instrument 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument20Choice_
    #else
    public abstract partial class PaymentInstrument20Choice_
    #endif
    {
    }
}
