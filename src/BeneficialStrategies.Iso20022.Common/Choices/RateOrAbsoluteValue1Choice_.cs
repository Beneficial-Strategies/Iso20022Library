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
    /// Choice between a rate or an absolute value.
    /// </summary>
    [KnownType(typeof(RateOrAbsoluteValue1Choice.RateValue))]
    [KnownType(typeof(RateOrAbsoluteValue1Choice.AbsoluteValue))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateOrAbsoluteValue1Choice.RateValue),nameof(RateOrAbsoluteValue1Choice.RateValue))]
    [JsonDerivedType(typeof(RateOrAbsoluteValue1Choice.AbsoluteValue),nameof(RateOrAbsoluteValue1Choice.AbsoluteValue))]
    #endif
    [IsoId("_RBTC99p-Ed-ak6NoX_4Aeg_955902350")]
    [DisplayName("Rate Or Absolute Value 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateOrAbsoluteValue1Choice_
    #else
    public abstract partial class RateOrAbsoluteValue1Choice_
    #endif
    {
    }
}
