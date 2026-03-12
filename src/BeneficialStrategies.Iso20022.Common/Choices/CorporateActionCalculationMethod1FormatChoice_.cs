// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the calculation method for drawings.
    /// </summary>
    [KnownType(typeof(CorporateActionCalculationMethod1FormatChoice.Code))]
    [KnownType(typeof(CorporateActionCalculationMethod1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionCalculationMethod1FormatChoice.Code),nameof(CorporateActionCalculationMethod1FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionCalculationMethod1FormatChoice.Proprietary),nameof(CorporateActionCalculationMethod1FormatChoice.Proprietary))]
    [IsoId("_Rl9PM9p-Ed-ak6NoX_4Aeg_-384222870")]
    [DisplayName("Corporate Action Calculation Method 1 Format Choice")]
    public abstract partial record CorporateActionCalculationMethod1FormatChoice_
    {
    }
}
