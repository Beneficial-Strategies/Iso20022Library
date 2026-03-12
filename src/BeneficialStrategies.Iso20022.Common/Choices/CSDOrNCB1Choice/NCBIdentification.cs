// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CSDOrNCB1Choice
{
    /// <summary>
    /// Unique identification to unambiguously identify the national central bank within the system.
    /// </summary>
    [IsoId("_knY98u5NEeCisYr99QEiWA_251909135")]
    [DisplayName("NCB Identification")]
    public partial record NCBIdentification : CSDOrNCB1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoXmlTag("NCBId")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        public required IsoBICFIIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
