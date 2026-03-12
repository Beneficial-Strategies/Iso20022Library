// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GDPRDataConsent1Choice
{
    /// <summary>
    /// Consent type expressed as a code.
    /// </summary>
    [IsoId("_LyNlkJTTEemC09f0MxYkRg")]
    [DisplayName("Code")]
    public partial record Code : GDPRDataConsent1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Consent type in the context of the General Protection Regulation (GDPR) 2016/679 regulation.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required GDPRDataConsent1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
