// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposit transaction for which the service is requested.
/// </summary>
[IsoId("_DGFika4AEeWL1uap3dNhCQ")]
[DisplayName("ATM Transaction")]
public record ATMTransaction15
{
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_DRHG064AEeWL1uap3dNhCQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_DRHG1a4AEeWL1uap3dNhCQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Unprotected account information.
    /// </summary>
    [IsoId("_DRHG164AEeWL1uap3dNhCQ")]
    [DisplayName("Account Data")]
    [IsoXmlTag("AcctData")]
    public CardAccount9? AccountData { get; init; }

    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_DRHG2a4AEeWL1uap3dNhCQ")]
    [DisplayName("Protected Account Data")]
    [IsoXmlTag("PrtctdAcctData")]
    public ContentInformationType10? ProtectedAccountData { get; init; }

    /// <summary>
    /// Total amount of the deposit transaction.
    /// </summary>
    [IsoId("_DRHG264AEeWL1uap3dNhCQ")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public AmountAndCurrency1? TotalAmount { get; init; }

    /// <summary>
    /// Amounts of the deposit transaction.
    /// </summary>
    [IsoId("_DRHG3a4AEeWL1uap3dNhCQ")]
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public DetailedAmount16? DetailedRequestedAmount { get; init; }

    /// <summary>
    /// Deposited media put in the safe.
    /// </summary>
    [IsoId("_f3v6oK4BEeWL1uap3dNhCQ")]
    [DisplayName("Deposited Media")]
    [IsoXmlTag("DpstdMdia")]
    public ATMDepositedMedia1? DepositedMedia { get; init; }

    /// <summary>
    /// True if a receipt has be requested by the customer.
    /// </summary>
    [IsoId("_DRHG5a4AEeWL1uap3dNhCQ")]
    [DisplayName("Requested Receipt")]
    [IsoXmlTag("ReqdRct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; }

    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_DRHG564AEeWL1uap3dNhCQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
