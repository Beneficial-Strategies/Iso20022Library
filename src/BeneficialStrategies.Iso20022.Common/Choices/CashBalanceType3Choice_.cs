// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(CashBalanceType3Choice.Code))]
    [KnownType(typeof(CashBalanceType3Choice.Proprietary))]
    [JsonDerivedType(typeof(CashBalanceType3Choice.Code), nameof(CashBalanceType3Choice.Code))]
    [JsonDerivedType(
        typeof(CashBalanceType3Choice.Proprietary),
        nameof(CashBalanceType3Choice.Proprietary)
    )]
    [IsoId("_NLbXFTqFEemJ3KLLPeYl6g")]
    [DisplayName("Cash Balance Type 3 Choice")]
    public abstract record CashBalanceType3Choice_ { }
}
