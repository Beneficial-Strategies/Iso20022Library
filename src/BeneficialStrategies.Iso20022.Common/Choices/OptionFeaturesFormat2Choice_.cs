// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat2Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat2Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeaturesFormat2Choice.Code),nameof(OptionFeaturesFormat2Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat2Choice.Proprietary),nameof(OptionFeaturesFormat2Choice.Proprietary))]
    [IsoId("_Q0L0Bdp-Ed-ak6NoX_4Aeg_-1816334318")]
    [DisplayName("Option Features Format 2 Choice")]
    public abstract partial record OptionFeaturesFormat2Choice_
    {
    }
}
