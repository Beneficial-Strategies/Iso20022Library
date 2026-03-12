// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of elements defining the balance details.
    /// </summary>
    [KnownType(typeof(BalanceType4Choice.Code))]
    [KnownType(typeof(BalanceType4Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceType4Choice.Code),nameof(BalanceType4Choice.Code))]
    [JsonDerivedType(typeof(BalanceType4Choice.Proprietary),nameof(BalanceType4Choice.Proprietary))]
    [IsoId("_RcRuwNp-Ed-ak6NoX_4Aeg_-1171282176")]
    [DisplayName("Balance Type 4 Choice")]
    public abstract partial record BalanceType4Choice_
    {
    }
}
