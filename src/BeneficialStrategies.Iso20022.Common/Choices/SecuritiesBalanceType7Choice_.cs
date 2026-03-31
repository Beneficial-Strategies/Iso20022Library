// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType7Choice.Code))]
    [KnownType(typeof(SecuritiesBalanceType7Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesBalanceType7Choice.Code),
        nameof(SecuritiesBalanceType7Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesBalanceType7Choice.Proprietary),
        nameof(SecuritiesBalanceType7Choice.Proprietary)
    )]
    [IsoId("_zRSCkTp7EeWVrPy0StzzSg")]
    [DisplayName("Securities Balance Type 7 Choice")]
    public abstract record SecuritiesBalanceType7Choice_ { }
}
