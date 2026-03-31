// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References66Choice
{
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_MMl87_yjEeiM0vtizCHcoA")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    public record MarketInfrastructureTransactionIdentification : References66Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 16 characters. It has a pattern that disables the use of characters that is not part of the character set X, that is, that is not a-z A-Z / - ? : ( ) . , ‘ + , and disable the use of slash &quot;/&quot; at the beginning and end of line and double slash &quot;//&quot; within the line.
        /// </summary>
        [IsoXmlTag("MktInfrstrctrTxId")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
        [StringLength(maximumLength: 16, MinimumLength = 1)]
        public required IsoRestrictedFINXMax16Text Value { get; init; }
    }
}
