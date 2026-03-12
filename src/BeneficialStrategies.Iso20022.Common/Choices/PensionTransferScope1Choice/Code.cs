// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PensionTransferScope1Choice
{
    /// <summary>
    /// Type of pension policy, plan or scheme transfer scope expressed as a code.
    /// </summary>
    [IsoId("_X3xmkE4YEeiQHa-q1Uephw")]
    [DisplayName("Code")]
    public partial record Code : PensionTransferScope1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the scope of a pension transfer.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PensionTransferScope1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
