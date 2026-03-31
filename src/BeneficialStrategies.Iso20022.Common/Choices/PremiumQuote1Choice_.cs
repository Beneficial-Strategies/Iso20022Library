// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the amount of a premium on a currency option together with its calculation method.
    /// </summary>
    [KnownType(typeof(PremiumQuote1Choice.PercentageOfCallAmount))]
    [KnownType(typeof(PremiumQuote1Choice.PercentageOfPutAmount))]
    [KnownType(typeof(PremiumQuote1Choice.PointsOfCallAmount))]
    [KnownType(typeof(PremiumQuote1Choice.PointsOfPutAmount))]
    [JsonDerivedType(
        typeof(PremiumQuote1Choice.PercentageOfCallAmount),
        nameof(PremiumQuote1Choice.PercentageOfCallAmount)
    )]
    [JsonDerivedType(
        typeof(PremiumQuote1Choice.PercentageOfPutAmount),
        nameof(PremiumQuote1Choice.PercentageOfPutAmount)
    )]
    [JsonDerivedType(
        typeof(PremiumQuote1Choice.PointsOfCallAmount),
        nameof(PremiumQuote1Choice.PointsOfCallAmount)
    )]
    [JsonDerivedType(
        typeof(PremiumQuote1Choice.PointsOfPutAmount),
        nameof(PremiumQuote1Choice.PointsOfPutAmount)
    )]
    [IsoId("_TMB1Itp-Ed-ak6NoX_4Aeg_-553386135")]
    [DisplayName("Premium Quote 1 Choice")]
    public abstract record PremiumQuote1Choice_ { }
}
