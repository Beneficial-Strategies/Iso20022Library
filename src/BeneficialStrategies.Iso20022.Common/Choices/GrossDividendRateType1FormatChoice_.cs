// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of gross dividend rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateType1FormatChoice.Code))]
    [KnownType(typeof(GrossDividendRateType1FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(GrossDividendRateType1FormatChoice.Code),
        nameof(GrossDividendRateType1FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateType1FormatChoice.Proprietary),
        nameof(GrossDividendRateType1FormatChoice.Proprietary)
    )]
    [IsoId("_RmjsKNp-Ed-ak6NoX_4Aeg_546925647")]
    [DisplayName("Gross Dividend Rate Type 1 Format Choice")]
    public abstract record GrossDividendRateType1FormatChoice_ { }
}
