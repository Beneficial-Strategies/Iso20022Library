// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat12Choice
{
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    [IsoId("_KUd0ARuyEeyhRdHRjakS2w")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public record Balance : BalanceFormat12Choice_
    {
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_JrCcgRuyEeyhRdHRjakS2w")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public required ShortLong1Code ShortLongPosition { get; init; }

        /// <summary>
        /// Choice between different quantity of security formats.
        /// </summary>
        [IsoId("_JrCcgxuyEeyhRdHRjakS2w")]
        [DisplayName("Quantity Choice")]
        [IsoXmlTag("QtyChc")]
        public required Quantity48Choice_ QuantityChoice { get; init; }
    }
}
