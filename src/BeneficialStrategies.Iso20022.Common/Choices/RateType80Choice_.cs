// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType80Choice.Code))]
    [KnownType(typeof(RateType80Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType80Choice.Code), nameof(RateType80Choice.Code))]
    [JsonDerivedType(typeof(RateType80Choice.Proprietary), nameof(RateType80Choice.Proprietary))]
    [IsoId("_-lkhuAVSEeqjd8n6wD9JVw")]
    [DisplayName("Rate Type 80 Choice")]
    public abstract record RateType80Choice_ { }
}
