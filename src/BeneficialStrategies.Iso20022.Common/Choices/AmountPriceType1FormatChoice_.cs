// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the amount price type.
    /// </summary>
    [KnownType(typeof(AmountPriceType1FormatChoice.Code))]
    [KnownType(typeof(AmountPriceType1FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(AmountPriceType1FormatChoice.Code),
        nameof(AmountPriceType1FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(AmountPriceType1FormatChoice.Proprietary),
        nameof(AmountPriceType1FormatChoice.Proprietary)
    )]
    [IsoId("_RlqUQdp-Ed-ak6NoX_4Aeg_-56081039")]
    [DisplayName("Amount Price Type 1 Format Choice")]
    public abstract record AmountPriceType1FormatChoice_ { }
}
