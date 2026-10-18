// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceLocationData2"/>
[IsoId("_0KjnBTEyEe6g-ffJsqGiSA")]
[Description(@"Provides additional details on the remittance advice.")]
[DisplayName("Remittance Location Data2")]
public partial record RemittanceLocationData2
{
    /// <inheritdoc cref="IRemittanceLocationData2.ElectronicAddress"/>
    [DisplayName("Electronic Address")]
    [IsoXmlTag("ElctrncAdr")]
    public IsoMax2048Text? ElectronicAddress { get; init; }

    /// <inheritdoc cref="IRemittanceLocationData2.Method"/>
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public required RemittanceLocationMethod2Code Method { get; init; }

    /// <inheritdoc cref="IRemittanceLocationData2.PostalAddress"/>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public NameAndAddress18? PostalAddress { get; init; }
}
