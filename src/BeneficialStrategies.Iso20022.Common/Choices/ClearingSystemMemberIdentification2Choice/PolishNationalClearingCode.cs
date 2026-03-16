// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Polish National Clearing Code - identifies Polish financial institutions on the Polish national clearing system.
    /// </summary>
    [IsoId("_TDPFhNp-Ed-ak6NoX_4Aeg_-1877438256")]
    [DisplayName("Polish National Clearing Code")]
    public record PolishNationalClearingCode : ClearingSystemMemberIdentification2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Polish National Clearing Code Identifier. Identifies Polish financial institutions on the Polish national clearing system.
        /// </summary>
        [IsoXmlTag("PLKNR")]
        [IsoSimpleType(IsoSimpleType.PolishNationalClearingCodeIdentifier)]
        public required IsoPolishNationalClearingCodeIdentifier Value { get; init; }
    }
}
