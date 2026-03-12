// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the lottery type.
    /// </summary>
    [KnownType(typeof(LotteryType1FormatChoice.Code))]
    [KnownType(typeof(LotteryType1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(LotteryType1FormatChoice.Code),nameof(LotteryType1FormatChoice.Code))]
    [JsonDerivedType(typeof(LotteryType1FormatChoice.Proprietary),nameof(LotteryType1FormatChoice.Proprietary))]
    [IsoId("_Rms2Fdp-Ed-ak6NoX_4Aeg_1767480666")]
    [DisplayName("Lottery Type 1 Format Choice")]
    public abstract partial record LotteryType1FormatChoice_
    {
    }
}
