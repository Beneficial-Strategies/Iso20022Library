// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement5Choice
{
    /// <summary>
    /// Identify the status advice and the transaction for which the status advice was requested.
    /// </summary>
    [IsoId("_BTOMif7yEeCvPoRGOxRobQ")]
    [DisplayName("Status Advice")]
    public partial record StatusAdvice : StatusOrStatement5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_BTOMnf7yEeCvPoRGOxRobQ")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        public required DocumentNumber1Choice_ Number { get; init; } 
        
        /// <summary>
        /// References of transaction for which the status is requested.
        /// </summary>
        [IsoId("_BTOMp_7yEeCvPoRGOxRobQ")]
        [DisplayName("References")]
        [IsoXmlTag("Refs")]
        public ValueList<Identification11> References { get; init; } = new ValueList<Identification11>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _BTOMp_7yEeCvPoRGOxRobQ
        
        
        #nullable disable
        
    }
}
