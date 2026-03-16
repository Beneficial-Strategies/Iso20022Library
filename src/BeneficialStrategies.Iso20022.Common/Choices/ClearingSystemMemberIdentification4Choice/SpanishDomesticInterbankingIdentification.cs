// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice
{
    /// <summary>
    /// Spanish Domestic Interbanking Code - identifies Spanish financial institutions on the Spanish national clearing system. The code is assigned by the Centro de Cooperacion Interbancaria (CCI).
    /// </summary>
    [IsoId("_VwSCfbNIEeejueAciesPMA")]
    [DisplayName("Spanish Domestic Interbanking Identification")]
    public record SpanishDomesticInterbankingIdentification
        : ClearingSystemMemberIdentification4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Spanish Domestic Interbanking Code. Identifies Spanish financial institutions on the Spanish national clearing system. The code is assigned by the Centro de Cooperacion Interbancaria (CCI).
        /// </summary>
        [IsoXmlTag("ESNCC")]
        [IsoSimpleType(IsoSimpleType.SpanishDomesticInterbankingIdentifier)]
        public required IsoSpanishDomesticInterbankingIdentifier Value { get; init; }
    }
}
