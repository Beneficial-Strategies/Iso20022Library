// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RegistrationProcessingStatus1Choice
{
    /// <summary>
    /// Provides the status of the registration processing.
    /// </summary>
    [IsoId("_UYUpItp-Ed-ak6NoX_4Aeg_170456912")]
    [DisplayName("Code")]
    public partial record Code : RegistrationProcessingStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the registration processing.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RegistrationProcessingStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
