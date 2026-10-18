// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="IAuthorisation1Choice"/>
    [KnownType(typeof(Authorisation1Choice.Code))]
    [KnownType(typeof(Authorisation1Choice.Proprietary))]
    [JsonDerivedType(typeof(Authorisation1Choice.Code), nameof(Authorisation1Choice.Code))]
    [JsonDerivedType(
        typeof(Authorisation1Choice.Proprietary),
        nameof(Authorisation1Choice.Proprietary)
    )]
    [IsoId("_RD1Zltp-Ed-ak6NoX_4Aeg_-955120203")]
    [DisplayName("Authorisation 1 Choice")]
    public abstract partial record Authorisation1Choice_ { }
}
