// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BeneficiaryType1Choice
{
    /// <summary>
    /// Type of beneficiary expressed as a code.
    /// </summary>
    [IsoId("_3a4XoFNgEeijdq8ilaxyOA")]
    [DisplayName("Code")]
    public partial record Code : BeneficiaryType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of beneficiary.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BeneficiaryType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
