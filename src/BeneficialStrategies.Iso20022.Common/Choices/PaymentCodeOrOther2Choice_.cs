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
    /// Choice between a payment term in a coded or free format.
    /// </summary>
    [KnownType(typeof(PaymentCodeOrOther2Choice.PaymentCode))]
    [KnownType(typeof(PaymentCodeOrOther2Choice.PaymentDueDate))]
    [KnownType(typeof(PaymentCodeOrOther2Choice.OtherPaymentTerms))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentCodeOrOther2Choice.PaymentCode),nameof(PaymentCodeOrOther2Choice.PaymentCode))]
    [JsonDerivedType(typeof(PaymentCodeOrOther2Choice.PaymentDueDate),nameof(PaymentCodeOrOther2Choice.PaymentDueDate))]
    [JsonDerivedType(typeof(PaymentCodeOrOther2Choice.OtherPaymentTerms),nameof(PaymentCodeOrOther2Choice.OtherPaymentTerms))]
    #endif
    [IsoId("_RfD1sRVgEeOrY9qSHVspCA")]
    [DisplayName("Payment Code Or Other 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentCodeOrOther2Choice_
    #else
    public abstract partial class PaymentCodeOrOther2Choice_
    #endif
    {
    }
}
