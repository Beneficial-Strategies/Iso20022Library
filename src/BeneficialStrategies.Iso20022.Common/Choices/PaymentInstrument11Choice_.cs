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
    /// Choice between types of payment instrument, ie, cheque, credit transfer or investment account.
    /// </summary>
    [KnownType(typeof(PaymentInstrument11Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument11Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument11Choice.BankersDraftDetails))]
    [KnownType(typeof(PaymentInstrument11Choice.CashAccountDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument11Choice.CreditTransferDetails),nameof(PaymentInstrument11Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument11Choice.ChequeDetails),nameof(PaymentInstrument11Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument11Choice.BankersDraftDetails),nameof(PaymentInstrument11Choice.BankersDraftDetails))]
    [JsonDerivedType(typeof(PaymentInstrument11Choice.CashAccountDetails),nameof(PaymentInstrument11Choice.CashAccountDetails))]
    #endif
    [IsoId("_SBhw49p-Ed-ak6NoX_4Aeg_112681457")]
    [DisplayName("Payment Instrument 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument11Choice_
    #else
    public abstract partial class PaymentInstrument11Choice_
    #endif
    {
    }
}
