// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SupportLetterType1Choice
{
    /// <summary>
    /// Type of supporting letter expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Hk37ILbyEeu9Cp6InX88Vw")]
    [DisplayName("Code")]
    public partial record Code : SupportLetterType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the letter type as published in an external letter type code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalLetterType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
