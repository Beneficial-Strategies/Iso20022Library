// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice
{
    /// <summary>
    /// Hong Kong Bank Code - identifies Hong Kong financial institutions on the Hong Kong local clearing system.
    /// </summary>
    [IsoId("_VwSCgbNIEeejueAciesPMA")]
    [DisplayName("Hong Kong Bank Code")]
    public record HongKongBankCode : ClearingSystemMemberIdentification4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Hong Kong Bank Code. Identifies Hong Kong financial institutions on the Hong Kong local clearing system.
        /// </summary>
        [IsoXmlTag("HKNCC")]
        [IsoSimpleType(IsoSimpleType.HongKongBankIdentifier)]
        public required IsoHongKongBankIdentifier Value { get; init; }
    }
}
