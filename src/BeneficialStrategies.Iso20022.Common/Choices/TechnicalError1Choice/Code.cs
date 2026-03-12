// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TechnicalError1Choice
{
    /// <summary>
    /// Reason for the technical error, as published in an external technical error code list.
    /// </summary>
    [IsoId("_pDbrZw3BEeWH49U6bkyMaA")]
    [DisplayName("Code")]
    public partial record Code : TechnicalError1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the technical error, as published in an external technical error code list.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalTechnicalError1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
