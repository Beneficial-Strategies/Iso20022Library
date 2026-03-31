// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Narrative65.
/// </summary>
[IsoId("_U_8e83SdEe6VWZz2tTgENw")]
[DisplayName("Corporate Action Narrative65")]
public record CorporateActionNarrative65
{
    /// <summary>
    /// Additional Text.
    /// </summary>
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public ValueList<UpdatedAdditionalInformation26> AdditionalText { get; init; } = [];

    /// <summary>
    /// Basket Or Index Information.
    /// </summary>
    [DisplayName("Basket Or Index Information")]
    [IsoXmlTag("BsktOrIndxInf")]
    public ValueList<UpdatedAdditionalInformation26> BasketOrIndexInformation { get; init; } = [];

    /// <summary>
    /// Certification Breakdown.
    /// </summary>
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    public ValueList<UpdatedAdditionalInformation26> CertificationBreakdown { get; init; } = [];

    /// <summary>
    /// Disclaimer.
    /// </summary>
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public ValueList<UpdatedAdditionalInformation26> Disclaimer { get; init; } = [];

    /// <summary>
    /// Information Conditions.
    /// </summary>
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    public ValueList<UpdatedAdditionalInformation26> InformationConditions { get; init; } = [];

    /// <summary>
    /// Information To Comply With.
    /// </summary>
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    public ValueList<UpdatedAdditionalInformation26> InformationToComplyWith { get; init; } = [];

    /// <summary>
    /// Narrative Version.
    /// </summary>
    [DisplayName("Narrative Version")]
    [IsoXmlTag("NrrtvVrsn")]
    public ValueList<UpdatedAdditionalInformation26> NarrativeVersion { get; init; } = [];

    /// <summary>
    /// Party Contact Narrative.
    /// </summary>
    [DisplayName("Party Contact Narrative")]
    [IsoXmlTag("PtyCtctNrrtv")]
    public ValueList<UpdatedAdditionalInformation26> PartyContactNarrative { get; init; } = [];

    /// <summary>
    /// Processing Text For Next Intermediary.
    /// </summary>
    [DisplayName("Processing Text For Next Intermediary")]
    [IsoXmlTag("PrcgTxtForNxtIntrmy")]
    public ValueList<UpdatedAdditionalInformation26> ProcessingTextForNextIntermediary { get; init; } =
        [];

    /// <summary>
    /// Registration Details.
    /// </summary>
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    public ValueList<UpdatedAdditionalInformation26> RegistrationDetails { get; init; } = [];

    /// <summary>
    /// Taxation Conditions.
    /// </summary>
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public ValueList<UpdatedAdditionalInformation26> TaxationConditions { get; init; } = [];

    /// <summary>
    /// URL Address.
    /// </summary>
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public ValueList<UpdatedURLlnformation7> URLAddress { get; init; } = [];
}
