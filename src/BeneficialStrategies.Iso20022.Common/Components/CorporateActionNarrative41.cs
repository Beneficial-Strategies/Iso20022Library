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
[IsoId("_c5o1eZKQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative41
{
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_c5o1fZKQEeWHWpTQn1FFVg")]
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public UpdatedAdditionalInformation10? AdditionalText { get; init; }

    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields, - or narrative information not needed for automatic processing.
    /// </summary>
    [IsoId("_c5o1hZKQEeWHWpTQn1FFVg")]
    [DisplayName("Narrative Version")]
    [IsoXmlTag("NrrtvVrsn")]
    public UpdatedAdditionalInformation10? NarrativeVersion { get; init; }

    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [IsoId("_c5o1jZKQEeWHWpTQn1FFVg")]
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    public UpdatedAdditionalInformation10? InformationConditions { get; init; }

    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    [IsoId("_c5o1lZKQEeWHWpTQn1FFVg")]
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    public UpdatedAdditionalInformation10? InformationToComplyWith { get; init; }

    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_c5pb8ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public UpdatedAdditionalInformation10? TaxationConditions { get; init; }

    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_c5pb-ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public UpdatedAdditionalInformation10? Disclaimer { get; init; }

    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_c5pcAZKQEeWHWpTQn1FFVg")]
    [DisplayName("Party Contact Narrative")]
    [IsoXmlTag("PtyCtctNrrtv")]
    public UpdatedAdditionalInformation10? PartyContactNarrative { get; init; }

    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_c5pcCZKQEeWHWpTQn1FFVg")]
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    public UpdatedAdditionalInformation10? RegistrationDetails { get; init; }

    /// <summary>
    /// Provides additional information on the basket or index underlying a security, for example a warrant.
    /// </summary>
    [IsoId("_c5pcEZKQEeWHWpTQn1FFVg")]
    [DisplayName("Basket Or Index Information")]
    [IsoXmlTag("BsktOrIndxInf")]
    public UpdatedAdditionalInformation10? BasketOrIndexInformation { get; init; }

    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    [IsoId("_c5pcGZKQEeWHWpTQn1FFVg")]
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    public UpdatedAdditionalInformation10? CertificationBreakdown { get; init; }
}
