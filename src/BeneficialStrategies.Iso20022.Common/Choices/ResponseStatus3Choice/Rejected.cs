// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ResponseStatus3Choice
{
    /// <summary>
    /// The status of an instruction, advice or request.
    /// </summary>
    [IsoId("_0j-I4glIEeGATtfOBToyew_-1415910547")]
    [DisplayName("Rejected")]
    public record Rejected : ResponseStatus3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectionStatus7Choice_ Value { get; init; }
    }
}
