// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus4Choice
{
    /// <summary>
    /// Specifies the reason of the PendingProcessingStatus.
    /// </summary>
    [IsoId("_Sn750f7rEeCvPoRGOxRobQ")]
    [DisplayName("Reason")]
    public record Reason : PendingProcessingStatus4Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has a pending processing status.
        /// </summary>
        [IsoId("_UZXyA9p-Ed-ak6NoX_4Aeg_-1437386750")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required PendingProcessingReason1Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UZXyBNp-Ed-ak6NoX_4Aeg_-1889491046")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
