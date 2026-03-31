// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Authorisation request from an acceptor.
/// </summary>
[IsoId("_x2niwdnbEeeN3v2fup_Shw")]
[DisplayName("Acceptor Authorisation Request")]
public record AcceptorAuthorisationRequest7
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_x_i1QdnbEeeN3v2fup_Shw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment68 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_x_i1Q9nbEeeN3v2fup_Shw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext26 Context { get; init; }

    /// <summary>
    /// Card payment transaction for which the authorisation is requested.
    /// </summary>
    [IsoId("_x_i1RdnbEeeN3v2fup_Shw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction80 Transaction { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_x_i1R9nbEeeN3v2fup_Shw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
