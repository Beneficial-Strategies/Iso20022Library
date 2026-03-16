// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentificationChoice
{
    /// <summary>
    /// Swiss Bank Code - identifies Swiss institutions on the Swiss national clearing system.
    /// </summary>
    [IsoId("_TDY2g9p-Ed-ak6NoX_4Aeg_-896562601")]
    [DisplayName("Swiss BC Identification")]
    public record SwissBCIdentification : ClearingSystemMemberIdentificationChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Swiss Bank Code. Identifies Swiss institutions on the Swiss national clearing system.
        /// </summary>
        [IsoXmlTag("CHBC")]
        [IsoSimpleType(IsoSimpleType.SwissBCIdentifier)]
        public required IsoSwissBCIdentifier Value { get; init; }
    }
}
