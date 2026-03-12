// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat12Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat12Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeaturesFormat12Choice.Code),nameof(OptionFeaturesFormat12Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat12Choice.Proprietary),nameof(OptionFeaturesFormat12Choice.Proprietary))]
    [IsoId("_f4B4wSdbEeOXAt_43VmZGw")]
    [DisplayName("Option Features Format 12 Choice")]
    public abstract partial record OptionFeaturesFormat12Choice_
    {
    }
}
