// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of net dividend rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateType1FormatChoice.Code))]
    [KnownType(typeof(NetDividendRateType1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(NetDividendRateType1FormatChoice.Code),nameof(NetDividendRateType1FormatChoice.Code))]
    [JsonDerivedType(typeof(NetDividendRateType1FormatChoice.Proprietary),nameof(NetDividendRateType1FormatChoice.Proprietary))]
    [IsoId("_Rms2GNp-Ed-ak6NoX_4Aeg_-2087879060")]
    [DisplayName("Net Dividend Rate Type 1 Format Choice")]
    public abstract partial record NetDividendRateType1FormatChoice_
    {
    }
}
