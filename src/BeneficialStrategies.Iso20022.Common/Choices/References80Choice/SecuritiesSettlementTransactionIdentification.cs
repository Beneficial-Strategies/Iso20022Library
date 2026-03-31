// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References80Choice
{
    /// <summary>
    /// Securities Settlement Transaction Identification.
    /// </summary>
    [DisplayName("Securities Settlement Transaction Identification")]
    public record SecuritiesSettlementTransactionIdentification : References80Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("SctiesSttlmTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
