// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account12Choice.
    /// </summary>
    [KnownType(typeof(Account12Choice.CashAccount))]
    [KnownType(typeof(Account12Choice.ChargesAccount))]
    [KnownType(typeof(Account12Choice.TaxAccount))]
    [JsonDerivedType(typeof(Account12Choice.CashAccount), nameof(Account12Choice.CashAccount))]
    [JsonDerivedType(
        typeof(Account12Choice.ChargesAccount),
        nameof(Account12Choice.ChargesAccount)
    )]
    [JsonDerivedType(typeof(Account12Choice.TaxAccount), nameof(Account12Choice.TaxAccount))]
    [IsoId("_m45sW5t3Ee-wQIOX0djF2w")]
    [DisplayName("Account12Choice")]
    public abstract record Account12Choice_ { }
}
