// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies security rate details.
    /// </summary>
    [KnownType(typeof(CorporateActionRateSD7Choice.AdditionalQuantityForExistingSecurities))]
    [KnownType(typeof(CorporateActionRateSD7Choice.NewToOld))]
    [JsonDerivedType(typeof(CorporateActionRateSD7Choice.AdditionalQuantityForExistingSecurities),nameof(CorporateActionRateSD7Choice.AdditionalQuantityForExistingSecurities))]
    [JsonDerivedType(typeof(CorporateActionRateSD7Choice.NewToOld),nameof(CorporateActionRateSD7Choice.NewToOld))]
    [IsoId("__Aet4cOTEeeAG4VQMmSqTA")]
    [DisplayName("Corporate Action Rate SD 7 Choice")]
    public abstract partial record CorporateActionRateSD7Choice_
    {
    }
}
