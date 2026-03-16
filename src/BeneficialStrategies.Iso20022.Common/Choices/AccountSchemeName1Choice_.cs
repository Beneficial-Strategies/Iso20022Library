// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Sets of elements to identify a name of the identification scheme.
    /// </summary>
    [KnownType(typeof(AccountSchemeName1Choice.Code))]
    [KnownType(typeof(AccountSchemeName1Choice.Proprietary))]
    [JsonDerivedType(typeof(AccountSchemeName1Choice.Code), nameof(AccountSchemeName1Choice.Code))]
    [JsonDerivedType(
        typeof(AccountSchemeName1Choice.Proprietary),
        nameof(AccountSchemeName1Choice.Proprietary)
    )]
    [IsoId("_P_4pQNp-Ed-ak6NoX_4Aeg_-240227306")]
    [DisplayName("Account Scheme Name 1 Choice")]
    public abstract record AccountSchemeName1Choice_ { }
}
