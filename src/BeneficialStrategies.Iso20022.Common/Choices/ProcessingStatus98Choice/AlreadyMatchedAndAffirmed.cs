// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus98Choice
{
    /// <summary>
    /// Trade is AlreadyMatchedAndAffirmed.
    /// </summary>
    [IsoId("_x4XDgwarEe2phaVG0lYKTw")]
    [DisplayName("Already Matched And Affirmed")]
    [IsoXmlTag("AlrdyMtchdAndAffrmd")]
    public record AlreadyMatchedAndAffirmed : ProcessingStatus98Choice_
    {
        /// <summary>
        /// Proprietary identification of the reason related to a status.
        /// </summary>
        [IsoId("_RA3_Uzp5EeWVrPy0StzzSg")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public GenericIdentification30? Reason { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_RA3_Wzp5EeWVrPy0StzzSg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
