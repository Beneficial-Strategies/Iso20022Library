// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType2Choice.Code))]
    [KnownType(typeof(SecuritiesBalanceType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesBalanceType2Choice.Code),
        nameof(SecuritiesBalanceType2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesBalanceType2Choice.Proprietary),
        nameof(SecuritiesBalanceType2Choice.Proprietary)
    )]
    [IsoId("_QtL0Itp-Ed-ak6NoX_4Aeg_-1968093030")]
    [DisplayName("Securities Balance Type 2 Choice")]
    public abstract record SecuritiesBalanceType2Choice_ { }
}
