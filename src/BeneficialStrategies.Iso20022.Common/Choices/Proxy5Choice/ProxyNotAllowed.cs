// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Proxy5Choice
{
    /// <summary>
    /// Indicates that no proxy is allowed for a meeting.
    /// </summary>
    [IsoId("_iTU-wxrfEeyhRdHRjakS2w")]
    [DisplayName("Proxy Not Allowed")]
    public record ProxyNotAllowed : Proxy5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates that the assignment of a proxy is not allowed for the meeting.
        /// </summary>
        [IsoXmlTag("PrxyNotAllwd")]
        public required ProxyNotAllowed1Code Value { get; init; }
    }
}
