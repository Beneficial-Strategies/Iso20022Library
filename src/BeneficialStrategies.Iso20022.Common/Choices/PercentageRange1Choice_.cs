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
    /// Choice between ranges of rates in which a percentage rate is considered valid or a specified percentage rate which has to be matched or unmatched to be valid.
    /// </summary>
    [KnownType(typeof(PercentageRange1Choice.From))]
    [KnownType(typeof(PercentageRange1Choice.To))]
    [KnownType(typeof(PercentageRange1Choice.FromTo))]
    [KnownType(typeof(PercentageRange1Choice.Equal))]
    [KnownType(typeof(PercentageRange1Choice.NotEqual))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PercentageRange1Choice.From),nameof(PercentageRange1Choice.From))]
    [JsonDerivedType(typeof(PercentageRange1Choice.To),nameof(PercentageRange1Choice.To))]
    [JsonDerivedType(typeof(PercentageRange1Choice.FromTo),nameof(PercentageRange1Choice.FromTo))]
    [JsonDerivedType(typeof(PercentageRange1Choice.Equal),nameof(PercentageRange1Choice.Equal))]
    [JsonDerivedType(typeof(PercentageRange1Choice.NotEqual),nameof(PercentageRange1Choice.NotEqual))]
    #endif
    [IsoId("_7_BRqKMgEeCJ6YNENx4h-w_249022340")]
    [DisplayName("Percentage Range 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PercentageRange1Choice_
    #else
    public abstract partial class PercentageRange1Choice_
    #endif
    {
    }
}
