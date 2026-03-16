// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus5Choice
{
    /// <summary>
    /// Indicates a duplicated case. |Usage: When present, the case identified in the message must be closed. The case identified as duplicated (in this component) will be pursued.
    /// </summary>
    [IsoId("_NRkhp249EeiU9cctagi5ow")]
    [DisplayName("Duplicate Of")]
    [IsoXmlTag("DplctOf")]
    public record DuplicateOf : InvestigationStatus5Choice_
    {
        /// <summary>
        /// Uniquely identifies the case.
        /// </summary>
        [IsoId("_8KfE4W48EeiU9cctagi5ow")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }

        /// <summary>
        /// Party that created the investigation case.
        /// </summary>
        [IsoId("_8KfE4248EeiU9cctagi5ow")]
        [DisplayName("Creator")]
        [IsoXmlTag("Cretr")]
        public required Party40Choice_ Creator { get; init; }

        /// <summary>
        /// Indicates whether or not the case was previously closed and is now re-opened.
        /// </summary>
        [IsoId("_8KfE5W48EeiU9cctagi5ow")]
        [DisplayName("Reopen Case Indication")]
        [IsoXmlTag("ReopCaseIndctn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? ReopenCaseIndication { get; init; }
    }
}
