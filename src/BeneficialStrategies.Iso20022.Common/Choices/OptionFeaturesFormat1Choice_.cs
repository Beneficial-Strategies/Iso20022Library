// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat1Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeaturesFormat1Choice.Code),nameof(OptionFeaturesFormat1Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat1Choice.Proprietary),nameof(OptionFeaturesFormat1Choice.Proprietary))]
    [IsoId("_Q1FL5Np-Ed-ak6NoX_4Aeg_-347103592")]
    [DisplayName("Option Features Format 1 Choice")]
    public abstract partial record OptionFeaturesFormat1Choice_
    {
    }
}
