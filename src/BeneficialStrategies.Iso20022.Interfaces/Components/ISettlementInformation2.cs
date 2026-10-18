// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information required for the settlement the transaction.
/// </summary>
[IsoId("_QIhn5tp-Ed-ak6NoX_4Aeg_-1159158700")]
public interface ISettlementInformation2 : IIsoComponent
{
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_QIhn59p-Ed-ak6NoX_4Aeg_-1159158674")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    SettlementMethod2Code SettlementMethod { get; }

    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_QIhn6Np-Ed-ak6NoX_4Aeg_-1159158622")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    ICashAccount7? SettlementAccount { get; }

    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_QIhn6dp-Ed-ak6NoX_4Aeg_-1159158579")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    IClearingSystemIdentification1Choice? ClearingSystem { get; }
}
