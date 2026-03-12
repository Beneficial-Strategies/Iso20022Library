// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of securities balance.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType6FormatChoice.Code))]
    [KnownType(typeof(SecuritiesBalanceType6FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesBalanceType6FormatChoice.Code),nameof(SecuritiesBalanceType6FormatChoice.Code))]
    [JsonDerivedType(typeof(SecuritiesBalanceType6FormatChoice.Proprietary),nameof(SecuritiesBalanceType6FormatChoice.Proprietary))]
    [IsoId("_Roygxtp-Ed-ak6NoX_4Aeg_758304831")]
    [DisplayName("Securities Balance Type 6 Format Choice")]
    public abstract partial record SecuritiesBalanceType6FormatChoice_
    {
    }
}
