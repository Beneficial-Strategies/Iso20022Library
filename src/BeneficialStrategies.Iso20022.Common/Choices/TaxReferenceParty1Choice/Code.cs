// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxReferenceParty1Choice
{
    /// <summary>
    /// Type of party expressed as a code.
    /// </summary>
    [IsoId("_Holp4E4SEeiQHa-q1Uephw")]
    [DisplayName("Code")]
    public partial record Code : TaxReferenceParty1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of holder.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required HolderType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
