// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Narrative56.
/// </summary>
[IsoId("_GSMhoWHiEe6yt_d72zQZeQ")]
[DisplayName("Corporate Action Narrative56")]
public record CorporateActionNarrative56
{
    /// <summary>
    /// Additional Text.
    /// </summary>
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public UpdatedAdditionalInformation17? AdditionalText { get; init; }

    /// <summary>
    /// Basket Or Index Information.
    /// </summary>
    [DisplayName("Basket Or Index Information")]
    [IsoXmlTag("BsktOrIndxInf")]
    public UpdatedAdditionalInformation17? BasketOrIndexInformation { get; init; }

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
    public UpdatedAdditionalInformation17? NarrativeVersion { get; init; }

    /// <summary>
    /// Party Contact Narrative.
    /// </summary>
    [DisplayName("Party Contact Narrative")]
    [IsoXmlTag("PtyCtctNrrtv")]
    public UpdatedAdditionalInformation17? PartyContactNarrative { get; init; }

    /// <summary>
    /// Processing Text For Next Intermediary.
    /// </summary>
    [DisplayName("Processing Text For Next Intermediary")]
    [IsoXmlTag("PrcgTxtForNxtIntrmy")]
    public UpdatedAdditionalInformation17? ProcessingTextForNextIntermediary { get; init; }

    /// <summary>
    /// Registration Details.
    /// </summary>
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    public UpdatedAdditionalInformation17? RegistrationDetails { get; init; }

    /// <summary>
    /// Taxation Conditions.
    /// </summary>
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public UpdatedAdditionalInformation17? TaxationConditions { get; init; }
}
