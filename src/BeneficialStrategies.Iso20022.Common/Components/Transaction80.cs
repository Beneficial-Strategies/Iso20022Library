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
[IsoId("_eRhDAZjCEeefZKJHxQTztg")]
[DisplayName("Transaction")]
public record Transaction80
{
    /// <summary>
    /// Identification of the  transaction reporting the fraud.
    /// </summary>
    [IsoId("_ef0kwZjCEeefZKJHxQTztg")]
    [DisplayName("Fraud Transaction Identification")]
    [IsoXmlTag("FrdTxId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text FraudTransactionIdentification { get; init; }

    /// <summary>
    /// Fraud reporting type information.
    /// </summary>
    [IsoId("_ef0kw5jCEeefZKJHxQTztg")]
    [DisplayName("Reported Fraud")]
    [IsoXmlTag("RptdFrd")]
    public required ReportedFraud2 ReportedFraud { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_J1lCgvF8EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public ValueList<AdditionalFee1> AdditionalFees { get; init; } = [];

    /// <summary>
    /// Additional information relevant for the settlement report.
    /// </summary>
    [IsoId("_ef0ky5jCEeefZKJHxQTztg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation22> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_QEl9ARqnEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
