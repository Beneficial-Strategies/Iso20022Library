// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of securities balance.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType9FormatChoice.Code))]
    [KnownType(typeof(SecuritiesBalanceType9FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesBalanceType9FormatChoice.Code),nameof(SecuritiesBalanceType9FormatChoice.Code))]
    [JsonDerivedType(typeof(SecuritiesBalanceType9FormatChoice.Proprietary),nameof(SecuritiesBalanceType9FormatChoice.Proprietary))]
    [IsoId("_Ro8RwNp-Ed-ak6NoX_4Aeg_-124095903")]
    [DisplayName("Securities Balance Type 9 Format Choice")]
    public abstract partial record SecuritiesBalanceType9FormatChoice_
    {
    }
}
