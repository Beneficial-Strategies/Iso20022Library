// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Charges5Choice
{
    /// <summary>
    /// Per Type.
    /// </summary>
    [DisplayName("Per Type")]
    public partial record PerType : Charges5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PerTp")]
        public required ChargesPerType5 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
