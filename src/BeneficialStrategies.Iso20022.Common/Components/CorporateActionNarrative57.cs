// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Narrative57.
/// </summary>
[IsoId("_h4eEoWHjEe6yt_d72zQZeQ")]
[DisplayName("Corporate Action Narrative57")]
public record CorporateActionNarrative57
{
    /// <summary>
    /// Additional Text.
    /// </summary>
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public UpdatedAdditionalInformation18? AdditionalText { get; init; }

    /// <summary>
    /// Certification Breakdown.
    /// </summary>
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    public UpdatedAdditionalInformation17? CertificationBreakdown { get; init; }

    /// <summary>
    /// Disclaimer.
    /// </summary>
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public UpdatedAdditionalInformation17? Disclaimer { get; init; }

    /// <summary>
    /// Information Conditions.
    /// </summary>
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    public UpdatedAdditionalInformation17? InformationConditions { get; init; }

    /// <summary>
    /// Information To Comply With.
    /// </summary>
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    public UpdatedAdditionalInformation17? InformationToComplyWith { get; init; }

    /// <summary>
    /// Narrative Version.
    /// </summary>
    [DisplayName("Narrative Version")]
    [IsoXmlTag("NrrtvVrsn")]
    public UpdatedAdditionalInformation18? NarrativeVersion { get; init; }

    /// <summary>
    /// Security Restriction.
    /// </summary>
    [DisplayName("Security Restriction")]
    [IsoXmlTag("SctyRstrctn")]
    public UpdatedAdditionalInformation17? SecurityRestriction { get; init; }

    /// <summary>
    /// Taxation Conditions.
    /// </summary>
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public UpdatedAdditionalInformation17? TaxationConditions { get; init; }
}
