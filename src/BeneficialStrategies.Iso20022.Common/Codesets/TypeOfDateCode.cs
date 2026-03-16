// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a date is actual or estimated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Oxs3y2-BEeKuY41pq1-dog")]
[Description(@"Specifies whether a date is actual or estimated.")]
[Derivations(typeof(TypeOfDate1Code))]
public enum TypeOfDateCode
{
    /// <summary>
    /// Date/date and time is estimated.
    /// Encoded/decoded by serializers as &quot;ESTM&quot;.
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_Oxs3zm-BEeKuY41pq1-dog")]
    [Description(@"Date/date and time is estimated.")]
    Estimated,

    /// <summary>
    /// Date / date and time is the actual date / date and time.
    /// Encoded/decoded by serializers as &quot;ACTL&quot;.
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_Oxs31W-BEeKuY41pq1-dog")]
    [Description(@"Date / date and time is the actual date / date and time.")]
    Actual,
}
