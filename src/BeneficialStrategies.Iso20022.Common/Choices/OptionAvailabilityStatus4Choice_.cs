// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the option availability status.
    /// </summary>
    [KnownType(typeof(OptionAvailabilityStatus4Choice.Code))]
    [KnownType(typeof(OptionAvailabilityStatus4Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionAvailabilityStatus4Choice.Code),nameof(OptionAvailabilityStatus4Choice.Code))]
    [JsonDerivedType(typeof(OptionAvailabilityStatus4Choice.Proprietary),nameof(OptionAvailabilityStatus4Choice.Proprietary))]
    [IsoId("_cta-K5KQEeWHWpTQn1FFVg")]
    [DisplayName("Option Availability Status 4 Choice")]
    public abstract partial record OptionAvailabilityStatus4Choice_
    {
    }
}
