// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Narrative61.
/// </summary>
[IsoId("_U1ayu3SdEe6VWZz2tTgENw")]
[DisplayName("Corporate Action Narrative61")]
public record CorporateActionNarrative61
{
    /// <summary>
    /// Additional Text.
    /// </summary>
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public UpdatedAdditionalInformation22? AdditionalText { get; init; }

    /// <summary>
    /// Certification Breakdown.
    /// </summary>
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    public UpdatedAdditionalInformation23? CertificationBreakdown { get; init; }

    /// <summary>
    /// Disclaimer.
    /// </summary>
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public UpdatedAdditionalInformation23? Disclaimer { get; init; }

    /// <summary>
    /// Information Conditions.
    /// </summary>
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    public UpdatedAdditionalInformation23? InformationConditions { get; init; }

    /// <summary>
    /// Information To Comply With.
    /// </summary>
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    public UpdatedAdditionalInformation23? InformationToComplyWith { get; init; }

    /// <summary>
    /// Narrative Version.
    /// </summary>
    [DisplayName("Narrative Version")]
    [IsoXmlTag("NrrtvVrsn")]
    public UpdatedAdditionalInformation22? NarrativeVersion { get; init; }

    /// <summary>
    /// Security Restriction.
    /// </summary>
    [DisplayName("Security Restriction")]
    [IsoXmlTag("SctyRstrctn")]
    public UpdatedAdditionalInformation23? SecurityRestriction { get; init; }

    /// <summary>
    /// Taxation Conditions.
    /// </summary>
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public UpdatedAdditionalInformation23? TaxationConditions { get; init; }
}
