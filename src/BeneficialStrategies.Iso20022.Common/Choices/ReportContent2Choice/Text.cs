// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReportContent2Choice
{
    /// <summary>
    /// Text.
    /// </summary>
    [DisplayName("Text")]
    public partial record Text : ReportContent2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Txt")]
        public required IsoMax10MbText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
