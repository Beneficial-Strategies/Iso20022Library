// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the taxation conditions.
/// </summary>
[IsoId("_WZhE0dp-Ed-ak6NoX_4Aeg_319701841")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative15
{
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_WZhE0tp-Ed-ak6NoX_4Aeg_-1496324193")]
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public UpdatedAdditionalInformation6? AdditionalText { get; init; }

    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields of this message, - or narrative information not needed for automatic processing.
    /// </summary>
    [IsoId("_WZhE09p-Ed-ak6NoX_4Aeg_-78734890")]
    [DisplayName("Narrative Version")]
    [IsoXmlTag("NrrtvVrsn")]
    public UpdatedAdditionalInformation6? NarrativeVersion { get; init; }

    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [IsoId("_WZhE1Np-Ed-ak6NoX_4Aeg_2108248634")]
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    public UpdatedAdditionalInformation5? InformationConditions { get; init; }

    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    [IsoId("_WZhE1dp-Ed-ak6NoX_4Aeg_-730076701")]
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    public UpdatedAdditionalInformation5? InformationToComplyWith { get; init; }

    /// <summary>
    /// Provides restriction(s) on securities.
    /// </summary>
    [IsoId("_WZhE1tp-Ed-ak6NoX_4Aeg_573673536")]
    [DisplayName("Security Restriction")]
    [IsoXmlTag("SctyRstrctn")]
    public UpdatedAdditionalInformation5? SecurityRestriction { get; init; }

    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_WZhE19p-Ed-ak6NoX_4Aeg_-1534310236")]
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public UpdatedAdditionalInformation5? TaxationConditions { get; init; }

    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_WZhE2Np-Ed-ak6NoX_4Aeg_-230559999")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public UpdatedAdditionalInformation5? Disclaimer { get; init; }
}
