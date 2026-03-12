// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus1FormatChoice
{
    /// <summary>
    /// Standard code to specify the processing status.
    /// </summary>
    [IsoId("_Rnv-9Np-Ed-ak6NoX_4Aeg_-1777014631")]
    [DisplayName("Code")]
    public partial record Code : ProcessingStatus1FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the processing status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessingStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
