// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the collateral is to be delivered or returned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcMuRdp-Ed-ak6NoX_4Aeg_-662678761")]
[Description(@"Specifies if the collateral is to be delivered or returned.")]
[Derivations(typeof(DeliverReturn1Code))]
public enum DeliverReturnCode
{
    /// <summary>
    /// Specifies that the collateral is to be delivered.
    /// Encoded/decoded by serializers as &quot;DELV&quot;.
    /// </summary>
    [EnumMember(Value = "DELV")]
    [IsoId("_YcMuRtp-Ed-ak6NoX_4Aeg_-205401924")]
    [Description(@"Specifies that the collateral is to be delivered.")]
    Deliver,

    /// <summary>
    /// Specifies that the collateral is to be returned.
    /// Encoded/decoded by serializers as &quot;RETN&quot;.
    /// </summary>
    [EnumMember(Value = "RETN")]
    [IsoId("_YcMuR9p-Ed-ak6NoX_4Aeg_-272083435")]
    [Description(@"Specifies that the collateral is to be returned.")]
    Return,
}
