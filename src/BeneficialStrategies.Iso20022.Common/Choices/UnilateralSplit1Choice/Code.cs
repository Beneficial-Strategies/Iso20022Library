// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnilateralSplit1Choice
{
    /// <summary>
    /// Unilateral split expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QtogGtp-Ed-ak6NoX_4Aeg_396862937")]
    [DisplayName("Code")]
    public record Code : UnilateralSplit1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies underlying information regarding the type of transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesTransactionType5Code Value { get; init; }
    }
}
