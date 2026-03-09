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
    /// Indicates the schedule or frequency of the derivative transactions.
    /// </summary>
    [KnownType(typeof(QuantityOrTerm1Choice.SchedulePeriod))]
    [KnownType(typeof(QuantityOrTerm1Choice.Term))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(QuantityOrTerm1Choice.SchedulePeriod),nameof(QuantityOrTerm1Choice.SchedulePeriod))]
    [JsonDerivedType(typeof(QuantityOrTerm1Choice.Term),nameof(QuantityOrTerm1Choice.Term))]
    #endif
    [IsoId("_VVI-wCJDEe2zWP9pqvmqdw")]
    [DisplayName("Quantity Or Term 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record QuantityOrTerm1Choice_
    #else
    public abstract partial class QuantityOrTerm1Choice_
    #endif
    {
    }
}
