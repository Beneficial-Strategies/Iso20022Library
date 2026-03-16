// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType3Choice.Code))]
    [KnownType(typeof(SecuritiesBalanceType3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesBalanceType3Choice.Code),
        nameof(SecuritiesBalanceType3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesBalanceType3Choice.Proprietary),
        nameof(SecuritiesBalanceType3Choice.Proprietary)
    )]
    [IsoId("_QtCDJtp-Ed-ak6NoX_4Aeg_1544987525")]
    [DisplayName("Securities Balance Type 3 Choice")]
    public abstract record SecuritiesBalanceType3Choice_ { }
}
