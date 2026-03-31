// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the registration details.
/// </summary>
[IsoId("_WZEY6Np-Ed-ak6NoX_4Aeg_1475713728")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative12
{
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_WZEY6dp-Ed-ak6NoX_4Aeg_-518430978")]
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public SimpleValueList<IsoRestrictedFINXMax350Text> AdditionalText { get; init; } = [];

    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields of this message, - or narrative information not needed for automatic processing.
    /// </summary>
    [IsoId("_WZEY6tp-Ed-ak6NoX_4Aeg_-1629342397")]
    [DisplayName("Narrative Version")]
    [IsoXmlTag("NrrtvVrsn")]
    public SimpleValueList<IsoRestrictedFINXMax350Text> NarrativeVersion { get; init; } = [];

    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_WZOJ4Np-Ed-ak6NoX_4Aeg_785319259")]
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    public SimpleValueList<IsoRestrictedFINXMax350Text> RegistrationDetails { get; init; } = [];

    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_WZOJ4dp-Ed-ak6NoX_4Aeg_1556661713")]
    [DisplayName("Party Contact Narrative")]
    [IsoXmlTag("PtyCtctNrrtv")]
    public SimpleValueList<IsoRestrictedFINXMax350Text> PartyContactNarrative { get; init; } = [];

    /// <summary>
    /// Disclaimer relative to the information provided in the message. It may be ignored for automated processing. No information about the instruction itself is allowed here.
    /// </summary>
    [IsoId("_WZOJ4tp-Ed-ak6NoX_4Aeg_445750294")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public SimpleValueList<IsoRestrictedFINXMax350Text> Disclaimer { get; init; } = [];

    /// <summary>
    /// Provides additional information on the basket or index underlying a security, for example a warrant.
    /// </summary>
    [IsoId("_WZOJ49p-Ed-ak6NoX_4Aeg_-1434555346")]
    [DisplayName("Basket Or Index Information")]
    [IsoXmlTag("BsktOrIndxInf")]
    public SimpleValueList<IsoRestrictedFINXMax350Text> BasketOrIndexInformation { get; init; } =
        [];
}
