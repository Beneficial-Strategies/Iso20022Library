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
    /// Choice between expected/due interest payment date and a interest payment schedule per amount and due date.
    /// </summary>
    [KnownType(typeof(InterestPaymentSchedule1Choice.DateRange))]
    [KnownType(typeof(InterestPaymentSchedule1Choice.SubSchedule))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestPaymentSchedule1Choice.DateRange),nameof(InterestPaymentSchedule1Choice.DateRange))]
    [JsonDerivedType(typeof(InterestPaymentSchedule1Choice.SubSchedule),nameof(InterestPaymentSchedule1Choice.SubSchedule))]
    #endif
    [IsoId("_u7i5Q-FWEeSvv6t4Ka7B7A")]
    [DisplayName("Interest Payment Schedule 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestPaymentSchedule1Choice_
    #else
    public abstract partial class InterestPaymentSchedule1Choice_
    #endif
    {
    }
}
