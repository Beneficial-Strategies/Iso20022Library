// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of cash account.
    /// </summary>
    [KnownType(typeof(CashAccountType3Choice.Code))]
    [KnownType(typeof(CashAccountType3Choice.Proprietary))]
    [JsonDerivedType(typeof(CashAccountType3Choice.Code), nameof(CashAccountType3Choice.Code))]
    [JsonDerivedType(
        typeof(CashAccountType3Choice.Proprietary),
        nameof(CashAccountType3Choice.Proprietary)
    )]
    [IsoId("_FQ5iwCCyEeWJd9HF2tO7BA")]
    [DisplayName("Cash Account Type 3 Choice")]
    public abstract record CashAccountType3Choice_ { }
}
