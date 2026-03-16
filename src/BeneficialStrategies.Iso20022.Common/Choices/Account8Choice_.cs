// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    [KnownType(typeof(Account8Choice.CashAccount))]
    [KnownType(typeof(Account8Choice.ChargesAccount))]
    [KnownType(typeof(Account8Choice.TaxAccount))]
    [JsonDerivedType(typeof(Account8Choice.CashAccount), nameof(Account8Choice.CashAccount))]
    [JsonDerivedType(typeof(Account8Choice.ChargesAccount), nameof(Account8Choice.ChargesAccount))]
    [JsonDerivedType(typeof(Account8Choice.TaxAccount), nameof(Account8Choice.TaxAccount))]
    [IsoId("_Q4z1Udp-Ed-ak6NoX_4Aeg_-2028069382")]
    [DisplayName("Account 8 Choice")]
    public abstract record Account8Choice_ { }
}
