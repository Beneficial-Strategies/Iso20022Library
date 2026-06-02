// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the device.
/// </summary>
[IsoId("_fx_H8XbbEfCmC4yYaU27Kg")]
[DisplayName("Device Identification2")]
public record DeviceIdentification2
{
    /// <summary>
    /// Type of device. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_f1IikXbbEfCmC4yYaU27Kg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public DeviceIdentificationType2Code? Type { get; init; }

    /// <summary>
    /// Identifier of the device.
    /// </summary>
    [IsoId("_f1IilXbbEfCmC4yYaU27Kg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax70Text? Identification { get; init; }

    /// <summary>
    /// Entity that assigned the identification.
    /// </summary>
    [IsoId("_f1Iil3bbEfCmC4yYaU27Kg")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public IsoMax70Text? Assigner { get; init; }
}
