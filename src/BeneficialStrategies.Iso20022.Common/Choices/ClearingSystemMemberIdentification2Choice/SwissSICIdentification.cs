// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Swiss Interbank Clearing (SIC) Code - identifies Swiss financial institutions domestically, on the Swiss national clearing system.
    /// </summary>
    [IsoId("_TDF7kdp-Ed-ak6NoX_4Aeg_1989940383")]
    [DisplayName("Swiss SIC Identification")]
    public record SwissSICIdentification : ClearingSystemMemberIdentification2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Swiss Interbank Clearing (SIC) Code. Identifies Swiss financial institutions domestically, on the Swiss national clearing system.
        /// </summary>
        [IsoXmlTag("CHSIC")]
        [IsoSimpleType(IsoSimpleType.SwissSICIdentifier)]
        public required IsoSwissSICIdentifier Value { get; init; }
    }
}
