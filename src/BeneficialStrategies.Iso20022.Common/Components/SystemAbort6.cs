// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of system service to be used with this message.
/// </summary>
[IsoId("_7Uu-EXJpEe299ZbWCkdR_w")]
[DisplayName("System Abort")]
public record SystemAbort6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_7bg7gXJpEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_7bg7g3JpEe299ZbWCkdR_w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; }

    /// <summary>
    /// Body of the Abort Request message.
    /// </summary>
    [IsoId("_7bg7hXJpEe299ZbWCkdR_w")]
    [DisplayName("System Abort")]
    [IsoXmlTag("SysAbrt")]
    public required AbortData5 SystemAbort { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_7bg7h3JpEe299ZbWCkdR_w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
