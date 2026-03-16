// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the card transaction.
/// </summary>
[IsoId("_nUP88YNtEeSXtJ8rlirVJw")]
[DisplayName("Card Transaction Detail")]
public record CardTransactionDetail4
{
    /// <summary>
    /// Amounts of the transaction expressed within the terminal currency.
    /// </summary>
    [IsoId("_nhgV0YNtEeSXtJ8rlirVJw")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required CardTransactionAmount4 TransactionAmounts { get; init; }

    /// <summary>
    /// Fees between acquirer and issuer exclusive of the transaction amount, and expressed in the currency of the reconciliation.
    /// </summary>
    [IsoId("_D5rsUINuEeSXtJ8rlirVJw")]
    [DisplayName("Transaction Fees")]
    [IsoXmlTag("TxFees")]
    public DetailedAmount11? TransactionFees { get; init; }

    /// <summary>
    /// Additional amounts from the processor or the issuer without financial impacts on the transaction amount.
    /// </summary>
    [IsoId("_nhgV04NtEeSXtJ8rlirVJw")]
    [DisplayName("Additional Amounts")]
    [IsoXmlTag("AddtlAmts")]
    public DetailedAmount10? AdditionalAmounts { get; init; }

    /// <summary>
    /// Account involved in the card transaction.
    /// </summary>
    [IsoId("_nhgV1YNtEeSXtJ8rlirVJw")]
    [DisplayName("Account And Balance")]
    [IsoXmlTag("AcctAndBal")]
    public CardAccount2? AccountAndBalance { get; init; }

    /// <summary>
    /// Results of the verifications performed by the various agents during the processing of the transaction.
    /// </summary>
    [IsoId("_nhgV14NtEeSXtJ8rlirVJw")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; }

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// It corresponds to ISO 8583, field number 57 for the version 93, and 3 for the version 2003.
    /// </summary>
    [IsoId("_nhgV2YNtEeSXtJ8rlirVJw")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// It corresponds to ISO 8583, field number 55 for the versions 93 and 2003.
    /// </summary>
    [IsoId("_nhgV24NtEeSXtJ8rlirVJw")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
