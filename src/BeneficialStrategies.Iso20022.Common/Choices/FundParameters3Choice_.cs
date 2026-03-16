// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of fund parameters.
    /// </summary>
    [KnownType(typeof(FundParameters3Choice.NoCriteria))]
    [KnownType(typeof(FundParameters3Choice.Parameters))]
    [JsonDerivedType(
        typeof(FundParameters3Choice.NoCriteria),
        nameof(FundParameters3Choice.NoCriteria)
    )]
    [JsonDerivedType(
        typeof(FundParameters3Choice.Parameters),
        nameof(FundParameters3Choice.Parameters)
    )]
    [IsoId("_Q6l-ANp-Ed-ak6NoX_4Aeg_36568283")]
    [DisplayName("Fund Parameters 3 Choice")]
    public abstract record FundParameters3Choice_ { }
}
