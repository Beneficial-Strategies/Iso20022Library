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
[IsoId("_eAwlEe6OEeqc-LCjwLsUVg")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative45
{
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_etGGo-6OEeqc-LCjwLsUVg")]
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public ValueList<UpdatedAdditionalInformation12> AdditionalText { get; init; } = [];

    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields, - or narrative information not needed for automatic processing.
    /// </summary>
    [IsoId("_etGGq-6OEeqc-LCjwLsUVg")]
    [DisplayName("Narrative Version")]
    [IsoXmlTag("NrrtvVrsn")]
    public ValueList<UpdatedAdditionalInformation12> NarrativeVersion { get; init; } = [];

    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [IsoId("_etGGs-6OEeqc-LCjwLsUVg")]
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    public ValueList<UpdatedAdditionalInformation11> InformationConditions { get; init; } = [];

    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    [IsoId("_etGGu-6OEeqc-LCjwLsUVg")]
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    public ValueList<UpdatedAdditionalInformation11> InformationToComplyWith { get; init; } = [];

    /// <summary>
    /// Provides restriction(s) on securities.
    /// </summary>
    [IsoId("_etGGw-6OEeqc-LCjwLsUVg")]
    [DisplayName("Security Restriction")]
    [IsoXmlTag("SctyRstrctn")]
    public ValueList<UpdatedAdditionalInformation11> SecurityRestriction { get; init; } = [];

    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_etGGy-6OEeqc-LCjwLsUVg")]
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public ValueList<UpdatedAdditionalInformation11> TaxationConditions { get; init; } = [];

    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_etGG0-6OEeqc-LCjwLsUVg")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public ValueList<UpdatedAdditionalInformation11> Disclaimer { get; init; } = [];

    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    [IsoId("_etGG2-6OEeqc-LCjwLsUVg")]
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    public ValueList<UpdatedAdditionalInformation11> CertificationBreakdown { get; init; } = [];
}
