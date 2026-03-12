// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TerminationDate5Choice
{
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5mw3r5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public partial record Code : TerminationDate5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
