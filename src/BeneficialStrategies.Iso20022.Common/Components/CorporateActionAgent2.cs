// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Agent2.
/// </summary>
[IsoId("_zbnhMEmkEe-NocYul3BKXQ")]
[DisplayName("Corporate Action Agent2")]
public record CorporateActionAgent2
{
    /// <summary>
    /// Information Agent.
    /// </summary>
    [DisplayName("Information Agent")]
    [IsoXmlTag("InfAgt")]
    public PartyIdentification289? InformationAgent { get; init; }

    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification289? Issuer { get; init; }

    /// <summary>
    /// Issuer Agent.
    /// </summary>
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public PartyIdentification289? IssuerAgent { get; init; }

    /// <summary>
    /// Paying Agent.
    /// </summary>
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public PartyIdentification289? PayingAgent { get; init; }

    /// <summary>
    /// Redemption Agent.
    /// </summary>
    [DisplayName("Redemption Agent")]
    [IsoXmlTag("RedAgt")]
    public PartyIdentification289? RedemptionAgent { get; init; }

    /// <summary>
    /// Registrar.
    /// </summary>
    [DisplayName("Registrar")]
    [IsoXmlTag("Regar")]
    public PartyIdentification289? Registrar { get; init; }

    /// <summary>
    /// Remarketing Agent.
    /// </summary>
    [DisplayName("Remarketing Agent")]
    [IsoXmlTag("RmktgAgt")]
    public PartyIdentification289? RemarketingAgent { get; init; }

    /// <summary>
    /// Solicitation Agent.
    /// </summary>
    [DisplayName("Solicitation Agent")]
    [IsoXmlTag("SlctnAgt")]
    public PartyIdentification289? SolicitationAgent { get; init; }

    /// <summary>
    /// Transfer Agent.
    /// </summary>
    [DisplayName("Transfer Agent")]
    [IsoXmlTag("TrfAgt")]
    public PartyIdentification289? TransferAgent { get; init; }
}
