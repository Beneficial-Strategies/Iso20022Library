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
    /// Choice between expected/due payment date and a payment schedule per amount and due date.
    /// </summary>
    [KnownType(typeof(PaymentSchedule1Choice.DateRange))]
    [KnownType(typeof(PaymentSchedule1Choice.SubSchedule))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentSchedule1Choice.DateRange),nameof(PaymentSchedule1Choice.DateRange))]
    [JsonDerivedType(typeof(PaymentSchedule1Choice.SubSchedule),nameof(PaymentSchedule1Choice.SubSchedule))]
    #endif
    [IsoId("_BVaygdOAEeSQ_-lmj1tzfw")]
    [DisplayName("Payment Schedule 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentSchedule1Choice_
    #else
    public abstract partial class PaymentSchedule1Choice_
    #endif
    {
    }
}
