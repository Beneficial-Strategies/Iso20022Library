// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the option availability status.
    /// </summary>
    [KnownType(typeof(OptionAvailabilityStatus3Choice.Code))]
    [KnownType(typeof(OptionAvailabilityStatus3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OptionAvailabilityStatus3Choice.Code),
        nameof(OptionAvailabilityStatus3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OptionAvailabilityStatus3Choice.Proprietary),
        nameof(OptionAvailabilityStatus3Choice.Proprietary)
    )]
    [IsoId("_s1X2gUEHEeWVgfuHGaKtRQ")]
    [DisplayName("Option Availability Status 3 Choice")]
    public abstract record OptionAvailabilityStatus3Choice_ { }
}
