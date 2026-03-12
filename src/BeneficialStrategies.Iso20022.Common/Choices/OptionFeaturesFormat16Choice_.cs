// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat16Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat16Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeaturesFormat16Choice.Code),nameof(OptionFeaturesFormat16Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat16Choice.Proprietary),nameof(OptionFeaturesFormat16Choice.Proprietary))]
    [IsoId("_pSovkUEHEeWVgfuHGaKtRQ")]
    [DisplayName("Option Features Format 16 Choice")]
    public abstract partial record OptionFeaturesFormat16Choice_
    {
    }
}
