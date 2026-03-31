// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChequeDeliveryMethod1Choice
{
    /// <summary>
    /// Specifies a proprietary delivery method of the cheque by the debtor&apos;s agent.
    /// </summary>
    [IsoId("_QbwF6Np-Ed-ak6NoX_4Aeg_1076475245")]
    [DisplayName("Proprietary")]
    public record Proprietary : ChequeDeliveryMethod1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
