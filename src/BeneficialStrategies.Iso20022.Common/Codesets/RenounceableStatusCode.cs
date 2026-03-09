// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the renounceable status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zsq3otp-Ed-ak6NoX_4Aeg_159300519")]
[Description(@"Specifies the renounceable status.")]
[Derivations(typeof(RenounceableStatus1Code))]
public enum RenounceableStatusCode
{
    /// <summary>
    /// Intermediate securities cannot be sold.
    /// Encoded/decoded by serializers as &quot;NREN&quot;.
    /// </summary>
    [EnumMember(Value = "NREN")]
    [IsoId("_Zsq3o9p-Ed-ak6NoX_4Aeg_175924753")]
    [Description(@"Intermediate securities cannot be sold.")]
    NonRenounceable,
    
    /// <summary>
    /// Intermediate securities can be sold.
    /// Encoded/decoded by serializers as &quot;RENO&quot;.
    /// </summary>
    [EnumMember(Value = "RENO")]
    [IsoId("_Zsq3pNp-Ed-ak6NoX_4Aeg_175924784")]
    [Description(@"Intermediate securities can be sold.")]
    Renounceable,
    
}
