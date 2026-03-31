// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the financial instruments details or the business error.
    /// </summary>
    [KnownType(typeof(SecurityOrBusinessError4Choice.SecurityReport))]
    [KnownType(typeof(SecurityOrBusinessError4Choice.BusinessError))]
    [JsonDerivedType(
        typeof(SecurityOrBusinessError4Choice.SecurityReport),
        nameof(SecurityOrBusinessError4Choice.SecurityReport)
    )]
    [JsonDerivedType(
        typeof(SecurityOrBusinessError4Choice.BusinessError),
        nameof(SecurityOrBusinessError4Choice.BusinessError)
    )]
    [IsoId("_P5yGtZJKEeuAlLVx8pyt3w")]
    [DisplayName("Security Or Business Error 4 Choice")]
    public abstract record SecurityOrBusinessError4Choice_ { }
}
