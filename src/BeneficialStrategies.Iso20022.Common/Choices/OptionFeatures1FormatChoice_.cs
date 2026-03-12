// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the feature of an option.
    /// </summary>
    [KnownType(typeof(OptionFeatures1FormatChoice.Code))]
    [KnownType(typeof(OptionFeatures1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeatures1FormatChoice.Code),nameof(OptionFeatures1FormatChoice.Code))]
    [JsonDerivedType(typeof(OptionFeatures1FormatChoice.Proprietary),nameof(OptionFeatures1FormatChoice.Proprietary))]
    [IsoId("_Rm2nFdp-Ed-ak6NoX_4Aeg_741252058")]
    [DisplayName("Option Features 1 Format Choice")]
    public abstract partial record OptionFeatures1FormatChoice_
    {
    }
}
