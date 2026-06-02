// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Funds related service such as a payment or a transfer related to the transaction.
/// </summary>
[IsoId("_0OZqoT_ZEfCQAqQ9lolFUg")]
[DisplayName("Funding Service4")]
public record FundingService4
{
    /// <summary>
    /// Identification of the funding service provider.
    /// </summary>
    [IsoId("_0Q498T_ZEfCQAqQ9lolFUg")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    public IsoMax35Text? Provider { get; init; }

    /// <summary>
    /// Name of the funding service (for example, MoneyGram, Western Union, etc.).
    /// </summary>
    [IsoId("_0Q498z_ZEfCQAqQ9lolFUg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Reference to the funding service.
    /// </summary>
    [IsoId("_0Q499T_ZEfCQAqQ9lolFUg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Purpose of the transfer.
    /// </summary>
    [IsoId("_0Q499z_ZEfCQAqQ9lolFUg")]
    [DisplayName("Business Purpose")]
    [IsoXmlTag("BizPurp")]
    public IsoMax500Text? BusinessPurpose { get; init; }

    /// <summary>
    /// Free text that can be used between the sender and the receiver to describe the details of the transfer.
    /// </summary>
    [IsoId("_0Q49-T_ZEfCQAqQ9lolFUg")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax256Text? Description { get; init; }

    /// <summary>
    /// Source of funding.
    /// </summary>
    [IsoId("_0Q49-z_ZEfCQAqQ9lolFUg")]
    [DisplayName("Funding Source")]
    [IsoXmlTag("FndgSrc")]
    public ValueList<FundingSource5> FundingSource { get; init; } = [];

    /// <summary>
    /// Code presented by the customer to claim funds.
    /// </summary>
    [IsoId("_0Q49_T_ZEfCQAqQ9lolFUg")]
    [DisplayName("Claim Credentials")]
    [IsoXmlTag("ClmCrdntls")]
    public IsoMax500Text? ClaimCredentials { get; init; }

    /// <summary>
    /// Entity issuing the claim credential.
    /// </summary>
    [IsoId("_0Q49_z_ZEfCQAqQ9lolFUg")]
    [DisplayName("Claim Assigner")]
    [IsoXmlTag("ClmAssgnr")]
    public IsoMax35Text? ClaimAssigner { get; init; }

    /// <summary>
    /// Contains service processing types.
    /// </summary>
    [IsoId("_4qb7oD_aEfCQAqQ9lolFUg")]
    [DisplayName("Service Processing Type")]
    [IsoXmlTag("SvcPrcgTp")]
    public IsoMax3Text? ServiceProcessingType { get; init; }

    /// <summary>
    /// Contains date and time value indicating scheduled deferred posting for issuer.
    /// </summary>
    [IsoId("_WgUmQD_bEfCQAqQ9lolFUg")]
    [DisplayName("Deferred Date Time")]
    [IsoXmlTag("DfrrdDtTm")]
    public IsoISODateTime? DeferredDateTime { get; init; }
}
