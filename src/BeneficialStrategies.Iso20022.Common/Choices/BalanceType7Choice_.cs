// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(BalanceType7Choice.Code))]
    [KnownType(typeof(BalanceType7Choice.Proprietary))]
    [KnownType(typeof(BalanceType7Choice.Account))]
    [JsonDerivedType(typeof(BalanceType7Choice.Code),nameof(BalanceType7Choice.Code))]
    [JsonDerivedType(typeof(BalanceType7Choice.Proprietary),nameof(BalanceType7Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceType7Choice.Account),nameof(BalanceType7Choice.Account))]
    [IsoId("_nAhTV_NBEeCuA5Tr22BnwA_51741931")]
    [DisplayName("Balance Type 7 Choice")]
    public abstract partial record BalanceType7Choice_
    {
    }
}
