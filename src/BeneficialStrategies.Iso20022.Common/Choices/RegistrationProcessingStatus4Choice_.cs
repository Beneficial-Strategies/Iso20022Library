// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the registration processing status.
    /// </summary>
    [KnownType(typeof(RegistrationProcessingStatus4Choice.Code))]
    [KnownType(typeof(RegistrationProcessingStatus4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RegistrationProcessingStatus4Choice.Code),
        nameof(RegistrationProcessingStatus4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RegistrationProcessingStatus4Choice.Proprietary),
        nameof(RegistrationProcessingStatus4Choice.Proprietary)
    )]
    [IsoId("_8QcPIZNLEeWGlc8L7oPDIg")]
    [DisplayName("Registration Processing Status 4 Choice")]
    public abstract record RegistrationProcessingStatus4Choice_ { }
}
