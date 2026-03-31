// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Narrative64.
/// </summary>
[IsoId("_U_741XSdEe6VWZz2tTgENw")]
[DisplayName("Corporate Action Narrative64")]
public record CorporateActionNarrative64
{
    /// <summary>
    /// Additional Text.
    /// </summary>
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public ValueList<UpdatedAdditionalInformation24> AdditionalText { get; init; } = [];

    /// <summary>
    /// Certification Breakdown.
    /// </summary>
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    public ValueList<UpdatedAdditionalInformation25> CertificationBreakdown { get; init; } = [];

    /// <summary>
    /// Disclaimer.
    /// </summary>
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public ValueList<UpdatedAdditionalInformation25> Disclaimer { get; init; } = [];

    /// <summary>
    /// Information Conditions.
    /// </summary>
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    public ValueList<UpdatedAdditionalInformation25> InformationConditions { get; init; } = [];

    /// <summary>
    /// Information To Comply With.
    /// </summary>
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    public ValueList<UpdatedAdditionalInformation25> InformationToComplyWith { get; init; } = [];

    /// <summary>
    /// Narrative Version.
    /// </summary>
    [DisplayName("Narrative Version")]
    [IsoXmlTag("NrrtvVrsn")]
    public ValueList<UpdatedAdditionalInformation24> NarrativeVersion { get; init; } = [];

    /// <summary>
    /// Security Restriction.
    /// </summary>
    [DisplayName("Security Restriction")]
    [IsoXmlTag("SctyRstrctn")]
    public ValueList<UpdatedAdditionalInformation25> SecurityRestriction { get; init; } = [];

    /// <summary>
    /// Taxation Conditions.
    /// </summary>
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public ValueList<UpdatedAdditionalInformation25> TaxationConditions { get; init; } = [];
}
