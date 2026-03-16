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
[IsoId("_x_UPfx9REeuFz_FaCzCLgQ")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative49
{
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_x_UPgx9REeuFz_FaCzCLgQ")]
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public ValueList<UpdatedAdditionalInformation16> AdditionalText { get; init; } = [];

    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields, - or narrative information not needed for automatic processing.
    /// </summary>
    [IsoId("_x_UPix9REeuFz_FaCzCLgQ")]
    [DisplayName("Narrative Version")]
    [IsoXmlTag("NrrtvVrsn")]
    public ValueList<UpdatedAdditionalInformation16> NarrativeVersion { get; init; } = [];

    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [IsoId("_x_UPkx9REeuFz_FaCzCLgQ")]
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    public ValueList<UpdatedAdditionalInformation16> InformationConditions { get; init; } = [];

    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    [IsoId("_x_UPmx9REeuFz_FaCzCLgQ")]
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    public ValueList<UpdatedAdditionalInformation16> InformationToComplyWith { get; init; } = [];

    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_x_UPox9REeuFz_FaCzCLgQ")]
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public ValueList<UpdatedAdditionalInformation16> TaxationConditions { get; init; } = [];

    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_x_UPqx9REeuFz_FaCzCLgQ")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public ValueList<UpdatedAdditionalInformation16> Disclaimer { get; init; } = [];

    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_x_UPsx9REeuFz_FaCzCLgQ")]
    [DisplayName("Party Contact Narrative")]
    [IsoXmlTag("PtyCtctNrrtv")]
    public ValueList<UpdatedAdditionalInformation16> PartyContactNarrative { get; init; } = [];

    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_x_UPux9REeuFz_FaCzCLgQ")]
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    public ValueList<UpdatedAdditionalInformation16> RegistrationDetails { get; init; } = [];

    /// <summary>
    /// Provides additional information on the basket or index underlying a security, for example a warrant.
    /// </summary>
    [IsoId("_x_UPwx9REeuFz_FaCzCLgQ")]
    [DisplayName("Basket Or Index Information")]
    [IsoXmlTag("BsktOrIndxInf")]
    public ValueList<UpdatedAdditionalInformation16> BasketOrIndexInformation { get; init; } = [];

    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    [IsoId("_x_UPyx9REeuFz_FaCzCLgQ")]
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    public ValueList<UpdatedAdditionalInformation16> CertificationBreakdown { get; init; } = [];

    /// <summary>
    /// Provides the web address published for the event, that is, the address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_x_UPzR9REeuFz_FaCzCLgQ")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public ValueList<UpdatedURLlnformation5> URLAddress { get; init; } = [];
}
