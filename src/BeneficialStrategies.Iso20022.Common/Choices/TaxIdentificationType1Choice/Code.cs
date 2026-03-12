// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxIdentificationType1Choice
{
    /// <summary>
    /// Type of tax identification number or identifier expressed as a code.
    /// </summary>
    [IsoId("_4itmAAhIEeSUPbC7DbLJpQ")]
    [DisplayName("Code")]
    public partial record Code : TaxIdentificationType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of tax identification number.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxIdentificationNumberType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
