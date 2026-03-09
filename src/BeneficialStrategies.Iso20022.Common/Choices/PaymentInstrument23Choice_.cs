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
    /// Choice between types of payment instrument.
    /// </summary>
    [KnownType(typeof(PaymentInstrument23Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument23Choice.ChequeDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentInstrument23Choice.CreditTransferDetails),nameof(PaymentInstrument23Choice.CreditTransferDetails))]
    [JsonDerivedType(typeof(PaymentInstrument23Choice.ChequeDetails),nameof(PaymentInstrument23Choice.ChequeDetails))]
    #endif
    [IsoId("_Z55NsFNaEeijdq8ilaxyOA")]
    [DisplayName("Payment Instrument 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument23Choice_
    #else
    public abstract partial class PaymentInstrument23Choice_
    #endif
    {
    }
}
