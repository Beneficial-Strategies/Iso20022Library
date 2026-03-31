// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedReason7Choice
{
    /// <summary>
    /// Reason for the accepted status expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_PFE48FjzEeOnqqBHs8Gasw")]
    [DisplayName("Code")]
    public record Code : AcceptedReason7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for an accepted status.|
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalAcceptedReason1Code Value { get; init; }
    }
}
