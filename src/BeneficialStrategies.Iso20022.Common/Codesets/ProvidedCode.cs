// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether items have been provided.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5IF6kxKEEeKj15WxqwlXPw")]
[Description(@"Specifies whether items have been provided.")]
[Derivations(typeof(Provided1Code))]
public enum ProvidedCode
{
    /// <summary>
    /// Provided.
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_EOnjEBKFEeKj15WxqwlXPw")]
    [Description(@"Provided.")]
    Provided,
    
    /// <summary>
    /// Not provided.
    /// Encoded/decoded by serializers as &quot;NPRO&quot;.
    /// </summary>
    [EnumMember(Value = "NPRO")]
    [IsoId("_EiSF8BKFEeKj15WxqwlXPw")]
    [Description(@"Not provided.")]
    NotProvided,
    
}
