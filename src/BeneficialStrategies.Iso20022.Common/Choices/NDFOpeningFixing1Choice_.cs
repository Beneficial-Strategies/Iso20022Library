// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of providing the opening conditions or fixing conditions for an NDF instruction.
    /// </summary>
    [KnownType(typeof(NDFOpeningFixing1Choice.OpeningConditions))]
    [KnownType(typeof(NDFOpeningFixing1Choice.OpeningConfirmationReference))]
    [JsonDerivedType(
        typeof(NDFOpeningFixing1Choice.OpeningConditions),
        nameof(NDFOpeningFixing1Choice.OpeningConditions)
    )]
    [JsonDerivedType(
        typeof(NDFOpeningFixing1Choice.OpeningConfirmationReference),
        nameof(NDFOpeningFixing1Choice.OpeningConfirmationReference)
    )]
    [IsoId("_1koBMJUIEeak6e8_Fc5fQg")]
    [DisplayName("NDF Opening Fixing 1 Choice")]
    public abstract record NDFOpeningFixing1Choice_ { }
}
