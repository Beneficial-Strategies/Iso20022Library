// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account11Choice.
    /// </summary>
    [KnownType(typeof(Account11Choice.CashAccount))]
    [KnownType(typeof(Account11Choice.ChargesAccount))]
    [KnownType(typeof(Account11Choice.TaxAccount))]
    [JsonDerivedType(typeof(Account11Choice.CashAccount), nameof(Account11Choice.CashAccount))]
    [JsonDerivedType(
        typeof(Account11Choice.ChargesAccount),
        nameof(Account11Choice.ChargesAccount)
    )]
    [JsonDerivedType(typeof(Account11Choice.TaxAccount), nameof(Account11Choice.TaxAccount))]
    [IsoId("_kv-O3Zt3Ee-wQIOX0djF2w")]
    [DisplayName("Account11Choice")]
    public abstract record Account11Choice_ { }
}
