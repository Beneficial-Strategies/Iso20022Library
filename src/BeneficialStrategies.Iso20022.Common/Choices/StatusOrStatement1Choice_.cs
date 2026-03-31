// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the identification of a status or statement query.
    /// </summary>
    [KnownType(typeof(StatusOrStatement1Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement1Choice.Statement))]
    [JsonDerivedType(
        typeof(StatusOrStatement1Choice.StatusAdvice),
        nameof(StatusOrStatement1Choice.StatusAdvice)
    )]
    [JsonDerivedType(
        typeof(StatusOrStatement1Choice.Statement),
        nameof(StatusOrStatement1Choice.Statement)
    )]
    [IsoId("_QqNYodp-Ed-ak6NoX_4Aeg_-151525982")]
    [DisplayName("Status Or Statement 1 Choice")]
    public abstract record StatusOrStatement1Choice_ { }
}
