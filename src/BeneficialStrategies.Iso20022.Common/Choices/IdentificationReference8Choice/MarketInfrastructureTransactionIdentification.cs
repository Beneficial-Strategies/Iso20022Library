// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference8Choice
{
    /// <summary>
    /// Unambiguous identification of the confirmation transaction as known by the market infrastructure.
    /// </summary>
    [IsoId("_AcF7lNokEeC60axPepSq7g_-1472748055")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    public record MarketInfrastructureTransactionIdentification : IdentificationReference8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("MktInfrstrctrTxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
