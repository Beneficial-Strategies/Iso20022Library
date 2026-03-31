// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent35Choice
{
    /// <summary>
    /// Securities Transaction Type.
    /// </summary>
    [DisplayName("Securities Transaction Type")]
    public record SecuritiesTransactionType : SettlementOrCorporateActionEvent35Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("SctiesTxTp")]
        public required SecuritiesTransactionType48Choice_ Value { get; init; }
    }
}
