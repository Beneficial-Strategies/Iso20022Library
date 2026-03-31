// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of system service to be used with this message.
/// </summary>
[IsoId("_Oik1gQ1SEeqjM-rxn3HuXQ")]
[DisplayName("System Abort")]
public record SystemAbort3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Os-usQ1SEeqjM-rxn3HuXQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment75 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_Os-usw1SEeqjM-rxn3HuXQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Body of the Abort Request message.
    /// </summary>
    [IsoId("_Os-utQ1SEeqjM-rxn3HuXQ")]
    [DisplayName("System Abort")]
    [IsoXmlTag("SysAbrt")]
    public required AbortData2 SystemAbort { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_Os-utw1SEeqjM-rxn3HuXQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
