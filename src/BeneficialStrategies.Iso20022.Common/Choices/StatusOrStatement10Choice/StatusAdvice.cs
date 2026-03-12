// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement10Choice
{
    /// <summary>
    /// Identifies the status advice and the transaction for which the status advice was requested.
    /// </summary>
    [IsoId("_LSk42_fZEeiNZp_PtLohLw")]
    [DisplayName("Status Advice")]
    public partial record StatusAdvice : StatusOrStatement10Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_LSk45_fZEeiNZp_PtLohLw")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        public required DocumentNumber6Choice_ Number { get; init; } 
        
        /// <summary>
        /// References of transaction for which the status is requested.
        /// </summary>
        [IsoId("_LSk47_fZEeiNZp_PtLohLw")]
        [DisplayName("References")]
        [IsoXmlTag("Refs")]
        public ValueList<Identification27> References { get; init; } = new ValueList<Identification27>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _LSk47_fZEeiNZp_PtLohLw
        
        
        #nullable disable
        
    }
}
