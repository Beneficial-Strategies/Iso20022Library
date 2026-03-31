// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Narrative59.
/// </summary>
[IsoId("_-wnE4WH0Ee6yt_d72zQZeQ")]
[DisplayName("Corporate Action Narrative59")]
public record CorporateActionNarrative59
{
    /// <summary>
    /// Additional Text.
    /// </summary>
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public ValueList<UpdatedAdditionalInformation19> AdditionalText { get; init; } = [];

    /// <summary>
    /// Certification Breakdown.
    /// </summary>
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    public ValueList<UpdatedAdditionalInformation21> CertificationBreakdown { get; init; } = [];

    /// <summary>
    /// Disclaimer.
    /// </summary>
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public ValueList<UpdatedAdditionalInformation21> Disclaimer { get; init; } = [];

    /// <summary>
    /// Information Conditions.
    /// </summary>
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    public ValueList<UpdatedAdditionalInformation21> InformationConditions { get; init; } = [];

    /// <summary>
    /// Information To Comply With.
    /// </summary>
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    public ValueList<UpdatedAdditionalInformation21> InformationToComplyWith { get; init; } = [];

    /// <summary>
    /// Narrative Version.
    /// </summary>
    [DisplayName("Narrative Version")]
    [IsoXmlTag("NrrtvVrsn")]
    public ValueList<UpdatedAdditionalInformation19> NarrativeVersion { get; init; } = [];

    /// <summary>
    /// Security Restriction.
    /// </summary>
    [DisplayName("Security Restriction")]
    [IsoXmlTag("SctyRstrctn")]
    public ValueList<UpdatedAdditionalInformation21> SecurityRestriction { get; init; } = [];

    /// <summary>
    /// Taxation Conditions.
    /// </summary>
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public ValueList<UpdatedAdditionalInformation21> TaxationConditions { get; init; } = [];
}
