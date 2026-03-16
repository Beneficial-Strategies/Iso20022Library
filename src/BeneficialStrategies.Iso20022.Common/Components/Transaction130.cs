// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fraud reporting transaction.
/// </summary>
[IsoId("_S466AYv3EeumSPwlS1PkxQ")]
[DisplayName("Transaction")]
public record Transaction130
{
    /// <summary>
    /// Identification of the  transaction reporting the fraud.
    /// </summary>
    [IsoId("_S-Ft4Yv3EeumSPwlS1PkxQ")]
    [DisplayName("Fraud Transaction Identification")]
    [IsoXmlTag("FrdTxId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text FraudTransactionIdentification { get; init; }

    /// <summary>
    /// Fraud reporting type information.
    /// </summary>
    [IsoId("_S-Ft44v3EeumSPwlS1PkxQ")]
    [DisplayName("Reported Fraud")]
    [IsoXmlTag("RptdFrd")]
    public required ReportedFraud3 ReportedFraud { get; init; }

    /// <summary>
    /// Data pertaining to fraudulent reported transaction.
    /// </summary>
    [IsoId("_S-Ft5Yv3EeumSPwlS1PkxQ")]
    [DisplayName("Fraudulent Transaction Data")]
    [IsoXmlTag("FrdlntTxData")]
    public required FraudulentTransactionData2 FraudulentTransactionData { get; init; }

    /// <summary>
    /// Details of a not-received card.
    /// </summary>
    [IsoId("_S-Ft54v3EeumSPwlS1PkxQ")]
    [DisplayName("Card Not Received Details")]
    [IsoXmlTag("CardNotRcvdDtls")]
    public CardNotReceivedDetails2? CardNotReceivedDetails { get; init; }

    /// <summary>
    /// Cardholder name as it appears on the card.
    /// </summary>
    [IsoId("_S-Ft6Yv3EeumSPwlS1PkxQ")]
    [DisplayName("Cardholder Name")]
    [IsoXmlTag("CrdhldrNm")]
    public CardholderName3? CardholderName { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_S-Ft64v3EeumSPwlS1PkxQ")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public AdditionalFee2? AdditionalFee { get; init; }

    /// <summary>
    /// Additional information relevant for the settlement report.
    /// </summary>
    [IsoId("_S-Ft7Yv3EeumSPwlS1PkxQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation22? AdditionalInformation { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_S-Ft74v3EeumSPwlS1PkxQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }

    /// <summary>
    /// Contains text fields in the local language.
    /// </summary>
    [IsoId("_psRykMXKEeumGdYElfgmbw")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData6? LocalData { get; init; }
}
