// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the cancellation request.
/// </summary>
[IsoId("_TENctgEcEeCQm6a_G2yO_w_1841833853")]
[DisplayName("Card Payment Transaction Details")]
public record CardPaymentTransactionDetails5
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_TENctwEcEeCQm6a_G2yO_w_-2035136")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required CurrencyCode Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_TENcuAEcEeCQm6a_G2yO_w_758730017")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_TENcuQEcEeCQm6a_G2yO_w_-556118997")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_TENcugEcEeCQm6a_G2yO_w_-797139572")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
