// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the source used to initiate the payment (such as an application or a software).
/// </summary>
[IsoId("_qBeboMQJEemsic1bQcEtLA")]
[DisplayName("Payment Initiation Source")]
public record PaymentInitiationSource1
{
    /// <summary>
    /// Name of the application or software used to initiate the payment.
    /// </summary>
    [IsoId("_7F6NAMQJEemsic1bQcEtLA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Name { get; init; }

    /// <summary>
    /// Provider of the application or software used to initiate the payment.
    /// </summary>
    [IsoId("_0kOosMQJEemsic1bQcEtLA")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Provider { get; init; }

    /// <summary>
    /// Version of the application or software used to initiate the payment.
    /// </summary>
    [IsoId("_ADKKIMQKEemsic1bQcEtLA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Version { get; init; }
}
