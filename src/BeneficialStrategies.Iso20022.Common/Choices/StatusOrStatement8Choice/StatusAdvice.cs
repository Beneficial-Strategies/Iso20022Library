// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement8Choice
{
    /// <summary>
    /// Identify the status advice and the transaction for which the status advice was requested.
    /// </summary>
    [IsoId("_8Rszh5NLEeWGlc8L7oPDIg")]
    [DisplayName("Status Advice")]
    public partial record StatusAdvice : StatusOrStatement8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_8RszkZNLEeWGlc8L7oPDIg")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        public required DocumentNumber6Choice_ Number { get; init; } 
        
        /// <summary>
        /// References of transaction for which the status is requested.
        /// </summary>
        [IsoId("_8RszmZNLEeWGlc8L7oPDIg")]
        [DisplayName("References")]
        [IsoXmlTag("Refs")]
        public ValueList<Identification24> References { get; init; } = [];
        // ID for the above is _8RszmZNLEeWGlc8L7oPDIg
        
        
        #nullable disable
        
    }
}
