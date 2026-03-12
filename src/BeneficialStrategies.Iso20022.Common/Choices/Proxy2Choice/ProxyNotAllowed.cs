// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Proxy2Choice
{
    /// <summary>
    /// Indicates that no proxy is allowed for a meeting.
    /// </summary>
    [IsoId("_7fsSg1tgEeSwKe7KuKvXhg")]
    [DisplayName("Proxy Not Allowed")]
    public partial record ProxyNotAllowed : Proxy2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates that the assignment of a proxy is not allowed for the meeting.
        /// </summary>
        [IsoXmlTag("PrxyNotAllwd")]
        public required ProxyNotAllowedCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
