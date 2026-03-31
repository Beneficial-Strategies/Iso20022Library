// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding the existing agent component.
/// </summary>
[IsoId("_bTHFYb5XEeexmbB7KsjCwA")]
[DisplayName("Party Identification SD")]
public record PartyIdentificationSD6
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_bjVSs75XEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// DTC agent identification number.
    /// </summary>
    [IsoId("_bjVStb5XEeexmbB7KsjCwA")]
    [DisplayName("Agent Identification")]
    [IsoXmlTag("AgtId")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoMax8Text? AgentIdentification { get; init; }

    /// <summary>
    /// Telephone number of the agent.
    /// </summary>
    [IsoId("_bjVSvb5XEeexmbB7KsjCwA")]
    [DisplayName("Agent Telephone Number")]
    [IsoXmlTag("AgtTelNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? AgentTelephoneNumber { get; init; }

    /// <summary>
    /// Agent designated contact information details.
    /// </summary>
    [IsoId("_bjVSxb5XEeexmbB7KsjCwA")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public PartyIdentificationSD4? ContactInformation { get; init; }

    /// <summary>
    /// Email address of the event agent.
    /// </summary>
    [IsoId("_bjVSzb5XEeexmbB7KsjCwA")]
    [DisplayName("Agent Email Address")]
    [IsoXmlTag("AgtEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AgentEmailAddress { get; init; }

    /// <summary>
    /// Event agent address.
    /// </summary>
    [IsoId("_bjVS1b5XEeexmbB7KsjCwA")]
    [DisplayName("Agent Address")]
    [IsoXmlTag("AgtAdr")]
    public PostalAddress1? AgentAddress { get; init; }
}
