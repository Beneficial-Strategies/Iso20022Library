// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason1Choice
{
    /// <summary>
    /// Rejection reason that applies to the whole report.
    /// </summary>
    [IsoId("_RJ8oodp-Ed-ak6NoX_4Aeg_1042217735")]
    [DisplayName("Global Rejection Reason")]
    public record GlobalRejectionReason : RejectionReason1Choice_
    {
        /// <summary>
        /// Detailed description of the rejection.
        /// </summary>
        [IsoId("_RJ8opNp-Ed-ak6NoX_4Aeg_987008657")]
        [DisplayName("Description")]
        [IsoXmlTag("Desc")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public required IsoMax140Text Description { get; init; }
    }
}
