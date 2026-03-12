// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ServiceStatus1Choice
{
    /// <summary>
    /// Status, in a coded form.
    /// </summary>
    [IsoId("_Zzxz8vF6EemQ7oqCO5NTQw")]
    [DisplayName("Code")]
    public partial record Code : ServiceStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a service request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ServiceRequestStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
