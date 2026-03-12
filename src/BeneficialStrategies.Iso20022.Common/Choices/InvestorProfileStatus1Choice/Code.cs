// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestorProfileStatus1Choice
{
    /// <summary>
    /// Investor profile status expressed as a code.
    /// </summary>
    [IsoId("_u1EvwCDOEeWPMvNwVtiMsA")]
    [DisplayName("Code")]
    public partial record Code : InvestorProfileStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the investor profile.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestorProfileStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
