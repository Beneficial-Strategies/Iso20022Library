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
[IsoId("_L_gNQXu1EeS2Z_kGi7H1VQ")]
[DisplayName("Card Transaction Detail")]
public record CardTransactionDetail5
{
    /// <summary>
    /// Amounts of the transaction expressed within the terminal currency.
    /// </summary>
    [IsoId("_ML31UXu1EeS2Z_kGi7H1VQ")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required CardTransactionAmount5 TransactionAmounts { get; init; }

    /// <summary>
    /// Fees between acquirer and issuer exclusive of the transaction amount, and expressed in the currency of the reconciliation.
    /// </summary>
    [IsoId("_uuK-kINyEeSXtJ8rlirVJw")]
    [DisplayName("Transaction Fees")]
    [IsoXmlTag("TxFees")]
    public DetailedAmount11? TransactionFees { get; init; }

    /// <summary>
    /// Additional amounts from the processor or the issuer without financial impacts on the transaction amount.
    /// </summary>
    [IsoId("_ML31U3u1EeS2Z_kGi7H1VQ")]
    [DisplayName("Additional Amounts")]
    [IsoXmlTag("AddtlAmts")]
    public DetailedAmount10? AdditionalAmounts { get; init; }

    /// <summary>
    /// Reason to send a card acquirer to issuer message.
    /// It corresponds to ISO 8583, field number 25 for the version 93, and 9 for the version 2003.
    /// </summary>
    [IsoId("_ML31VXu1EeS2Z_kGi7H1VQ")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<MessageReason1Code> MessageReason { get; init; } = [];

    // ID for the above is _ML31VXu1EeS2Z_kGi7H1VQ

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// It corresponds to ISO 8583, field number 55 for the versions 93 and 2003.
    /// </summary>
    [IsoId("_ML31Y3u1EeS2Z_kGi7H1VQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
