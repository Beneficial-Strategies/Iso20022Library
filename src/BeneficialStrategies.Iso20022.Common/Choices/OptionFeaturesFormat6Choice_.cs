// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat6Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat6Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeaturesFormat6Choice.Code),nameof(OptionFeaturesFormat6Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat6Choice.Proprietary),nameof(OptionFeaturesFormat6Choice.Proprietary))]
    [IsoId("_qWHukd3eEd-KAqAOGQOnnw")]
    [DisplayName("Option Features Format 6 Choice")]
    public abstract partial record OptionFeaturesFormat6Choice_
    {
    }
}
