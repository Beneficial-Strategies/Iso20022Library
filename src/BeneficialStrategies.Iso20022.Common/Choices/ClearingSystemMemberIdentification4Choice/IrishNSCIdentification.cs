// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice
{
    /// <summary>
    /// Irish National Sorting Code - identifies Irish financial institutions on the Irish national clearing system. The code is assigned by the Irish Payments Services Organisation (IPSO).
    /// </summary>
    [IsoId("_VwSCZbNIEeejueAciesPMA")]
    [DisplayName("Irish NSC Identification")]
    public record IrishNSCIdentification : ClearingSystemMemberIdentification4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Irish National Sorting Code. Identifies Irish financial institutions on the Irish national clearing system.
        /// </summary>
        [IsoXmlTag("IENSC")]
        [IsoSimpleType(IsoSimpleType.IrishNSCIdentifier)]
        public required IsoIrishNSCIdentifier Value { get; init; }
    }
}
