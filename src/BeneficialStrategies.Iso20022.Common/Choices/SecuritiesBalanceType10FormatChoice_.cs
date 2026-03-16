// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of securities balance.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType10FormatChoice.Code))]
    [KnownType(typeof(SecuritiesBalanceType10FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesBalanceType10FormatChoice.Code),
        nameof(SecuritiesBalanceType10FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesBalanceType10FormatChoice.Proprietary),
        nameof(SecuritiesBalanceType10FormatChoice.Proprietary)
    )]
    [IsoId("_Roygw9p-Ed-ak6NoX_4Aeg_332033215")]
    [DisplayName("Securities Balance Type 10 Format Choice")]
    public abstract record SecuritiesBalanceType10FormatChoice_ { }
}
