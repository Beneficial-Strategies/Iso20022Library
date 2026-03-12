// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the registration processing status.
    /// </summary>
    [KnownType(typeof(RegistrationProcessingStatus3Choice.Code))]
    [KnownType(typeof(RegistrationProcessingStatus3Choice.Proprietary))]
    [JsonDerivedType(typeof(RegistrationProcessingStatus3Choice.Code),nameof(RegistrationProcessingStatus3Choice.Code))]
    [JsonDerivedType(typeof(RegistrationProcessingStatus3Choice.Proprietary),nameof(RegistrationProcessingStatus3Choice.Proprietary))]
    [IsoId("_gC8aETqqEeWyoP0PbocV1Q")]
    [DisplayName("Registration Processing Status 3 Choice")]
    public abstract partial record RegistrationProcessingStatus3Choice_
    {
    }
}
