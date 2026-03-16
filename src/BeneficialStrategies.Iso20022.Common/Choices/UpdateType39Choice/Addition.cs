// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateType39Choice
{
    /// <summary>
    /// Addition.
    /// </summary>
    [DisplayName("Addition")]
    public record Addition : UpdateType39Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Addtn")]
        public required SecuritiesSettlementTransactionDetails56 Value { get; init; }
    }
}
