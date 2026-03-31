// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_ioFTkY-2Eeaoj_JbcpWKgg")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount155
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [IsoId("_i2XAJY-2Eeaoj_JbcpWKgg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification117Choice_ Identification { get; init; }

    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_i2XALY-2Eeaoj_JbcpWKgg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_i2XANY-2Eeaoj_JbcpWKgg")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification8? AlternateIdentification { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_i2XAPY-2Eeaoj_JbcpWKgg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SafekeepingAccount { get; init; }
}
