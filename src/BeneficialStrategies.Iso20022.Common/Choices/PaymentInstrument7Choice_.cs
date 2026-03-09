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
    [KnownType(typeof(PaymentInstrument7Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument7Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument7Choice.AccountDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument7Choice.CreditTransferDetails),nameof(PaymentInstrument7Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument7Choice.ChequeDetails),nameof(PaymentInstrument7Choice.ChequeDetails))]
    [JsonDerivedType(typeof(PaymentInstrument7Choice.AccountDetails),nameof(PaymentInstrument7Choice.AccountDetails))]
    #endif
    [IsoId("_VKiwRtp-Ed-ak6NoX_4Aeg_-1553198103")]
    [DisplayName("Payment Instrument 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument7Choice_
    #else
    public abstract partial class PaymentInstrument7Choice_
    #endif
    {
    }
}
