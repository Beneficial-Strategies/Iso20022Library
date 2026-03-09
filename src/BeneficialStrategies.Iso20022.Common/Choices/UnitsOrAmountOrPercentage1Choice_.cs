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
    /// Choice between an amount or number of units or percentage.
    /// </summary>
    [KnownType(typeof(UnitsOrAmountOrPercentage1Choice.Amount))]
    [KnownType(typeof(UnitsOrAmountOrPercentage1Choice.Unit))]
    [KnownType(typeof(UnitsOrAmountOrPercentage1Choice.Percentage))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnitsOrAmountOrPercentage1Choice.Amount),nameof(UnitsOrAmountOrPercentage1Choice.Amount))]
    [JsonDerivedType(typeof(UnitsOrAmountOrPercentage1Choice.Unit),nameof(UnitsOrAmountOrPercentage1Choice.Unit))]
    [JsonDerivedType(typeof(UnitsOrAmountOrPercentage1Choice.Percentage),nameof(UnitsOrAmountOrPercentage1Choice.Percentage))]
    #endif
    [IsoId("_-TmAQQjcEeS5F6qHcKOrew")]
    [DisplayName("Units Or Amount Or Percentage 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitsOrAmountOrPercentage1Choice_
    #else
    public abstract partial class UnitsOrAmountOrPercentage1Choice_
    #endif
    {
    }
}
