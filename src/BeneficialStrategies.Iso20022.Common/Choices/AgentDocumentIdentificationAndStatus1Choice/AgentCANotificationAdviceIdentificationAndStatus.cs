// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AgentDocumentIdentificationAndStatus1Choice
{
    /// <summary>
    /// Agent CA Notification Advice Identification And Status.
    /// </summary>
    [DisplayName("Agent CA Notification Advice Identification And Status")]
    public partial record AgentCANotificationAdviceIdentificationAndStatus : AgentDocumentIdentificationAndStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AgtCANtfctnAdvcIdAndSts")]
        public required AgentNotificationIdentificationAndStatus1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
