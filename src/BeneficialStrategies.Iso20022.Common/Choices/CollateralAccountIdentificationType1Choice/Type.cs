// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralAccountIdentificationType1Choice
{
    /// <summary>
    /// Indicates the Type of Collateral Account expressed as a code.
    /// </summary>
    [IsoId("_vW0gOKMOEeCojJW5vEuTEQ_-102415350")]
    [DisplayName("Type")]
    public partial record Type : CollateralAccountIdentificationType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the collateral account type.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required CollateralAccountType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
