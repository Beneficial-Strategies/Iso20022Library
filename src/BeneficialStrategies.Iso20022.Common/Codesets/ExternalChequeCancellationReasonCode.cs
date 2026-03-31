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
[IsoId("_5ApoQ7twEeq_cfXrH83Rcw")]
[Description(
    @"Specifies the external cheque cancellation reason code in the format of character string with a maximum length of 4 characters."
)]
[Derivations(typeof(ExternalChequeCancellationReason1Code))]
public enum ExternalChequeCancellationReasonCode
{
    /// <summary>
    /// Customer requested to stop/cancel the cheque.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("")]
    [Description(@"Customer requested to stop/cancel the cheque.")]
    RequestedByCustomer,

    /// <summary>
    /// Cheque has been issued in duplication of another cheque.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("")]
    [Description(@"Cheque has been issued in duplication of another cheque.")]
    Duplicate,

    /// <summary>
    /// Cheque has been issued fraudulently.
    /// Encoded/decoded by serializers as &quot;FRAD&quot;.
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("")]
    [Description(@"Cheque has been issued fraudulently.")]
    Fraud,

    /// <summary>
    /// Cheque has been stolen/lost.
    /// Encoded/decoded by serializers as &quot;LOST&quot;.
    /// </summary>
    [EnumMember(Value = "LOST")]
    [IsoId("")]
    [Description(@"Cheque has been stolen/lost.")]
    Lost,

    /// <summary>
    /// Reason is provided as narrative information in the additional reason information field.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("")]
    [Description(
        @"Reason is provided as narrative information in the additional reason information field."
    )]
    Narrative,
}
