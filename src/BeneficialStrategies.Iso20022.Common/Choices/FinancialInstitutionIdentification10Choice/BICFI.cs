// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification10Choice
{
    /// <summary>
    /// Identification of the financial institution expressed as a BIC.
    /// </summary>
    [IsoId("_Rou1E2AZEeiH9-hkDDXUHA")]
    [DisplayName("BICFI")]
    public partial record BICFI : FinancialInstitutionIdentification10Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362: 2014 - &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoXmlTag("BICFI")]
        [IsoSimpleType(IsoSimpleType.BICFIDec2014Identifier)]
        public required IsoBICFIDec2014Identifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
