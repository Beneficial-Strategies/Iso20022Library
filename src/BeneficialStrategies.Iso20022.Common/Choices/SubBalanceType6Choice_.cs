// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the sub-balance.
    /// </summary>
    [KnownType(typeof(SubBalanceType6Choice.Code))]
    [KnownType(typeof(SubBalanceType6Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceType6Choice.Code), nameof(SubBalanceType6Choice.Code))]
    [JsonDerivedType(
        typeof(SubBalanceType6Choice.Proprietary),
        nameof(SubBalanceType6Choice.Proprietary)
    )]
    [IsoId("_QYBcfNp-Ed-ak6NoX_4Aeg_1907481606")]
    [DisplayName("Sub Balance Type 6 Choice")]
    public abstract record SubBalanceType6Choice_ { }
}
