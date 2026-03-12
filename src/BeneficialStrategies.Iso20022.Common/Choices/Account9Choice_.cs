// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    [KnownType(typeof(Account9Choice.CashAccount))]
    [KnownType(typeof(Account9Choice.ChargesAccount))]
    [KnownType(typeof(Account9Choice.TaxAccount))]
    [JsonDerivedType(typeof(Account9Choice.CashAccount),nameof(Account9Choice.CashAccount))]
    [JsonDerivedType(typeof(Account9Choice.ChargesAccount),nameof(Account9Choice.ChargesAccount))]
    [JsonDerivedType(typeof(Account9Choice.TaxAccount),nameof(Account9Choice.TaxAccount))]
    [IsoId("_XY2a49p-Ed-ak6NoX_4Aeg_-2005416600")]
    [DisplayName("Account 9 Choice")]
    public abstract partial record Account9Choice_
    {
    }
}
