// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non Financial Request Content Component5.
/// </summary>
[IsoId("_SmEB0Z9WEe-nbM0aSPcoiQ")]
[DisplayName("Non Financial Request Content Component5")]
public record NonFinancialRequestContentComponent5
{
    /// <summary>
    /// Additional Request.
    /// </summary>
    [DisplayName("Additional Request")]
    [IsoXmlTag("AddtlReq")]
    public ExternallyDefinedData5? AdditionalRequest { get; init; }

    /// <summary>
    /// Non Financial Request Type.
    /// </summary>
    [DisplayName("Non Financial Request Type")]
    [IsoXmlTag("NonFinReqTp")]
    public ValueList<NonFinancialRequestType2Code> NonFinancialRequestType { get; init; } = [];

    /// <summary>
    /// Transaction.
    /// </summary>
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public CardPaymentTransaction139? Transaction { get; init; }
}
