// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the charges related to the payment transaction.
/// </summary>
[IsoId("_NfldERlWEe2Do_UtrNmb2g")]
public interface ICharges12 : IIsoComponent
{
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_NqTfUxlWEe2Do_UtrNmb2g")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    ActiveOrHistoricCurrencyAndAmount Amount { get; }

    /// <summary>
    /// Agent that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [IsoId("_NqTfVRlWEe2Do_UtrNmb2g")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    IBranchAndFinancialInstitutionIdentification6 Agent { get; }

    /// <summary>
    /// Defines the type of charges.
    /// </summary>
    [IsoId("_W6o64BlZEe2Do_UtrNmb2g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IChargeType3Choice? Type { get; }
}
