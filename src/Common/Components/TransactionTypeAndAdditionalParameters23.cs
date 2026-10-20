// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Type And Additional Parameters23.
/// </summary>
[IsoId("_AaX-gYVtEe-Pv9KR9bv9IA")]
[DisplayName("Transaction Type And Additional Parameters23")]
public partial record TransactionTypeAndAdditionalParameters23
{
    /// <summary>
    /// Account Owner Transaction Identification.
    /// </summary>
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public required Max35Text AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Account Servicer Transaction Identification.
    /// </summary>
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public Max35Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Securities Financing Transaction Type.
    /// </summary>
    [DisplayName("Securities Financing Transaction Type")]
    [IsoXmlTag("SctiesFincgTxTp")]
    public required SecuritiesFinancingTransactionType2Code SecuritiesFinancingTransactionType { get; init; }

    /// <summary>
    /// Payment.
    /// </summary>
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Modification Type.
    /// </summary>
    [DisplayName("Modification Type")]
    [IsoXmlTag("ModTp")]
    public RepurchaseType21Choice_? ModificationType { get; init; }

    /// <summary>
    /// Common Identification.
    /// </summary>
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public Max35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Pool Identification.
    /// </summary>
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public Max35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Nonce Identification.
    /// </summary>
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public Max35Text? NonceIdentification { get; init; }
}
