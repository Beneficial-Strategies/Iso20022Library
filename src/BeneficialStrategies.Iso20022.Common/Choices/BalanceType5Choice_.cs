// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the balance type.
    /// </summary>
    [KnownType(typeof(BalanceType5Choice.Code))]
    [KnownType(typeof(BalanceType5Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceType5Choice.Code),nameof(BalanceType5Choice.Code))]
    [JsonDerivedType(typeof(BalanceType5Choice.Proprietary),nameof(BalanceType5Choice.Proprietary))]
    [IsoId("_SYxMMNp-Ed-ak6NoX_4Aeg_1163104802")]
    [DisplayName("Balance Type 5 Choice")]
    public abstract partial record BalanceType5Choice_
    {
    }
}
