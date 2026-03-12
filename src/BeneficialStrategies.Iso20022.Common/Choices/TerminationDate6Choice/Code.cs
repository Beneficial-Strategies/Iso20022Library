// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TerminationDate6Choice
{
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_hUd9b7PvEeelzbgsFa3sqQ")]
    [DisplayName("Code")]
    public partial record Code : TerminationDate6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
