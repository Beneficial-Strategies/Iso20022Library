// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Purpose1Choice
{
    /// <summary>
    /// Specifies the underlying reason for the payment transaction, as published in an external purpose code list.
    /// </summary>
    [IsoId("_PrK9gdp-Ed-ak6NoX_4Aeg_-607853940")]
    [DisplayName("Code")]
    public partial record Code : Purpose1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external purpose code in the format of character string with a maximum length of 35 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalPurposeCode_Obsolete Value { get; init; } 
        
        
        #nullable disable
        
    }
}
