// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TimeFrame6Choice
{
    /// <summary>
    /// Time frame expressed as a code.
    /// </summary>
    [IsoId("_-0Bz8DcbEeidBoT_PugKiA")]
    [DisplayName("Code")]
    public partial record Code : TimeFrame6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a time frame.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TimeFrame1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
