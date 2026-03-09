// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of a limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8J5r9qMgEeCJ6YNENx4h-w_-31027971")]
[Description(@"Specifies the current status of a limit.")]
[Derivations(typeof(ReservationStatus1Code))]
public enum ReservationStatusCode
{
    /// <summary>
    /// Reservation is currently in effect.
    /// Encoded/decoded by serializers as &quot;ENAB&quot;.
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_8J5r96MgEeCJ6YNENx4h-w_-144867037")]
    [Description(@"Reservation is currently in effect.")]
    Enabled,
    
    /// <summary>
    /// Reservation is not currently in effect.|.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_8J5r-KMgEeCJ6YNENx4h-w_-849981652")]
    [Description(@"Reservation is not currently in effect.|.")]
    Disabled,
    
    /// <summary>
    /// Reservation has been deleted or suspended.
    /// Encoded/decoded by serializers as &quot;DELD&quot;.
    /// </summary>
    [EnumMember(Value = "DELD")]
    [IsoId("_8KDc8KMgEeCJ6YNENx4h-w_-2025172677")]
    [Description(@"Reservation has been deleted or suspended.")]
    Deleted,
    
    /// <summary>
    /// Reservation has been asked for and is not yet enabled.|.
    /// Encoded/decoded by serializers as &quot;REQD&quot;.
    /// </summary>
    [EnumMember(Value = "REQD")]
    [IsoId("_8KDc8aMgEeCJ6YNENx4h-w_-379905242")]
    [Description(@"Reservation has been asked for and is not yet enabled.|.")]
    Requested,
    
    /// <summary>
    /// Reservation is blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as &quot;BLKD&quot;.
    /// </summary>
    [EnumMember(Value = "BLKD")]
    [IsoId("_8KDc8qMgEeCJ6YNENx4h-w_97212700")]
    [Description(@"Reservation is blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.")]
    Blocked,
    
}
