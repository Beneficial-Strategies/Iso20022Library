// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal transaction for which an authorisation is requested.
/// </summary>
[IsoId("_EW968IohEeSirOZJBRz_nA")]
[DisplayName("ATM Transaction")]
public record ATMTransaction1
{
    /// <summary>
    /// True if cash has to be dispensed by the ATM for the transaction.
    /// </summary>
    [IsoId("_SWaRUIohEeSirOZJBRz_nA")]
    [DisplayName("Cash Dispensed")]
    [IsoXmlTag("CshDspnsd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CashDispensed { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_dPQqMIohEeSirOZJBRz_nA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_6bDO8IohEeSaAcF2oE2GNQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Unprotected account information.
    /// </summary>
    [IsoId("_LSftMIoiEeSaAcF2oE2GNQ")]
    [DisplayName("Account Data")]
    [IsoXmlTag("AcctData")]
    public CardAccount3? AccountData { get; init; }

    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_4WS3AIojEeSaAcF2oE2GNQ")]
    [DisplayName("Protected Account Data")]
    [IsoXmlTag("PrtctdAcctData")]
    public ContentInformationType10? ProtectedAccountData { get; init; }

    /// <summary>
    /// Amount to be authorised by the issuer.
    /// </summary>
    [IsoId("_vexx0IolEeSaAcF2oE2GNQ")]
    [DisplayName("Total Requested Amount")]
    [IsoXmlTag("TtlReqdAmt")]
    public AmountAndCurrency1? TotalRequestedAmount { get; init; }

    /// <summary>
    /// Amounts of the withdrawal transaction.
    /// </summary>
    [IsoId("_rBlDMIokEeSaAcF2oE2GNQ")]
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public DetailedAmount12? DetailedRequestedAmount { get; init; }

    /// <summary>
    /// Currency conversion accepted by the customer, either to convert the amount to dispense in the base currency of the ATM, or to convert the total requested amount in the currency of the customer (so called dynamic currency conversion).
    /// </summary>
    [IsoId("_QMSJ0IomEeSaAcF2oE2GNQ")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion4? CurrencyConversion { get; init; }

    /// <summary>
    /// Media mix algorithm, the identification of the algorithm is an agreement between the ATM and the ATM manager.
    /// </summary>
    [IsoId("_Ah0moIonEeSaAcF2oE2GNQ")]
    [DisplayName("Selected Mix Type")]
    [IsoXmlTag("SelctdMixTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SelectedMixType { get; init; }

    /// <summary>
    /// Media mix selected.
    /// </summary>
    [IsoId("_MXSYwIonEeSaAcF2oE2GNQ")]
    [DisplayName("Selected Mix")]
    [IsoXmlTag("SelctdMix")]
    public ValueList<ATMMediaMix1> SelectedMix { get; init; } = [];

    /// <summary>
    /// True if a receipt has be requested by the customer.
    /// </summary>
    [IsoId("_kNSkkIonEeSaAcF2oE2GNQ")]
    [DisplayName("Requested Receipt")]
    [IsoXmlTag("ReqdRct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; }

    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_owlJkIonEeSaAcF2oE2GNQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
