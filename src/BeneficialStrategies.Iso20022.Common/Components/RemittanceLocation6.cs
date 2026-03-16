// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the remittance advice.
/// </summary>
[IsoId("_9B7YUW4-EeiU9cctagi5ow")]
[DisplayName("Remittance Location")]
public record RemittanceLocation6
{
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the remittance information sent separately from the payment instruction, such as a remittance advice.
    /// </summary>
    [IsoId("_9MDks24-EeiU9cctagi5ow")]
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RemittanceIdentification { get; init; }

    /// <summary>
    /// Method used to deliver the remittance advice information.
    /// </summary>
    [IsoId("_9MDktW4-EeiU9cctagi5ow")]
    [DisplayName("Remittance Location Method")]
    [IsoXmlTag("RmtLctnMtd")]
    public RemittanceLocationMethod2Code? RemittanceLocationMethod { get; init; }

    /// <summary>
    /// Electronic address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_9MDkt24-EeiU9cctagi5ow")]
    [DisplayName("Remittance Location Electronic Address")]
    [IsoXmlTag("RmtLctnElctrncAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? RemittanceLocationElectronicAddress { get; init; }

    /// <summary>
    /// Postal address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_9MDkuW4-EeiU9cctagi5ow")]
    [DisplayName("Remittance Location Postal Address")]
    [IsoXmlTag("RmtLctnPstlAdr")]
    public NameAndAddress16? RemittanceLocationPostalAddress { get; init; }
}
