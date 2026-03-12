// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of elements defining the balance details.
    /// </summary>
    [KnownType(typeof(BalanceType2Choice.Code))]
    [KnownType(typeof(BalanceType2Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceType2Choice.Code),nameof(BalanceType2Choice.Code))]
    [JsonDerivedType(typeof(BalanceType2Choice.Proprietary),nameof(BalanceType2Choice.Proprietary))]
    [IsoId("_RcH9wtp-Ed-ak6NoX_4Aeg_1127274775")]
    [DisplayName("Balance Type 2 Choice")]
    public abstract partial record BalanceType2Choice_
    {
    }
}
