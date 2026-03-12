// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat23Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat23Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeaturesFormat23Choice.Code),nameof(OptionFeaturesFormat23Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat23Choice.Proprietary),nameof(OptionFeaturesFormat23Choice.Proprietary))]
    [IsoId("_scbuaZwqEeazcsnODTksnQ")]
    [DisplayName("Option Features Format 23 Choice")]
    public abstract partial record OptionFeaturesFormat23Choice_
    {
    }
}
