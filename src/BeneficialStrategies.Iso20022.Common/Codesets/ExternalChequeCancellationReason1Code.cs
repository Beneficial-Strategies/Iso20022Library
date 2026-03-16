// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external cheque cancellation reason code in the format of character string with a maximum length of 4 characters.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5ApoQrtwEeq_cfXrH83Rcw")]
[Description(
    @"Specifies the external cheque cancellation reason code in the format of character string with a maximum length of 4 characters."
)]
[DerivedFrom(typeof(ExternalChequeCancellationReasonCode))]
public enum ExternalChequeCancellationReason1Code
{
    /// <summary>
    /// Customer requested to stop/cancel the cheque.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("")]
    [Description(@"Customer requested to stop/cancel the cheque.")]
    RequestedByCustomer = ExternalChequeCancellationReasonCode.RequestedByCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque has been issued in duplication of another cheque.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("")]
    [Description(@"Cheque has been issued in duplication of another cheque.")]
    Duplicate = ExternalChequeCancellationReasonCode.Duplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque has been issued fraudulently.
    /// Encoded/decoded by serializers as &quot;FRAD&quot;.
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("")]
    [Description(@"Cheque has been issued fraudulently.")]
    Fraud = ExternalChequeCancellationReasonCode.Fraud, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque has been stolen/lost.
    /// Encoded/decoded by serializers as &quot;LOST&quot;.
    /// </summary>
    [EnumMember(Value = "LOST")]
    [IsoId("")]
    [Description(@"Cheque has been stolen/lost.")]
    Lost = ExternalChequeCancellationReasonCode.Lost, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is provided as narrative information in the additional reason information field.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("")]
    [Description(
        @"Reason is provided as narrative information in the additional reason information field."
    )]
    Narrative = ExternalChequeCancellationReasonCode.Narrative, // same ordinal as derivation source for type conversions
}
