// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reference3Choice
{
    /// <summary>
    /// Unique reference identifying the collateral management transaction from the client&apos;s point of view. Present in case of a decrease.
    /// </summary>
    [IsoId("_qTRyoQLyEeutW5-TpeYJhA")]
    [DisplayName("Client Collateral Transaction Identification")]
    public record ClientCollateralTransactionIdentification : Reference3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("ClntCollTxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
