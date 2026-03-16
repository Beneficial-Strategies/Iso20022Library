// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the final status of a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8PRUJKMgEeCJ6YNENx4h-w_881009565")]
[Description(@"Specifies the final status of a transaction.")]
[DerivedFrom(typeof(PaymentInstructionStatusCode))]
public enum FinalStatus1Code
{
    /// <summary>
    /// Transaction has been successfully processed by the clearing agent.
    /// Encoded/decoded by serializers as &quot;STLD&quot;.
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_8PRUJaMgEeCJ6YNENx4h-w_-1768690296")]
    [Description(@"Transaction has been successfully processed by the clearing agent.")]
    Settled = PaymentInstructionStatusCode.Settled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been rejected by the clearing agent.
    /// Encoded/decoded by serializers as &quot;RJTD&quot;.
    /// </summary>
    [EnumMember(Value = "RJTD")]
    [IsoId("_8PRUJqMgEeCJ6YNENx4h-w_-116062788")]
    [Description(@"Transaction has been rejected by the clearing agent.")]
    Rejected = PaymentInstructionStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_8PRUJ6MgEeCJ6YNENx4h-w_-408020526")]
    [Description(@"Transaction has been cancelled.")]
    Cancelled = PaymentInstructionStatusCode.Cancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been successfully processed by the clearing agent. Settlement will take place outside of the system.
    /// Encoded/decoded by serializers as &quot;FNLD&quot;.
    /// </summary>
    [EnumMember(Value = "FNLD")]
    [IsoId("_8PaeEKMgEeCJ6YNENx4h-w_-229901854")]
    [Description(
        @"Transaction has been successfully processed by the clearing agent. Settlement will take place outside of the system."
    )]
    Finalised = PaymentInstructionStatusCode.Finalised, // same ordinal as derivation source for type conversions
}
