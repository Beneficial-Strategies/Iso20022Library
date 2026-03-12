// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ModificationReason4Choice
{
    /// <summary>
    /// Specifies the reason why the related instruction is modified, or the related modification request is executed.
    /// </summary>
    [IsoId("_D8v4gTq3EeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public partial record Code : ModificationReason4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that the transaction has been modified.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ModifiedStatusReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
