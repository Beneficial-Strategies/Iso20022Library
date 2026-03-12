// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the option availability status.
    /// </summary>
    [KnownType(typeof(OptionAvailabilityStatus1Choice.Code))]
    [KnownType(typeof(OptionAvailabilityStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionAvailabilityStatus1Choice.Code),nameof(OptionAvailabilityStatus1Choice.Code))]
    [JsonDerivedType(typeof(OptionAvailabilityStatus1Choice.Proprietary),nameof(OptionAvailabilityStatus1Choice.Proprietary))]
    [IsoId("_Q0CqG9p-Ed-ak6NoX_4Aeg_-885794787")]
    [DisplayName("Option Availability Status 1 Choice")]
    public abstract partial record OptionAvailabilityStatus1Choice_
    {
    }
}
