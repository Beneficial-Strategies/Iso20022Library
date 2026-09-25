// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CashAccountAuditTrailOrOperationalError4Choice
{
    /// <summary>
    /// Operational error resulting from a rejection.
    /// </summary>
    [IsoId("_9t1JA-VaEfC90e_m8fMznQ")]
    [DisplayName("Operational Error")]
    public record OperationalError : CashAccountAuditTrailOrOperationalError4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("OprlErr")]
        public required ErrorHandling5 Value { get; init; }
    }
}
