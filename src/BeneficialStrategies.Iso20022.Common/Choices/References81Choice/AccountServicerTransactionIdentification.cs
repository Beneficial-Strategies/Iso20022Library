// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References81Choice
{
    /// <summary>
    /// Account Servicer Transaction Identification.
    /// </summary>
    [DisplayName("Account Servicer Transaction Identification")]
    public record AccountServicerTransactionIdentification : References81Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AcctSvcrTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
