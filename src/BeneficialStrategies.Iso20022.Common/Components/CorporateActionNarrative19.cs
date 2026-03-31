// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the information conditions.
/// </summary>
[IsoId("_WbKDmNp-Ed-ak6NoX_4Aeg_1685038746")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative19
{
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_WbKDmdp-Ed-ak6NoX_4Aeg_-309105960")]
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public SimpleValueList<IsoRestrictedFINXMax350Text> AdditionalText { get; init; } = [];

    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_WbKDmtp-Ed-ak6NoX_4Aeg_2105555696")]
    [DisplayName("Party Contact Narrative")]
    [IsoXmlTag("PtyCtctNrrtv")]
    public SimpleValueList<IsoRestrictedFINXMax350Text> PartyContactNarrative { get; init; } = [];
}
