// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of securities or cash parties.
    /// </summary>
    [KnownType(typeof(SecuritiesOrCash1Choice.SecuritiesDetails))]
    [KnownType(typeof(SecuritiesOrCash1Choice.CashPartiesDetails))]
    [JsonDerivedType(
        typeof(SecuritiesOrCash1Choice.SecuritiesDetails),
        nameof(SecuritiesOrCash1Choice.SecuritiesDetails)
    )]
    [JsonDerivedType(
        typeof(SecuritiesOrCash1Choice.CashPartiesDetails),
        nameof(SecuritiesOrCash1Choice.CashPartiesDetails)
    )]
    [IsoId("_xeOrADcgEeOA3chqL9a4Rw")]
    [DisplayName("Securities Or Cash 1 Choice")]
    public abstract record SecuritiesOrCash1Choice_ { }
}
