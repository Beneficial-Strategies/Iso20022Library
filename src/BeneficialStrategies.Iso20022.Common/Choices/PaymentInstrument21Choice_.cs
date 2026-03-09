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
    /// Choice between types of payment instrument, that is, cheque, credit transfer or investment account.
    /// </summary>
    [KnownType(typeof(PaymentInstrument21Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument21Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument21Choice.BankersDraftDetails))]
    [KnownType(typeof(PaymentInstrument21Choice.CashAccountDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument21Choice.CreditTransferDetails),nameof(PaymentInstrument21Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument21Choice.ChequeDetails),nameof(PaymentInstrument21Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument21Choice.BankersDraftDetails),nameof(PaymentInstrument21Choice.BankersDraftDetails))]
    [JsonDerivedType(typeof(PaymentInstrument21Choice.CashAccountDetails),nameof(PaymentInstrument21Choice.CashAccountDetails))]
    #endif
    [IsoId("_3zQJVzbsEead9bDRE_1DAQ")]
    [DisplayName("Payment Instrument 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument21Choice_
    #else
    public abstract partial class PaymentInstrument21Choice_
    #endif
    {
    }
}
