// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account10Choice.
    /// </summary>
    [KnownType(typeof(Account10Choice.CashAccount))]
    [KnownType(typeof(Account10Choice.ChargesAccount))]
    [KnownType(typeof(Account10Choice.TaxAccount))]
    [JsonDerivedType(typeof(Account10Choice.CashAccount), nameof(Account10Choice.CashAccount))]
    [JsonDerivedType(
        typeof(Account10Choice.ChargesAccount),
        nameof(Account10Choice.ChargesAccount)
    )]
    [JsonDerivedType(typeof(Account10Choice.TaxAccount), nameof(Account10Choice.TaxAccount))]
    [IsoId("_olMCy5BPEe-COKgew96POA")]
    [DisplayName("Account10Choice")]
    public abstract record Account10Choice_ { }
}
