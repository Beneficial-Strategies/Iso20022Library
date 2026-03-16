// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepairStatus5Choice
{
    /// <summary>
    /// Specifies the reason of the RepairStatus.
    /// </summary>
    [IsoId("_3e1lj_7qEeCvPoRGOxRobQ")]
    [DisplayName("Reason")]
    public record Reason : RepairStatus5Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected or repair status.
        /// </summary>
        [IsoId("_UYxVENp-Ed-ak6NoX_4Aeg_-1969426127")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RepairReason1Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UYxVEdp-Ed-ak6NoX_4Aeg_-1704556307")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
