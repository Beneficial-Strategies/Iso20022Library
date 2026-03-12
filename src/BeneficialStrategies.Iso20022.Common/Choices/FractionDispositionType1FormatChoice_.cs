// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [KnownType(typeof(FractionDispositionType1FormatChoice.Code))]
    [KnownType(typeof(FractionDispositionType1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(FractionDispositionType1FormatChoice.Code),nameof(FractionDispositionType1FormatChoice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType1FormatChoice.Proprietary),nameof(FractionDispositionType1FormatChoice.Proprietary))]
    [IsoId("_RmjsJdp-Ed-ak6NoX_4Aeg_-689292712")]
    [DisplayName("Fraction Disposition Type 1 Format Choice")]
    public abstract partial record FractionDispositionType1FormatChoice_
    {
    }
}
