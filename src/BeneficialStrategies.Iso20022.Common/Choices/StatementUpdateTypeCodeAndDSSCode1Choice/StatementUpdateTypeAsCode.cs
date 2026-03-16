// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatementUpdateTypeCodeAndDSSCode1Choice
{
    /// <summary>
    /// Update type expressed as a code.
    /// </summary>
    [IsoId("_sXPbwQaUEe2-DuDrUXkg2w")]
    [DisplayName("Statement Update Type As Code")]
    public record StatementUpdateTypeAsCode : StatementUpdateTypeCodeAndDSSCode1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of a statement update, for example, it is a complete statement.
        /// </summary>
        [IsoXmlTag("StmtUpdTpAsCd")]
        public required StatementUpdateType1Code Value { get; init; }
    }
}
