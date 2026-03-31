// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifies the response parameters for which there is a match with the search criteria.
    /// </summary>
    [KnownType(typeof(InvestigatedParties1Choice.Code))]
    [KnownType(typeof(InvestigatedParties1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InvestigatedParties1Choice.Code),
        nameof(InvestigatedParties1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InvestigatedParties1Choice.Proprietary),
        nameof(InvestigatedParties1Choice.Proprietary)
    )]
    [IsoId("_cRD_EzwTEeGKuZXNQxGH3g")]
    [DisplayName("Investigated Parties 1 Choice")]
    public abstract record InvestigatedParties1Choice_ { }
}
