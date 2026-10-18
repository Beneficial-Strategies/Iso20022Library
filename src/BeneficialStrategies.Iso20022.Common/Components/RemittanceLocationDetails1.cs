// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceLocationDetails1"/>
[IsoId("_IcMu4aJxEeK9W_i6uXeloA")]
[DisplayName("Remittance Location Details")]
public partial record RemittanceLocationDetails1
{
    /// <inheritdoc cref="IRemittanceLocationDetails1.Method"/>
    [IsoId("_IpKM2aJxEeK9W_i6uXeloA")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public required RemittanceLocationMethod2Code Method { get; init; }

    /// <inheritdoc cref="IRemittanceLocationDetails1.ElectronicAddress"/>
    [IsoId("_IpKM3aJxEeK9W_i6uXeloA")]
    [DisplayName("Electronic Address")]
    [IsoXmlTag("ElctrncAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? ElectronicAddress { get; init; }

    /// <inheritdoc cref="IRemittanceLocationDetails1.PostalAddress"/>
    [IsoId("_IpKM4aJxEeK9W_i6uXeloA")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public NameAndAddress10? PostalAddress { get; init; }
}
