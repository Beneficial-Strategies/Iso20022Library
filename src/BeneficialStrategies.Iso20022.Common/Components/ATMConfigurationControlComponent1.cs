// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Configuration Control Component1.
/// </summary>
[IsoId("_TwK2sJ2kEe-4seDr3Li2Ew")]
[DisplayName("ATM Configuration Control Component1")]
public record ATMConfigurationControlComponent1
{
    /// <summary>
    /// Action Required.
    /// </summary>
    [DisplayName("Action Required")]
    [IsoXmlTag("ActnReqrd")]
    public required ATMActionType1Code ActionRequired { get; init; }

    /// <summary>
    /// Activation Date.
    /// </summary>
    [DisplayName("Activation Date")]
    [IsoXmlTag("ActvtnDt")]
    public IsoISODateTime? ActivationDate { get; init; }

    /// <summary>
    /// Configuration Version.
    /// </summary>
    [DisplayName("Configuration Version")]
    [IsoXmlTag("CfgtnVrsn")]
    public IsoMax35Text? ConfigurationVersion { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment7 Environment { get; init; }

    /// <summary>
    /// Property.
    /// </summary>
    [DisplayName("Property")]
    [IsoXmlTag("Prprty")]
    public ValueList<ATMPropertyComponent1> Property { get; init; } = [];
}
