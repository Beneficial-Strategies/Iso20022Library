// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the cancellation response.
/// </summary>
[IsoId("_Jdo5sWl7EeSQMKir9owD5A")]
[DisplayName("Card Payment Transaction Details")]
public record CardPaymentTransactionDetails22
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_JqxWwWl7EeSQMKir9owD5A")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required CurrencyCode Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_JqxWw2l7EeSQMKir9owD5A")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_SqGCMGl7EeSQMKir9owD5A")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
