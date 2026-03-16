// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature of the risk management limit defined as a choice between a coded list or a proprietary limit.
    /// </summary>
    [KnownType(typeof(LimitType1Choice.Code))]
    [KnownType(typeof(LimitType1Choice.Proprietary))]
    [JsonDerivedType(typeof(LimitType1Choice.Code), nameof(LimitType1Choice.Code))]
    [JsonDerivedType(typeof(LimitType1Choice.Proprietary), nameof(LimitType1Choice.Proprietary))]
    [IsoId("_79FX8KMgEeCJ6YNENx4h-w_1397757128")]
    [DisplayName("Limit Type 1 Choice")]
    public abstract record LimitType1Choice_ { }
}
