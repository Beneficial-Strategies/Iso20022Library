// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TerminationDate5Choice
{
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5mw3r5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : TerminationDate5Choice_ { }
}
