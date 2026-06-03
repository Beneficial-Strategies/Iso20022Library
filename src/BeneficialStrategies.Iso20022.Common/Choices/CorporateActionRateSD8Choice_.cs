// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies security rate details.
    /// </summary>
    [KnownType(typeof(CorporateActionRateSD8Choice.AdditionalQuantityForExistingSecurities))]
    [KnownType(typeof(CorporateActionRateSD8Choice.NewToOld))]
    [JsonDerivedType(typeof(CorporateActionRateSD8Choice.AdditionalQuantityForExistingSecurities), nameof(CorporateActionRateSD8Choice.AdditionalQuantityForExistingSecurities))]
    [JsonDerivedType(typeof(CorporateActionRateSD8Choice.NewToOld), nameof(CorporateActionRateSD8Choice.NewToOld))]
    [IsoId("_0PTbUbskEfCWCehgFzyN4w")]
    [DisplayName("Corporate Action Rate SD 8 Choice")]
    public abstract record CorporateActionRateSD8Choice_ { }
}
