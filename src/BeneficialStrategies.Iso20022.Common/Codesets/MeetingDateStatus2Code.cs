// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a status for a meeting date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LBwHMK4oEemG7MmivSuE5g")]
[Description(@"Specifies a status for a meeting date.")]
[DerivedFrom(typeof(MeetingDateStatusCode))]
public enum MeetingDateStatus2Code
{
    /// <summary>
    /// Meeting date is confirmed.
    /// Encoded/decoded by serializers as &quot;CNFR&quot;.
    /// </summary>
    [EnumMember(Value = "CNFR")]
    [IsoId("_M6Qg8a4oEemG7MmivSuE5g")]
    [Description(@"Meeting date is confirmed.")]
    Confirmed = MeetingDateStatusCode.Confirmed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Meeting date is tentative.
    /// Encoded/decoded by serializers as &quot;TNTA&quot;.
    /// </summary>
    [EnumMember(Value = "TNTA")]
    [IsoId("_NIP5oq4oEemG7MmivSuE5g")]
    [Description(@"Meeting date is tentative.")]
    Tentative = MeetingDateStatusCode.Tentative, // same ordinal as derivation source for type conversions
    
}
