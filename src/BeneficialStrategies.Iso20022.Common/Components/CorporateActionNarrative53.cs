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
[IsoId("_ptSzgzi7Eeydid5dcNPKvg")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative53
{
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_ptSzhzi7Eeydid5dcNPKvg")]
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public UpdatedAdditionalInformation5? AdditionalText { get; init; }

    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields of this message, - or narrative information not needed for automatic processing.
    /// </summary>
    [IsoId("_ptSzjzi7Eeydid5dcNPKvg")]
    [DisplayName("Narrative Version")]
    [IsoXmlTag("NrrtvVrsn")]
    public UpdatedAdditionalInformation5? NarrativeVersion { get; init; }

    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [IsoId("_ptSzlzi7Eeydid5dcNPKvg")]
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    public UpdatedAdditionalInformation5? InformationConditions { get; init; }

    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    [IsoId("_ptSznzi7Eeydid5dcNPKvg")]
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    public UpdatedAdditionalInformation5? InformationToComplyWith { get; init; }

    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_ptSzpzi7Eeydid5dcNPKvg")]
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public UpdatedAdditionalInformation5? TaxationConditions { get; init; }

    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_ptSzrzi7Eeydid5dcNPKvg")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public UpdatedAdditionalInformation5? Disclaimer { get; init; }

    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_ptSztzi7Eeydid5dcNPKvg")]
    [DisplayName("Party Contact Narrative")]
    [IsoXmlTag("PtyCtctNrrtv")]
    public UpdatedAdditionalInformation5? PartyContactNarrative { get; init; }

    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_ptSzvzi7Eeydid5dcNPKvg")]
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    public UpdatedAdditionalInformation5? RegistrationDetails { get; init; }

    /// <summary>
    /// Provides additional information on the basket or index underlying a security, for example a warrant.
    /// </summary>
    [IsoId("_ptSzxzi7Eeydid5dcNPKvg")]
    [DisplayName("Basket Or Index Information")]
    [IsoXmlTag("BsktOrIndxInf")]
    public UpdatedAdditionalInformation5? BasketOrIndexInformation { get; init; }

    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    [IsoId("_ptSzzzi7Eeydid5dcNPKvg")]
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    public UpdatedAdditionalInformation5? CertificationBreakdown { get; init; }

    /// <summary>
    /// Provides additional information from the account servicer or a service provider solely intended for the next immediate account holder to enable or facilitate event processing between parties.
    /// </summary>
    [IsoId("_ptSz0Ti7Eeydid5dcNPKvg")]
    [DisplayName("Processing Text For Next Intermediary")]
    [IsoXmlTag("PrcgTxtForNxtIntrmy")]
    public UpdatedAdditionalInformation1? ProcessingTextForNextIntermediary { get; init; }
}
