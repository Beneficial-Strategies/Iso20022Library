// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for requesting the cancellation of a payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t9XiMVkyEeGeoaLUQk__nA_-362261816")]
[Description(@"Specifies the reason for requesting the cancellation of a payment instruction.")]
[DerivedFrom(typeof(CancellationReasonCode))]
public enum CancellationReason5Code
{
    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_t9XiMlkyEeGeoaLUQk__nA_866989928")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment = CancellationReasonCode.DuplicatePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_t9XiM1kyEeGeoaLUQk__nA_1747536954")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent = CancellationReasonCode.IncorrectAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Currency of the payment is incorrect.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_t9hTMFkyEeGeoaLUQk__nA_437357561")]
    [Description(@"Currency of the payment is incorrect.")]
    IncorrectCurrency = CancellationReasonCode.IncorrectCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation requested by the Debtor.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_t9hTMVkyEeGeoaLUQk__nA_323518495")]
    [Description(@"Cancellation requested by the Debtor.")]
    RequestedByCustomer = CancellationReasonCode.RequestedByCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_t9hTMlkyEeGeoaLUQk__nA_-197674285")]
    [Description(@"Payment is not justified.")]
    UnduePayment = CancellationReasonCode.UnduePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation requested because an investigation request has been received and no remediation is possible.
    /// Encoded/decoded by serializers as &quot;CUTA&quot;.
    /// </summary>
    [EnumMember(Value = "CUTA")]
    [IsoId("_t9hTM1kyEeGeoaLUQk__nA_-1129610805")]
    [Description(@"Cancellation requested because an investigation request has been received and no remediation is possible.")]
    CancelUponUnableToApply = CancellationReasonCode.CancelUponUnableToApply, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation requested following technical problems resulting in an erroneous transaction.
    /// Encoded/decoded by serializers as &quot;TECH&quot;.
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_t9hTNFkyEeGeoaLUQk__nA_228200151")]
    [Description(@"Cancellation requested following technical problems resulting in an erroneous transaction.")]
    TechnicalProblem = CancellationReasonCode.TechnicalProblem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.
    /// Encoded/decoded by serializers as &quot;FRAD&quot;.
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("_t9hTNVkyEeGeoaLUQk__nA_-1922346722")]
    [Description(@"Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.")]
    FraudulentOrigin = CancellationReasonCode.FraudulentOrigin, // same ordinal as derivation source for type conversions
    
}
