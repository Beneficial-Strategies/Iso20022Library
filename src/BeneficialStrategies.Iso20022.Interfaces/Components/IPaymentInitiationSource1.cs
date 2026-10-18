// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the source used to initiate the payment (such as an application or a software).
/// </summary>
[IsoId("_qBeboMQJEemsic1bQcEtLA")]
public interface IPaymentInitiationSource1 : IIsoComponent
{
    /// <summary>
    /// Name of the application or software used to initiate the payment.
    /// </summary>
    [IsoId("_7F6NAMQJEemsic1bQcEtLA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    IsoMax140Text Name { get; }

    /// <summary>
    /// Provider of the application or software used to initiate the payment.
    /// </summary>
    [IsoId("_0kOosMQJEemsic1bQcEtLA")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    IsoMax35Text? Provider { get; }

    /// <summary>
    /// Version of the application or software used to initiate the payment.
    /// </summary>
    [IsoId("_ADKKIMQKEemsic1bQcEtLA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    IsoMax35Text? Version { get; }
}
