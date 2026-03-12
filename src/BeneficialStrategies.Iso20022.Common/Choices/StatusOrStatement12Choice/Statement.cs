// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement12Choice
{
    /// <summary>
    /// Identifies the statement/report that was requested.
    /// </summary>
    [IsoId("_gBH0Ezi8Eeydid5dcNPKvg")]
    [DisplayName("Statement")]
    public partial record Statement : StatusOrStatement12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_8QbApZNLEeWGlc8L7oPDIg")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        public required DocumentNumber6Choice_ Number { get; init; } 
        
        
        #nullable disable
        
    }
}
