// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent13Choice
{
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_2TcSYTqDEeWVrPy0StzzSg")]
    [DisplayName("Securities Transaction Type")]
    public partial record SecuritiesTransactionType : SettlementOrCorporateActionEvent13Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("SctiesTxTp")]
        public required SecuritiesTransactionType18Choice_ Value { get; init; }
    }
}
