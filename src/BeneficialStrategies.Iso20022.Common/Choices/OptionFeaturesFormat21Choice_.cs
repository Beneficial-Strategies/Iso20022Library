// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat21Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat21Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeaturesFormat21Choice.Code),nameof(OptionFeaturesFormat21Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat21Choice.Proprietary),nameof(OptionFeaturesFormat21Choice.Proprietary))]
    [IsoId("_c5XvRZKQEeWHWpTQn1FFVg")]
    [DisplayName("Option Features Format 21 Choice")]
    public abstract partial record OptionFeaturesFormat21Choice_
    {
    }
}
