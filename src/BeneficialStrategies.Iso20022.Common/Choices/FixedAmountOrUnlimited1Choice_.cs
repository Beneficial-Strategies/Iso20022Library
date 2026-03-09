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
    /// Choice between a fixed amount and an unlimited amount.
    /// </summary>
    [KnownType(typeof(FixedAmountOrUnlimited1Choice.Amount))]
    [KnownType(typeof(FixedAmountOrUnlimited1Choice.NotLimited))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FixedAmountOrUnlimited1Choice.Amount),nameof(FixedAmountOrUnlimited1Choice.Amount))]
    [JsonDerivedType(typeof(FixedAmountOrUnlimited1Choice.NotLimited),nameof(FixedAmountOrUnlimited1Choice.NotLimited))]
    #endif
    [IsoId("_9m4ooEqAEeKw5sECfP82rg")]
    [DisplayName("Fixed Amount Or Unlimited 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FixedAmountOrUnlimited1Choice_
    #else
    public abstract partial class FixedAmountOrUnlimited1Choice_
    #endif
    {
    }
}
