// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Narrative58.
/// </summary>
[IsoId("_seLEwWHzEe6yt_d72zQZeQ")]
[DisplayName("Corporate Action Narrative58")]
public record CorporateActionNarrative58
{
    /// <summary>
    /// Event Processing Web Site Address.
    /// </summary>
    [DisplayName("Event Processing Web Site Address")]
    [IsoXmlTag("EvtPrcgWebSiteAdr")]
    public IsoMax2048Text? EventProcessingWebSiteAddress { get; init; }

    /// <summary>
    /// New Company Name.
    /// </summary>
    [DisplayName("New Company Name")]
    [IsoXmlTag("NewCpnyNm")]
    public IsoMax350Text? NewCompanyName { get; init; }

    /// <summary>
    /// Offeror.
    /// </summary>
    [DisplayName("Offeror")]
    [IsoXmlTag("Offerr")]
    public ValueList<IsoMax350Text> Offeror { get; init; } = [];

    /// <summary>
    /// URL Address.
    /// </summary>
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public ValueList<UpdatedURLlnformation6> URLAddress { get; init; } = [];
}
