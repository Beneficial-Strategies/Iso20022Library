// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References74Choice
{
    /// <inheritdoc cref="IAccountServicerTransactionIdentification"/>
    [IsoId("_SiFNiSgaEey2k_sfZmJz4g")]
    [DisplayName("Account Servicer Transaction Identification")]
    public partial record AccountServicerTransactionIdentification : References74Choice_
    {
        /// <inheritdoc cref="IAccountServicerTransactionIdentification.Value"/>
        [IsoXmlTag("AcctSvcrTxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
