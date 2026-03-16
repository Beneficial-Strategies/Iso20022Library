// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an allegement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6eJ1kK3DEeeBVbuVcoH9Nw")]
[Description(@"Specifies the status of an allegement.")]
[DerivedFrom(typeof(AllegementStatusCode))]
public enum AllegementStatus2Code
{
    /// <summary>
    /// Allegement has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_75fyMa3DEeeBVbuVcoH9Nw")]
    [Description(@"Allegement has been accepted.")]
    Accepted = AllegementStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Allegement is pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_7_5VIa3DEeeBVbuVcoH9Nw")]
    [Description(@"Allegement is pending.")]
    Pending = AllegementStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction or report has been rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_8LgIMa3DEeeBVbuVcoH9Nw")]
    [Description(@"Transaction or report has been rejected.")]
    Rejected = AllegementStatusCode.Rejected, // same ordinal as derivation source for type conversions
}
