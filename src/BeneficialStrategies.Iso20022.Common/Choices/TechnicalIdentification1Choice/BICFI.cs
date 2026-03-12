// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TechnicalIdentification1Choice
{
    /// <summary>
    /// Technical address of the party is defined as a financial institution business identifier code.
    /// </summary>
    [IsoId("_kpLGoO5NEeCisYr99QEiWA_531980910")]
    [DisplayName("BICFI")]
    public partial record BICFI : TechnicalIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoXmlTag("BICFI")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        public required IsoBICFIIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
