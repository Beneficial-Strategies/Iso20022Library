// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FailingStatus1Choice
{
    /// <summary>
    /// Specifies the reason of the FailingStatus.
    /// </summary>
    [IsoId("_UZqs-Np-Ed-ak6NoX_4Aeg_-1241584020")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : FailingStatus1Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has a failing status.
        /// </summary>
        [IsoId("_UZqs9Np-Ed-ak6NoX_4Aeg_686367356")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required FailingReason1Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UZqs9dp-Ed-ak6NoX_4Aeg_-604818080")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
