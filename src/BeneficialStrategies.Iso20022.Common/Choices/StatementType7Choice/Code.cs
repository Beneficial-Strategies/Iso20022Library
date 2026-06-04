// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.StatementType7Choice
{
    /// <summary>Statement type expressed as a code.</summary>
    [IsoId("_wH_JxQJ3EfGAP_FOfstLIw")]
    [DisplayName("Code")]
    public record Code : StatementType7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required ExternalSecuritiesStatementType1Code Value { get; init; }
    }
}
