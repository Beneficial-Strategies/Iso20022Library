// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement11Choice
{
    /// <summary>
    /// Identifies the status advice and the transaction for which the status advice was requested.
    /// </summary>
    [IsoId("_4yyB8ygSEeym1_Zp1BTvEw")]
    [DisplayName("Status Advice")]
    public partial record StatusAdvice : StatusOrStatement11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_5I1KdSgSEeym1_Zp1BTvEw")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        public required DocumentNumber5Choice_ Number { get; init; } 
        
        /// <summary>
        /// References of transaction for which the status is requested.
        /// </summary>
        [IsoId("_5I1KfSgSEeym1_Zp1BTvEw")]
        [DisplayName("References")]
        [IsoXmlTag("Refs")]
        public ValueList<Identification28> References { get; init; } = [];
        // ID for the above is _5I1KfSgSEeym1_Zp1BTvEw
        
        
        #nullable disable
        
    }
}
