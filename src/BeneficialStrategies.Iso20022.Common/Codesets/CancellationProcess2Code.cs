// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Configuration of the exchanges to perform the cancellation of a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wZ0M8Qu2Eeq4I6UJxZQ2Qw")]
[Description(@"Configuration of the exchanges to perform the cancellation of a payment transaction.")]
[DerivedFrom(typeof(CancellationProcessCode))]
public enum CancellationProcess2Code
{
    /// <summary>
    /// Card payment transaction may be cancelled by an advice only before closure of the reconciliation period or before the capture by batch.
    /// Encoded/decoded by serializers as &quot;ADVC&quot;.
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_wlXVoQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Card payment transaction may be cancelled by an advice only before closure of the reconciliation period or before the capture by batch.")]
    Advice = CancellationProcessCode.Advice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card payment transaction cannot be cancelled by the acquirer.
    /// Encoded/decoded by serializers as &quot;NALW&quot;.
    /// </summary>
    [EnumMember(Value = "NALW")]
    [IsoId("_wlXVowu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Card payment transaction cannot be cancelled by the acquirer.")]
    NotAllowed = CancellationProcessCode.NotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card payment transaction may also be cancelled after the closure of the reconciliation period or after the capture by batch. In this case a cancellation request exchange is required.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_wlXVpQu2Eeq4I6UJxZQ2Qw")]
    [Description(@"Card payment transaction may also be cancelled after the closure of the reconciliation period or after the capture by batch. In this case a cancellation request exchange is required.")]
    Request = CancellationProcessCode.Request, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation of the Card payment transaction is defined by the payment application.
    /// Encoded/decoded by serializers as &quot;APPL&quot;.
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_EFxigQxtEeqdx6buGpCCQw")]
    [Description(@"Cancellation of the Card payment transaction is defined by the payment application.")]
    ApplicationLevel = CancellationProcessCode.ApplicationLevel, // same ordinal as derivation source for type conversions
    
}
