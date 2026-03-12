// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SourceOfCash1Choice
{
    /// <summary>
    /// Source of cash expressed as a code.
    /// </summary>
    [IsoId("_otZG0DlEEealR6-8aQ15BA")]
    [DisplayName("Code")]
    public partial record Code : SourceOfCash1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the origin of cash.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SourceOfCash1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
