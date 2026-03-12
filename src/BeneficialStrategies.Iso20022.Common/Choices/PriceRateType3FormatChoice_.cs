// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of price rate.
    /// </summary>
    [KnownType(typeof(PriceRateType3FormatChoice.Code))]
    [KnownType(typeof(PriceRateType3FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(PriceRateType3FormatChoice.Code),nameof(PriceRateType3FormatChoice.Code))]
    [JsonDerivedType(typeof(PriceRateType3FormatChoice.Proprietary),nameof(PriceRateType3FormatChoice.Proprietary))]
    [IsoId("_RnAYE9p-Ed-ak6NoX_4Aeg_1859127225")]
    [DisplayName("Price Rate Type 3 Format Choice")]
    public abstract partial record PriceRateType3FormatChoice_
    {
    }
}
