// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of result after a media processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMMediaStatus1Code")]
[Description(@"Type of result after a media processing.")]
[DerivedFrom(typeof(ATMMediaStatusCode))]
public enum ATMMediaStatus1Code
{
    /// <summary>
    /// Item (such as a check) has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_ATMMediaStatus1Code_Accepted")]
    [Description(@"Item (such as a check) has been accepted.")]
    Accepted = ATMMediaStatusCode.Accepted,

    /// <summary>
    /// Item (such as a check) has been rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ATMMediaStatus1Code_Rejected")]
    [Description(@"Item (such as a check) has been rejected.")]
    Rejected = ATMMediaStatusCode.Rejected,

}
