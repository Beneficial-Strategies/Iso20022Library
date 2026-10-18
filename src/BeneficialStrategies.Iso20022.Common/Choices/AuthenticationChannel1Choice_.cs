// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="IAuthenticationChannel1Choice"/>
    [KnownType(typeof(AuthenticationChannel1Choice.Code))]
    [KnownType(typeof(AuthenticationChannel1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AuthenticationChannel1Choice.Code),
        nameof(AuthenticationChannel1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AuthenticationChannel1Choice.Proprietary),
        nameof(AuthenticationChannel1Choice.Proprietary)
    )]
    [IsoId("_U4Y945dgEea1K6JAcAwoVg")]
    [DisplayName("Authentication Channel 1 Choice")]
    public abstract partial record AuthenticationChannel1Choice_ { }
}
