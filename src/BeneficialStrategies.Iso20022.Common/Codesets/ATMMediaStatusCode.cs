// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of result after a media processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMMediaStatusCode")]
[Description(@"Type of result after a media processing.")]
public enum ATMMediaStatusCode
{
    /// <summary>
    /// Item (such as a check) has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_ATMMediaStatusCode_Accepted")]
    [Description(@"Item (such as a check) has been accepted.")]
    Accepted,

    /// <summary>
    /// Item (such as a check) has been rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ATMMediaStatusCode_Rejected")]
    [Description(@"Item (such as a check) has been rejected.")]
    Rejected,
}
