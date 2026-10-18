// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the remittance advice.
/// </summary>
[IsoId("_IcMu4aJxEeK9W_i6uXeloA")]
public interface IRemittanceLocationDetails1 : IIsoComponent
{
    /// <summary>
    /// Method used to deliver the remittance advice information.
    /// </summary>
    [IsoId("_IpKM2aJxEeK9W_i6uXeloA")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    RemittanceLocationMethod2Code Method { get; }

    /// <summary>
    /// Electronic address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_IpKM3aJxEeK9W_i6uXeloA")]
    [DisplayName("Electronic Address")]
    [IsoXmlTag("ElctrncAdr")]
    Max2048Text? ElectronicAddress { get; }

    /// <summary>
    /// Postal address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_IpKM4aJxEeK9W_i6uXeloA")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    INameAndAddress10? PostalAddress { get; }
}
