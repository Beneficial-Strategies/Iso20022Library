// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the charges related to the payment transaction.
/// </summary>
[IsoId("_x7KXQTEyEe6g-ffJsqGiSA")]
public interface ICharges16 : IIsoComponent
{
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    ActiveOrHistoricCurrencyAndAmount Amount { get; }

    /// <summary>
    /// Agent that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    IBranchAndFinancialInstitutionIdentification8 Agent { get; }

    /// <summary>
    /// Defines the type of charges.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IChargeType3Choice? Type { get; }
}
