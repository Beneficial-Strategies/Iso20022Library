// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TrackerAlertStatus1Choice
{
    /// <summary>
    /// Status of the tracker alert, as published in an external code set.
    /// </summary>
    [IsoId("_M7UA5vWlEemtd4wHZYvFUQ")]
    [DisplayName("Code")]
    public partial record Code : TrackerAlertStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of an tracker alert, as published in an external tracker alert code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalTrackertAlertStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
