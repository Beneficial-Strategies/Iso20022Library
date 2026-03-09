// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the cancellation of the disclosure request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MbblYEV5EemRx7jyevcLwg")]
[Description(@"Specifies the reason for the cancellation of the disclosure request.")]
[DerivedFrom(typeof(DisclosureRequestCancellationReasonCode))]
public enum DisclosureRequestCancellationReason1Code
{
    /// <summary>
    /// The cancellation of the disclosure request is due to a processsing error.
    /// Encoded/decoded by serializers as &quot;PROC&quot;.
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_uyAM8UV5EemRx7jyevcLwg")]
    [Description(@"The cancellation of the disclosure request is due to a processsing error.")]
    Processing = DisclosureRequestCancellationReasonCode.Processing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The cancellation of the discolure request is due to the withdrawal of the request  by the issuer.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_u4Zv4UV5EemRx7jyevcLwg")]
    [Description(@"The cancellation of the discolure request is due to the withdrawal of the request  by the issuer.")]
    Withdrawal = DisclosureRequestCancellationReasonCode.Withdrawal, // same ordinal as derivation source for type conversions
    
}
