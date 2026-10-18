// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the transport authentication details related to the mandate.
/// </summary>
[IsoId("_HSGqsGVVEeacpJ-gG9kyUQ")]
public interface IMandateAuthentication1 : IIsoComponent
{
    /// <summary>
    /// Specifies a piece of information used to authenticate a message, that is to confirm that the message came from the stated sender (its authenticity) and has not been changed in transit (its integrity).
    /// </summary>
    [IsoId("_Tw5GoGVVEeacpJ-gG9kyUQ")]
    [DisplayName("Message Authentication Code")]
    [IsoXmlTag("MsgAuthntcnCd")]
    IsoMax16Text? MessageAuthenticationCode { get; }

    /// <summary>
    /// Date when the authentication was conducted.
    /// </summary>
    [IsoId("_Z4U-8GVVEeacpJ-gG9kyUQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    IsoISODate? Date { get; }

    /// <summary>
    /// Channel used to transmit the authentication information.
    /// </summary>
    [IsoId("_zsoqgGVVEeacpJ-gG9kyUQ")]
    [DisplayName("Channel")]
    [IsoXmlTag("Chanl")]
    IAuthenticationChannel1Choice? Channel { get; }
}
