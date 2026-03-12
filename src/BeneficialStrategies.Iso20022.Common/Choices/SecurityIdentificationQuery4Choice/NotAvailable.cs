// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentificationQuery4Choice
{
    /// <summary>
    /// Query for not available value (N/A).
    /// Usage: N/A means that value was not available at the time of the reporting.
    /// </summary>
    [IsoId("_PJPwpZNeEeytjZlcgApf6A")]
    [DisplayName("Not Available")]
    public partial record NotAvailable : SecurityIdentificationQuery4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a not available value code.
        /// </summary>
        [IsoXmlTag("NotAvlbl")]
        public required NotAvailable1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
