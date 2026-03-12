// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Derivative3Choice
{
    /// <summary>
    /// Details specific for emission allowance derivatives
    /// </summary>
    [IsoId("_xH-zbSe0Eei12pGEsJIAeQ")]
    [DisplayName("Emission Allowance")]
    public partial record EmissionAllowance : Derivative3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an mission allowance type.
        /// </summary>
        [IsoXmlTag("EmssnAllwnc")]
        public required EmissionAllowanceProductType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
