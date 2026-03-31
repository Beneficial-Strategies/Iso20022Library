// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the sub-balance.
    /// </summary>
    [KnownType(typeof(SubBalanceType5Choice.Code))]
    [KnownType(typeof(SubBalanceType5Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceType5Choice.Code), nameof(SubBalanceType5Choice.Code))]
    [JsonDerivedType(
        typeof(SubBalanceType5Choice.Proprietary),
        nameof(SubBalanceType5Choice.Proprietary)
    )]
    [IsoId("_QYU-dNp-Ed-ak6NoX_4Aeg_-408061130")]
    [DisplayName("Sub Balance Type 5 Choice")]
    public abstract record SubBalanceType5Choice_ { }
}
