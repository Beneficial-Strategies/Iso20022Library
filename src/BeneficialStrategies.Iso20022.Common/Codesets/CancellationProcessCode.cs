// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Configuration of the exchanges to perform the cancellation of a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w2PhkB3nEeKWfegf-2AeBQ")]
[Description(
    @"Configuration of the exchanges to perform the cancellation of a payment transaction."
)]
[Derivations(typeof(CancellationProcess1Code), typeof(CancellationProcess2Code))]
public enum CancellationProcessCode
{
    /// <summary>
    /// Card payment transaction cannot be cancelled by the acquirer.
    /// Encoded/decoded by serializers as &quot;NALW&quot;.
    /// </summary>
    [EnumMember(Value = "NALW")]
    [IsoId("_DapQ4B3oEeKWfegf-2AeBQ")]
    [Description(@"Card payment transaction cannot be cancelled by the acquirer.")]
    NotAllowed,

    /// <summary>
    /// Card payment transaction may be cancelled by an advice only before closure of the reconciliation period or before the capture by batch.
    /// Encoded/decoded by serializers as &quot;ADVC&quot;.
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_H72yQB3oEeKWfegf-2AeBQ")]
    [Description(
        @"Card payment transaction may be cancelled by an advice only before closure of the reconciliation period or before the capture by batch."
    )]
    Advice,

    /// <summary>
    /// Card payment transaction may also be cancelled after the closure of the reconciliation period or after the capture by batch. In this case a cancellation request exchange is required.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_LWaNkB3oEeKWfegf-2AeBQ")]
    [Description(
        @"Card payment transaction may also be cancelled after the closure of the reconciliation period or after the capture by batch. In this case a cancellation request exchange is required."
    )]
    Request,

    /// <summary>
    /// Cancellation of the Card payment transaction is defined by the payment application.
    /// Encoded/decoded by serializers as &quot;APPL&quot;.
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_0TOPwAxsEeqdx6buGpCCQw")]
    [Description(
        @"Cancellation of the Card payment transaction is defined by the payment application."
    )]
    ApplicationLevel,
}
