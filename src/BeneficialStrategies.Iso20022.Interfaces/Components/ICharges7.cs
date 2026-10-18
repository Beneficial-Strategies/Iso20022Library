// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the charges related to the payment transaction.
/// </summary>
[IsoId("_-9uzLW49EeiU9cctagi5ow")]
public interface ICharges7 : IIsoComponent
{
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("__HkEk249EeiU9cctagi5ow")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    ActiveOrHistoricCurrencyAndAmount Amount { get; }

    /// <summary>
    /// Agent that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [IsoId("__HkElW49EeiU9cctagi5ow")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    IBranchAndFinancialInstitutionIdentification6 Agent { get; }
}
