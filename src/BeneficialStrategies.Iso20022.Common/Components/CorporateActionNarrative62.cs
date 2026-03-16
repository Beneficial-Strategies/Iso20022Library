// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Narrative62.
/// </summary>
[IsoId("_U1azK3SdEe6VWZz2tTgENw")]
[DisplayName("Corporate Action Narrative62")]
public partial record CorporateActionNarrative62
{
    #nullable enable

    /// <summary>
    /// Additional Text.
    /// </summary>
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public UpdatedAdditionalInformation23? AdditionalText { get; init; } 

    /// <summary>
    /// Basket Or Index Information.
    /// </summary>
    [DisplayName("Basket Or Index Information")]
    [IsoXmlTag("BsktOrIndxInf")]
    public UpdatedAdditionalInformation23? BasketOrIndexInformation { get; init; } 

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
    public UpdatedAdditionalInformation23? NarrativeVersion { get; init; } 

    /// <summary>
    /// Party Contact Narrative.
    /// </summary>
    [DisplayName("Party Contact Narrative")]
    [IsoXmlTag("PtyCtctNrrtv")]
    public UpdatedAdditionalInformation23? PartyContactNarrative { get; init; } 

    /// <summary>
    /// Processing Text For Next Intermediary.
    /// </summary>
    [DisplayName("Processing Text For Next Intermediary")]
    [IsoXmlTag("PrcgTxtForNxtIntrmy")]
    public UpdatedAdditionalInformation23? ProcessingTextForNextIntermediary { get; init; } 

    /// <summary>
    /// Registration Details.
    /// </summary>
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    public UpdatedAdditionalInformation23? RegistrationDetails { get; init; } 

    /// <summary>
    /// Taxation Conditions.
    /// </summary>
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public UpdatedAdditionalInformation23? TaxationConditions { get; init; } 

    
    #nullable disable
    
}
