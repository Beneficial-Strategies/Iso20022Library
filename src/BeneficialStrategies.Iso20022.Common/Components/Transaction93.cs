// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of transaction for a fraud reporting.
/// </summary>
[IsoId("_lCkWs_--Eei7rYq35FFO4A")]
[DisplayName("Transaction")]
public record Transaction93
{
    /// <summary>
    /// Identification of the  transaction reporting the fraud.
    /// </summary>
    [IsoId("_r6q28f--Eei7rYq35FFO4A")]
    [DisplayName("Fraud Transaction Identification")]
    [IsoXmlTag("FrdTxId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text FraudTransactionIdentification { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_lCkWtf--Eei7rYq35FFO4A")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public AdditionalFee1? AdditionalFees { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_VSvc4RqnEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
