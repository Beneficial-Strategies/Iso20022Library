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
    /// Settlement details to determine whether payment is a credit or debit.
    /// </summary>
    [KnownType(typeof(SettlementMethod1Choice.Credit))]
    [KnownType(typeof(SettlementMethod1Choice.Debit))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementMethod1Choice.Credit),nameof(SettlementMethod1Choice.Credit))]
    [JsonDerivedType(typeof(SettlementMethod1Choice.Debit),nameof(SettlementMethod1Choice.Debit))]
    #endif
    [IsoId("_alSkAQ2uEeSNWNtJlXOAhg")]
    [DisplayName("Settlement Method 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementMethod1Choice_
    #else
    public abstract partial class SettlementMethod1Choice_
    #endif
    {
    }
}
