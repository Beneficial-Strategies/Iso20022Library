// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ConsolidationType1Choice
{
    /// <summary>
    /// Consolidation type expressed as a code.
    /// </summary>
    [IsoId("_QFc8kCDVEeWCLu74WLgP4w")]
    [DisplayName("Code")]
    public partial record Code : ConsolidationType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the consolidation type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ConsolidationType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
