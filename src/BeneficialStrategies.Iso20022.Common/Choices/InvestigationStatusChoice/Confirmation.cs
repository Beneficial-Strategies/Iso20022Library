// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatusChoice
{
    /// <summary>
    /// Indicates the status of an investigation.
    /// </summary>
    [IsoId("_UuYYs9p-Ed-ak6NoX_4Aeg_-1918327936")]
    [DisplayName("Confirmation")]
    public partial record Confirmation : InvestigationStatusChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the result of an investigation.
        /// </summary>
        [IsoXmlTag("Conf")]
        public required InvestigationExecutionConfirmation1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
