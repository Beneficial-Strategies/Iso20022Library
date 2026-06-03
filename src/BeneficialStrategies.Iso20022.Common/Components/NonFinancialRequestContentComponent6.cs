// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aim of the non financial request.
/// </summary>
[IsoId("_Oxa80bX7EfCUZfsQO4rYeA")]
[DisplayName("Non Financial Request Content Component6")]
public record NonFinancialRequestContentComponent6
{
    /// <summary>
    /// Type of non financial request that the acceptor wants to be processed.
    /// </summary>
    [IsoId("_Oyc3lbX7EfCUZfsQO4rYeA")]
    [DisplayName("Non Financial Request Type")]
    [IsoXmlTag("NonFinReqTp")]
    [MinLength(1)]
    public SimpleValueList<NonFinancialRequestType2Code> NonFinancialRequestType { get; init; } = [];

    /// <summary>
    /// Card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_Oyc3m7X7EfCUZfsQO4rYeA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public CardPaymentTransaction146? Transaction { get; init; }

    /// <summary>
    /// Additional elements requested to the service provider which are not linked to payment.
    /// </summary>
    [IsoId("_Oyc3obX7EfCUZfsQO4rYeA")]
    [DisplayName("Additional Request")]
    [IsoXmlTag("AddtlReq")]
    public ValueList<ExternallyDefinedData5> AdditionalRequest { get; init; } = [];
}
