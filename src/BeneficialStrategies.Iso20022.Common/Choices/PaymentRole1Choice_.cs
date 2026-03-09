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
    /// Specifies the role associated with a specific party in relation to a payment instruction.
    /// </summary>
    [KnownType(typeof(PaymentRole1Choice.Code))]
    [KnownType(typeof(PaymentRole1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentRole1Choice.Code),nameof(PaymentRole1Choice.Code))]
    [JsonDerivedType(typeof(PaymentRole1Choice.Proprietary),nameof(PaymentRole1Choice.Proprietary))]
    #endif
    [IsoId("_b_Ox03hiEeidzqjNEfehPg")]
    [DisplayName("Payment Role 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentRole1Choice_
    #else
    public abstract partial class PaymentRole1Choice_
    #endif
    {
    }
}
