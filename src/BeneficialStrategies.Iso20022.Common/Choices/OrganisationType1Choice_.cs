// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of organisation.
    /// </summary>
    [KnownType(typeof(OrganisationType1Choice.Code))]
    [KnownType(typeof(OrganisationType1Choice.Proprietary))]
    [JsonDerivedType(typeof(OrganisationType1Choice.Code), nameof(OrganisationType1Choice.Code))]
    [JsonDerivedType(
        typeof(OrganisationType1Choice.Proprietary),
        nameof(OrganisationType1Choice.Proprietary)
    )]
    [IsoId("_wpZ08CCeEeWJd9HF2tO7BA")]
    [DisplayName("Organisation Type 1 Choice")]
    public abstract record OrganisationType1Choice_ { }
}
