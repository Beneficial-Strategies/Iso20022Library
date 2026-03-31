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
[IsoId("_WZq109p-Ed-ak6NoX_4Aeg_-1678570919")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative16
{
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_WZq11Np-Ed-ak6NoX_4Aeg_800370343")]
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public UpdatedAdditionalInformation5? AdditionalText { get; init; }

    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields of this message, - or narrative information not needed for automatic processing.
    /// </summary>
    [IsoId("_WZq11dp-Ed-ak6NoX_4Aeg_-2077007650")]
    [DisplayName("Narrative Version")]
    [IsoXmlTag("NrrtvVrsn")]
    public UpdatedAdditionalInformation5? NarrativeVersion { get; init; }

    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [IsoId("_WZq11tp-Ed-ak6NoX_4Aeg_109975874")]
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    public UpdatedAdditionalInformation5? InformationConditions { get; init; }

    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    [IsoId("_WZq119p-Ed-ak6NoX_4Aeg_-729109793")]
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    public UpdatedAdditionalInformation5? InformationToComplyWith { get; init; }

    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_WZq12Np-Ed-ak6NoX_4Aeg_574640444")]
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public UpdatedAdditionalInformation5? TaxationConditions { get; init; }

    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_WZq12dp-Ed-ak6NoX_4Aeg_1878390681")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public UpdatedAdditionalInformation5? Disclaimer { get; init; }

    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_WZq12tp-Ed-ak6NoX_4Aeg_-998987312")]
    [DisplayName("Party Contact Narrative")]
    [IsoXmlTag("PtyCtctNrrtv")]
    public UpdatedAdditionalInformation5? PartyContactNarrative { get; init; }

    /// <summary>
    /// Provides declaration details narrative relative to the financial instrument, for example, beneficial ownership.
    /// </summary>
    [IsoId("_WZq129p-Ed-ak6NoX_4Aeg_1187996212")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    public UpdatedAdditionalInformation5? DeclarationDetails { get; init; }

    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_WZz_wNp-Ed-ak6NoX_4Aeg_-1803220847")]
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    public UpdatedAdditionalInformation5? RegistrationDetails { get; init; }

    /// <summary>
    /// Provides additional information on the basket or index underlying a security, for example a warrant.
    /// </summary>
    [IsoId("_WZz_wdp-Ed-ak6NoX_4Aeg_505647463")]
    [DisplayName("Basket Or Index Information")]
    [IsoXmlTag("BsktOrIndxInf")]
    public UpdatedAdditionalInformation5? BasketOrIndexInformation { get; init; }
}
