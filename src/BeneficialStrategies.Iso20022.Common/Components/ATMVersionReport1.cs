// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Version Report1.
/// </summary>
[IsoId("_dtfQ4J2jEe-4seDr3Li2Ew")]
[DisplayName("ATM Version Report1")]
public partial record ATMVersionReport1
{
    #nullable enable

    /// <summary>
    /// Configuration Status.
    /// </summary>
    [DisplayName("Configuration Status")]
    [IsoXmlTag("CfgtnSts")]
    public required ActivationStatus2Code ConfigurationStatus { get; init; } 

    /// <summary>
    /// Configuration Version.
    /// </summary>
    [DisplayName("Configuration Version")]
    [IsoXmlTag("CfgtnVrsn")]
    public required IsoMax35Text ConfigurationVersion { get; init; } 

    /// <summary>
    /// Fail Reason.
    /// </summary>
    [DisplayName("Fail Reason")]
    [IsoXmlTag("FailRsn")]
    public IsoMax70Text? FailReason { get; init; } 

    
    #nullable disable
    
}
