// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the cancellation inside a batch transfer.
/// </summary>
[IsoId("_jTnSwU1CEeybj420QgWBkA")]
[DisplayName("Card Payment Transaction Details")]
public record CardPaymentTransactionDetails50
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_japu4U1CEeybj420QgWBkA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_japu401CEeybj420QgWBkA")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_japu5U1CEeybj420QgWBkA")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_japu501CEeybj420QgWBkA")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }

    /// <summary>
    /// This transaction is cancelled but the authorisation is not reversed.
    /// </summary>
    [IsoId("_Asuh0E1DEeybj420QgWBkA")]
    [DisplayName("Keep Authorisation Open")]
    [IsoXmlTag("KeepAuthstnOpn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? KeepAuthorisationOpen { get; init; }
}
