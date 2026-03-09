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
    /// Specifies the amount of a premium on a currency option together with its calculation method.
    /// </summary>
    [KnownType(typeof(PremiumQuote1Choice.PercentageOfCallAmount))]
    [KnownType(typeof(PremiumQuote1Choice.PercentageOfPutAmount))]
    [KnownType(typeof(PremiumQuote1Choice.PointsOfCallAmount))]
    [KnownType(typeof(PremiumQuote1Choice.PointsOfPutAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PremiumQuote1Choice.PercentageOfCallAmount),nameof(PremiumQuote1Choice.PercentageOfCallAmount))]
    [JsonDerivedType(typeof(PremiumQuote1Choice.PercentageOfPutAmount),nameof(PremiumQuote1Choice.PercentageOfPutAmount))]
    [JsonDerivedType(typeof(PremiumQuote1Choice.PointsOfCallAmount),nameof(PremiumQuote1Choice.PointsOfCallAmount))]
    [JsonDerivedType(typeof(PremiumQuote1Choice.PointsOfPutAmount),nameof(PremiumQuote1Choice.PointsOfPutAmount))]
    #endif
    [IsoId("_TMB1Itp-Ed-ak6NoX_4Aeg_-553386135")]
    [DisplayName("Premium Quote 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PremiumQuote1Choice_
    #else
    public abstract partial class PremiumQuote1Choice_
    #endif
    {
    }
}
