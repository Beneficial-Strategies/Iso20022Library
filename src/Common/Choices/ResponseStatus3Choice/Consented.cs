// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ResponseStatus3Choice
{
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    [IsoId("_0j-I4QlIEeGATtfOBToyew_1001538604")]
    [DisplayName("Consented")]
    public partial record Consented : ResponseStatus3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cnsntd")]
        public required ConsentStatus2Choice_ Value { get; init; }
    }
}
