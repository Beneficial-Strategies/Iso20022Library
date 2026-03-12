// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CSDOrNCB1Choice
{
    /// <summary>
    /// Unique identification to unambiguously identify the central security depository within the system.
    /// </summary>
    [IsoId("_knY98e5NEeCisYr99QEiWA_-890401422")]
    [DisplayName("CSD Identification")]
    public partial record CSDIdentification : CSDOrNCB1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoXmlTag("CSDId")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        public required IsoBICFIIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
