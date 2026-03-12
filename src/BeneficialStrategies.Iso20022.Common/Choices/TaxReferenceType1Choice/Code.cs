// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxReferenceType1Choice
{
    /// <summary>
    /// Type of tax reference expressed as a code.
    /// </summary>
    [IsoId("_SaQSIE4REeiQHa-q1Uephw")]
    [DisplayName("Code")]
    public partial record Code : TaxReferenceType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of tax reference.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PersonIdentificationType7Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
