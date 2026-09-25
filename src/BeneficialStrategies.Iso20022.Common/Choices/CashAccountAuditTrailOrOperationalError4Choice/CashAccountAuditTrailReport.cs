// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CashAccountAuditTrailOrOperationalError4Choice
{
    /// <summary>
    /// Report information about cash account reference data.
    /// </summary>
    [IsoId("_9t1JAeVaEfC90e_m8fMznQ")]
    [DisplayName("Cash Account Audit Trail Report")]
    public record CashAccountAuditTrailReport : CashAccountAuditTrailOrOperationalError4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CshAcctAudtTrlRpt")]
        public required CashAccountAuditTrailReport4 Value { get; init; }
    }
}
