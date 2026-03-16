// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Option Features Format30Choice.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat30Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat30Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeaturesFormat30Choice.Code),nameof(OptionFeaturesFormat30Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat30Choice.Proprietary),nameof(OptionFeaturesFormat30Choice.Proprietary))]
    [IsoId("_Ur46y3SdEe6VWZz2tTgENw")]
    [DisplayName("Option Features Format30Choice")]
    public abstract partial record OptionFeaturesFormat30Choice_
    {
    }
}
