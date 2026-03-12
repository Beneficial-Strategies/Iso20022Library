// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies security rate details.
    /// </summary>
    [KnownType(typeof(CorporateActionRateSD6Choice.AdditionalQuantityForExistingSecurities))]
    [KnownType(typeof(CorporateActionRateSD6Choice.NewToOld))]
    [JsonDerivedType(typeof(CorporateActionRateSD6Choice.AdditionalQuantityForExistingSecurities),nameof(CorporateActionRateSD6Choice.AdditionalQuantityForExistingSecurities))]
    [JsonDerivedType(typeof(CorporateActionRateSD6Choice.NewToOld),nameof(CorporateActionRateSD6Choice.NewToOld))]
    [IsoId("_1kNFZjL3EeKU9IrkkToqcw_1911646277")]
    [DisplayName("Corporate Action Rate SD 6 Choice")]
    public abstract partial record CorporateActionRateSD6Choice_
    {
    }
}
