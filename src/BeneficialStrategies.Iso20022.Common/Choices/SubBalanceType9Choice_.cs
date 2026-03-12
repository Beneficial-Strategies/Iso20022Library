// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the sub-balance.
    /// </summary>
    [KnownType(typeof(SubBalanceType9Choice.Code))]
    [KnownType(typeof(SubBalanceType9Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceType9Choice.Code),nameof(SubBalanceType9Choice.Code))]
    [JsonDerivedType(typeof(SubBalanceType9Choice.Proprietary),nameof(SubBalanceType9Choice.Proprietary))]
    [IsoId("_YekH94jvEeONZKAAW4pOaQ")]
    [DisplayName("Sub Balance Type 9 Choice")]
    public abstract partial record SubBalanceType9Choice_
    {
    }
}
