// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the separation of the security is optional or mandatory.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a_OEoNp-Ed-ak6NoX_4Aeg_-798981296")]
[Description(@"Specifies if the separation of the security is optional or mandatory.")]
public enum ChoiceCode
{
    /// <summary>
    /// Separation is optional.
    /// Encoded/decoded by serializers as &quot;OPTI&quot;.
    /// </summary>
    [EnumMember(Value = "OPTI")]
    [IsoId("_a_OEodp-Ed-ak6NoX_4Aeg_-736182104")]
    [Description(@"Separation is optional.")]
    Optional,
    
    /// <summary>
    /// Separation is mandatory.
    /// Encoded/decoded by serializers as &quot;MAND&quot;.
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_a_OEotp-Ed-ak6NoX_4Aeg_-698318667")]
    [Description(@"Separation is mandatory.")]
    Mandatory,
    
}
