// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus2Choice
{
    /// <summary>
    /// Specifies the status of the investigation, in a coded form.
    /// </summary>
    [IsoId("_T-P8Rdp-Ed-ak6NoX_4Aeg_523812421")]
    [DisplayName("Confirmation")]
    public partial record Confirmation : InvestigationStatus2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the result of an investigation.
        /// </summary>
        [IsoXmlTag("Conf")]
        public required InvestigationExecutionConfirmation3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
