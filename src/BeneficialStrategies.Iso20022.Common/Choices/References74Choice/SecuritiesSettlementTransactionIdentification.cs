// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References74Choice
{
    /// <summary>
    /// Unambiguous identification of a securities settlement transaction as known by the account owner (or instructing party acting on its behalf).
    /// </summary>
    [IsoId("_SiFNgygaEey2k_sfZmJz4g")]
    [DisplayName("Securities Settlement Transaction Identification")]
    public record SecuritiesSettlementTransactionIdentification : References74Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("SctiesSttlmTxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
