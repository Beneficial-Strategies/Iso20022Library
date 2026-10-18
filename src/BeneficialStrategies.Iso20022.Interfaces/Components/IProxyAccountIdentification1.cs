// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a proxy  identification of the account.
/// </summary>
[IsoId("_luR59Xh2EeidzqjNEfehPg")]
public interface IProxyAccountIdentification1 : IIsoComponent
{
    /// <summary>
    /// Type of the proxy identification.
    /// </summary>
    [IsoId("_luR59nh2EeidzqjNEfehPg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IProxyAccountType1Choice? Type { get; }

    /// <summary>
    /// Identification used to indicate the account identification under another specified name.
    /// </summary>
    [IsoId("_luR593h2EeidzqjNEfehPg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IsoMax2048Text Identification { get; }
}
