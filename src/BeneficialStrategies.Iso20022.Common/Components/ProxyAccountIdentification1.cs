// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a proxy  identification of the account.
/// </summary>
[IsoId("_luR59Xh2EeidzqjNEfehPg")]
[DisplayName("Proxy Account Identification")]
public record ProxyAccountIdentification1
{
    /// <summary>
    /// Type of the proxy identification.
    /// </summary>
    [IsoId("_luR59nh2EeidzqjNEfehPg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ProxyAccountType1Choice_? Type { get; init; }

    /// <summary>
    /// Identification used to indicate the account identification under another specified name.
    /// </summary>
    [IsoId("_luR593h2EeidzqjNEfehPg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public required IsoMax2048Text Identification { get; init; }
}
