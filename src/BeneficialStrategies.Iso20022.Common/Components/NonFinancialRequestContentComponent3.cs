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
[IsoId("_pV2jMXJUEe299ZbWCkdR_w")]
[DisplayName("Non Financial Request Content Component")]
public record NonFinancialRequestContentComponent3
{
    /// <summary>
    /// Type of non financial request that the Acceptor wants to be processed.
    /// </summary>
    [IsoId("_pdAUEXJUEe299ZbWCkdR_w")]
    [DisplayName("Non Financial Request Type")]
    [IsoXmlTag("NonFinReqTp")]
    public SimpleValueList<NonFinancialRequestType2Code> NonFinancialRequestType { get; init; } =
        [];

    // ID for the above is _pdAUEXJUEe299ZbWCkdR_w

    /// <summary>
    /// Card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_pdAUE3JUEe299ZbWCkdR_w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public CardPaymentTransaction124? Transaction { get; init; }

    /// <summary>
    /// Additional elements requested to the ServiceProvider which are not linked to payment.
    /// </summary>
    [IsoId("_1WM6MHJVEe299ZbWCkdR_w")]
    [DisplayName("Additional Request")]
    [IsoXmlTag("AddtlReq")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<ExternallyDefinedData4> AdditionalRequest { get; init; } = [];
}
