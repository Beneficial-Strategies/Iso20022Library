// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CertificationTypeFormat1Choice
{
    /// <summary>
    /// Standard code to specify the certification format required, that is, physical or electronic format.
    /// </summary>
    [IsoId("_Q3BFmNp-Ed-ak6NoX_4Aeg_-801680904")]
    [DisplayName("Code")]
    public partial record Code : CertificationTypeFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the certification format required, that is, physical or electronic format.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CertificationFormatType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
