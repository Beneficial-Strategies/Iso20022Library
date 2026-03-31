// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatementBasisCodeAndDSSCodeChoice
{
    /// <summary>
    /// Statement basis expressed as a code.
    /// </summary>
    [IsoId("_Q7Cp8dp-Ed-ak6NoX_4Aeg_-1663061250")]
    [DisplayName("Statement Basis As Code")]
    public record StatementBasisAsCode : StatementBasisCodeAndDSSCodeChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of balances on which the statement is prepared.
        /// </summary>
        [IsoXmlTag("StmtBsisAsCd")]
        public required StatementBasis1Code Value { get; init; }
    }
}
