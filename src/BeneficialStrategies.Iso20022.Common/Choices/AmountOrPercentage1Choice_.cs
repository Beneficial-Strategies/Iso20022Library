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
    /// Choice between an amount and percentage.
    /// </summary>
    [KnownType(typeof(AmountOrPercentage1Choice.DefinedAmount))]
    [KnownType(typeof(AmountOrPercentage1Choice.PercentageAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AmountOrPercentage1Choice.DefinedAmount),nameof(AmountOrPercentage1Choice.DefinedAmount))]
    [JsonDerivedType(typeof(AmountOrPercentage1Choice.PercentageAmount),nameof(AmountOrPercentage1Choice.PercentageAmount))]
    #endif
    [IsoId("_986x5nltEeG7BsjMvd1mEw_930379145")]
    [DisplayName("Amount Or Percentage 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AmountOrPercentage1Choice_
    #else
    public abstract partial class AmountOrPercentage1Choice_
    #endif
    {
    }
}
