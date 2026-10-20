// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport12Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_bQpIgxLBEeqctpBfTmLJnw")]
    [DisplayName("Transaction")]
    public partial record Transaction : TradeReport12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Tx")]
        public required TradeTransactionReport8Choice_ Value { get; init; }
    }
}
