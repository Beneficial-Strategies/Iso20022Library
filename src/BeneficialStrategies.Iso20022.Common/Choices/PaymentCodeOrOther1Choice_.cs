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
    [KnownType(typeof(PaymentCodeOrOther1Choice.PaymentCode))]
    [KnownType(typeof(PaymentCodeOrOther1Choice.PaymentDueDate))]
    [KnownType(typeof(PaymentCodeOrOther1Choice.OtherPaymentTerms))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentCodeOrOther1Choice.PaymentCode),nameof(PaymentCodeOrOther1Choice.PaymentCode))]
    [JsonDerivedType(typeof(PaymentCodeOrOther1Choice.PaymentDueDate),nameof(PaymentCodeOrOther1Choice.PaymentDueDate))]
    [JsonDerivedType(typeof(PaymentCodeOrOther1Choice.OtherPaymentTerms),nameof(PaymentCodeOrOther1Choice.OtherPaymentTerms))]
    #endif
    [IsoId("_ogNJwNP8EeK0PPbKncCqzA")]
    [DisplayName("Payment Code Or Other 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentCodeOrOther1Choice_
    #else
    public abstract partial class PaymentCodeOrOther1Choice_
    #endif
    {
    }
}
