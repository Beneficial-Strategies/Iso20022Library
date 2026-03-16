// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Restriction1Choice
{
    /// <summary>
    /// Restrictions expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QvuKwNp-Ed-ak6NoX_4Aeg_2094501438")]
    [DisplayName("Code")]
    public record Code : Restriction1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regulatory restrictions applicable to a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OwnershipLegalRestrictions1Code Value { get; init; }
    }
}
