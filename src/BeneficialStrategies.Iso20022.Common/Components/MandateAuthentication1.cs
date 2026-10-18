// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAuthentication1"/>
[IsoId("_HSGqsGVVEeacpJ-gG9kyUQ")]
[DisplayName("Mandate Authentication")]
public partial record MandateAuthentication1
{
    /// <inheritdoc cref="IMandateAuthentication1.MessageAuthenticationCode"/>
    [IsoId("_Tw5GoGVVEeacpJ-gG9kyUQ")]
    [DisplayName("Message Authentication Code")]
    [IsoXmlTag("MsgAuthntcnCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? MessageAuthenticationCode { get; init; }

    /// <inheritdoc cref="IMandateAuthentication1.Date"/>
    [IsoId("_Z4U-8GVVEeacpJ-gG9kyUQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <inheritdoc cref="IMandateAuthentication1.Channel"/>
    [IsoId("_zsoqgGVVEeacpJ-gG9kyUQ")]
    [DisplayName("Channel")]
    [IsoXmlTag("Chanl")]
    public AuthenticationChannel1Choice_? Channel { get; init; }
}
