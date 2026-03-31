// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the registration processing status.
    /// </summary>
    [KnownType(typeof(RegistrationProcessingStatus1Choice.Code))]
    [KnownType(typeof(RegistrationProcessingStatus1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RegistrationProcessingStatus1Choice.Code),
        nameof(RegistrationProcessingStatus1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RegistrationProcessingStatus1Choice.Proprietary),
        nameof(RegistrationProcessingStatus1Choice.Proprietary)
    )]
    [IsoId("_UYUpIdp-Ed-ak6NoX_4Aeg_170456881")]
    [DisplayName("Registration Processing Status 1 Choice")]
    public abstract record RegistrationProcessingStatus1Choice_ { }
}
