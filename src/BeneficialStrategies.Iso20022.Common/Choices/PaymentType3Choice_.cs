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
    /// Choice between a payment type from a predefined list and a proprietary payment type.
    /// </summary>
    [KnownType(typeof(PaymentType3Choice.Code))]
    [KnownType(typeof(PaymentType3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentType3Choice.Code),nameof(PaymentType3Choice.Code))]
    [JsonDerivedType(typeof(PaymentType3Choice.Proprietary),nameof(PaymentType3Choice.Proprietary))]
    #endif
    [IsoId("_72PJGKMgEeCJ6YNENx4h-w_1987696295")]
    [DisplayName("Payment Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentType3Choice_
    #else
    public abstract partial class PaymentType3Choice_
    #endif
    {
    }
}
