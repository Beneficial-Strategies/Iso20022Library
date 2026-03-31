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
[IsoId("_1SUrNTL3EeKU9IrkkToqcw_-650886899")]
[DisplayName("Party Identification SD")]
public record PartyIdentificationSD2
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1SUrNjL3EeKU9IrkkToqcw_-499458347")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// DTC agent identification number.
    /// </summary>
    [IsoId("_1SUrNzL3EeKU9IrkkToqcw_166499706")]
    [DisplayName("Agent Identification")]
    [IsoXmlTag("AgtId")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoMax8Text? AgentIdentification { get; init; }

    /// <summary>
    /// Telephone number of the agent.
    /// </summary>
    [IsoId("_1SecMDL3EeKU9IrkkToqcw_1493400736")]
    [DisplayName("Agent Telephone Number")]
    [IsoXmlTag("AgtTelNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? AgentTelephoneNumber { get; init; }

    /// <summary>
    /// Agent designated contact information details.
    /// </summary>
    [IsoId("_1SecMTL3EeKU9IrkkToqcw_2014524246")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public PartyIdentificationSD4? ContactInformation { get; init; }

    /// <summary>
    /// Email address of the event agent.
    /// </summary>
    [IsoId("_1SecMjL3EeKU9IrkkToqcw_1284201148")]
    [DisplayName("Agent Email Address")]
    [IsoXmlTag("AgtEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AgentEmailAddress { get; init; }

    /// <summary>
    /// Event agent address.
    /// </summary>
    [IsoId("_1SecMzL3EeKU9IrkkToqcw_-600131637")]
    [DisplayName("Agent Address")]
    [IsoXmlTag("AgtAdr")]
    public PostalAddress1? AgentAddress { get; init; }
}
