// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional details on the remittance advice.
/// </summary>
[IsoId("_0KjnBTEyEe6g-ffJsqGiSA")]
public interface IRemittanceLocationData2 : IIsoComponent
{
    /// <summary>
    /// Electronic address to which an agent is to send the remittance information.
    /// </summary>
    [DisplayName("Electronic Address")]
    [IsoXmlTag("ElctrncAdr")]
    IsoMax2048Text? ElectronicAddress { get; }

    /// <summary>
    /// Method used to deliver the remittance advice information.
    /// </summary>
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    RemittanceLocationMethod2Code Method { get; }

    /// <summary>
    /// Postal address to which an agent is to send the remittance information.
    /// </summary>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    INameAndAddress18? PostalAddress { get; }
}
