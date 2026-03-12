// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AgreementType2Choice
{
    /// <summary>
    /// Name of the identification scheme, in a coded form as published in an external list.
    /// </summary>
    [IsoId("_OI9M0S4yEeuxhbw_aW6haw")]
    [DisplayName("Type")]
    public partial record Type : AgreementType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Name of the identification scheme, in a coded form as published in an external list.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required ExternalAgreementType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
