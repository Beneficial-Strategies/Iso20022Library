// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the rate.
    /// </summary>
    [KnownType(typeof(RateType67Choice.Code))]
    [KnownType(typeof(RateType67Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType67Choice.Code),nameof(RateType67Choice.Code))]
    [JsonDerivedType(typeof(RateType67Choice.Proprietary),nameof(RateType67Choice.Proprietary))]
    [IsoId("_5mw35ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Rate Type 67 Choice")]
    public abstract partial record RateType67Choice_
    {
    }
}
