// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationDataRecord7Choice
{
    /// <summary>
    /// Confirmation.
    /// </summary>
    [DisplayName("Confirmation")]
    public partial record Confirmation : InvestigationDataRecord7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Conf")]
        public required BookingConfirmation5 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
