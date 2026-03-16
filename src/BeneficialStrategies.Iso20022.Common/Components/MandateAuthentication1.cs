// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the transport authentication details related to the mandate.
/// </summary>
[IsoId("_HSGqsGVVEeacpJ-gG9kyUQ")]
[DisplayName("Mandate Authentication")]
public record MandateAuthentication1
{
    /// <summary>
    /// Specifies a piece of information used to authenticate a message, that is to confirm that the message came from the stated sender (its authenticity) and has not been changed in transit (its integrity).
    /// </summary>
    [IsoId("_Tw5GoGVVEeacpJ-gG9kyUQ")]
    [DisplayName("Message Authentication Code")]
    [IsoXmlTag("MsgAuthntcnCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? MessageAuthenticationCode { get; init; }

    /// <summary>
    /// Date when the authentication was conducted.
    /// </summary>
    [IsoId("_Z4U-8GVVEeacpJ-gG9kyUQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Channel used to transmit the authentication information.
    /// </summary>
    [IsoId("_zsoqgGVVEeacpJ-gG9kyUQ")]
    [DisplayName("Channel")]
    [IsoXmlTag("Chanl")]
    public AuthenticationChannel1Choice_? Channel { get; init; }
}
