// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the status of a politically exposed person.
    /// </summary>
    [KnownType(typeof(PoliticallyExposedPersonStatus1Choice.Code))]
    [KnownType(typeof(PoliticallyExposedPersonStatus1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PoliticallyExposedPersonStatus1Choice.Code),
        nameof(PoliticallyExposedPersonStatus1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PoliticallyExposedPersonStatus1Choice.Proprietary),
        nameof(PoliticallyExposedPersonStatus1Choice.Proprietary)
    )]
    [IsoId("_Y1YIAJUiEemC09f0MxYkRg")]
    [DisplayName("Politically Exposed Person Status 1 Choice")]
    public abstract record PoliticallyExposedPersonStatus1Choice_ { }
}
