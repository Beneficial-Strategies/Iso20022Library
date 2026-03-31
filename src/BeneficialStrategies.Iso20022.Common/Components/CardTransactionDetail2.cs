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
[IsoId("_vWoV4XuUEeSVeNXcmBQ4hQ")]
[DisplayName("Card Transaction Detail")]
public record CardTransactionDetail2
{
    /// <summary>
    /// Amounts of the transaction expressed within the terminal currency.
    /// </summary>
    [IsoId("_vi_98XuUEeSVeNXcmBQ4hQ")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required CardTransactionAmount2 TransactionAmounts { get; init; }

    /// <summary>
    /// Additional amounts from the processor or the issuer without financial impacts on the transaction amount.
    /// </summary>
    [IsoId("_vi_983uUEeSVeNXcmBQ4hQ")]
    [DisplayName("Additional Amounts")]
    [IsoXmlTag("AddtlAmts")]
    public ValueList<DetailedAmount10> AdditionalAmounts { get; init; } = [];

    /// <summary>
    /// Account involved in the card transaction.
    /// </summary>
    [IsoId("_AMoNMHuWEeSVeNXcmBQ4hQ")]
    [DisplayName("Account And Balance")]
    [IsoXmlTag("AcctAndBal")]
    public ValueList<CardAccount2> AccountAndBalance { get; init; } = [];

    /// <summary>
    /// Results of the verifications performed by the various agents during the processing of the transaction.
    /// </summary>
    [IsoId("_lNdbkHuWEeSVeNXcmBQ4hQ")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public ValueList<TransactionVerificationResult4> TransactionVerificationResult { get; init; } =
        [];

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// It corresponds to ISO 8583, field number 57 for the version 93, and 3 for the version 2003.
    /// </summary>
    [IsoId("_vi_993uUEeSVeNXcmBQ4hQ")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// It corresponds to ISO 8583, field number 55 for the versions 93 and 2003.
    /// </summary>
    [IsoId("_vi_-A3uUEeSVeNXcmBQ4hQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
