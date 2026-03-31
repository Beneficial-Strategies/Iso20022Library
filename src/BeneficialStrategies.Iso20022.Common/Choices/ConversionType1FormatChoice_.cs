// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of conversion.
    /// </summary>
    [KnownType(typeof(ConversionType1FormatChoice.Code))]
    [KnownType(typeof(ConversionType1FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(ConversionType1FormatChoice.Code),
        nameof(ConversionType1FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(ConversionType1FormatChoice.Proprietary),
        nameof(ConversionType1FormatChoice.Proprietary)
    )]
    [IsoId("_Rl9PMNp-Ed-ak6NoX_4Aeg_-1506659145")]
    [DisplayName("Conversion Type 1 Format Choice")]
    public abstract record ConversionType1FormatChoice_ { }
}
