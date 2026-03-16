// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ServiceStatus1Choice
{
    /// <summary>
    /// Status, in a coded form.
    /// </summary>
    [IsoId("_Zzxz8vF6EemQ7oqCO5NTQw")]
    [DisplayName("Code")]
    public record Code : ServiceStatus1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a service request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ServiceRequestStatus1Code Value { get; init; }
    }
}
