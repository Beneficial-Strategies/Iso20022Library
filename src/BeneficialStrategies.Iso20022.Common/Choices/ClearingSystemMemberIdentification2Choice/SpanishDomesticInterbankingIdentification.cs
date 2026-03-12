// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Spanish Domestic Interbanking Code - identifies Spanish financial institutions on the Spanish national clearing system. The code is assigned by the Centro de Cooperacion Interbancaria (CCI).
    /// </summary>
    [IsoId("_TDF7k9p-Ed-ak6NoX_4Aeg_1990860804")]
    [DisplayName("Spanish Domestic Interbanking Identification")]
    public partial record SpanishDomesticInterbankingIdentification : ClearingSystemMemberIdentification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Spanish Domestic Interbanking Code. Identifies Spanish financial institutions on the Spanish national clearing system. The code is assigned by the Centro de Cooperacion Interbancaria (CCI).
        /// </summary>
        [IsoXmlTag("ESNCC")]
        [IsoSimpleType(IsoSimpleType.SpanishDomesticInterbankingIdentifier)]
        public required IsoSpanishDomesticInterbankingIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
