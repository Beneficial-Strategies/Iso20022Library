// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indication whether reused value is actual or estimated.
    /// </summary>
    [KnownType(typeof(ReuseValue1Choice.Actual))]
    [KnownType(typeof(ReuseValue1Choice.Estimated))]
    [JsonDerivedType(typeof(ReuseValue1Choice.Actual), nameof(ReuseValue1Choice.Actual))]
    [JsonDerivedType(typeof(ReuseValue1Choice.Estimated), nameof(ReuseValue1Choice.Estimated))]
    [IsoId("_MSGu8IxnEeap1-whlAlpOw")]
    [DisplayName("Reuse Value 1 Choice")]
    public abstract record ReuseValue1Choice_ { }
}
