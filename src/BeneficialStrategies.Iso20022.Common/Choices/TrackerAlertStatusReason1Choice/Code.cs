// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TrackerAlertStatusReason1Choice
{
    /// <summary>
    /// Reason for the tracker alert status, as published in an external reason code list.
    /// </summary>
    [IsoId("_m4UaM879EemEIuVuDudp4g")]
    [DisplayName("Code")]
    public partial record Code : TrackerAlertStatusReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status reason for a tracker alert, as published in an external status reason code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalTrackerAlertStatusReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
