// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of securities lending contract.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__wINddojEeC60axPepSq7g_-966112118")]
[Description(@"Type of securities lending contract.")]
[Derivations(typeof(SecuritiesLendingType1Code))]
public enum SecuritiesLendingTypeCode
{
    /// <summary>
    /// Securities lending contract is new and registered.
    /// Encoded/decoded by serializers as &quot;NWRG&quot;.
    /// </summary>
    [EnumMember(Value = "NWRG")]
    [IsoId("__wR-cNojEeC60axPepSq7g_-1240739325")]
    [Description(@"Securities lending contract is new and registered.")]
    NewRegistration,
    
    /// <summary>
    /// Securities lending contract is renewed.
    /// Encoded/decoded by serializers as &quot;RENW&quot;.
    /// </summary>
    [EnumMember(Value = "RENW")]
    [IsoId("__wR-cdojEeC60axPepSq7g_1485509445")]
    [Description(@"Securities lending contract is renewed.")]
    RollOverRenewal,
    
    /// <summary>
    /// Securities lending contract is called back.
    /// Encoded/decoded by serializers as &quot;CABK&quot;.
    /// </summary>
    [EnumMember(Value = "CABK")]
    [IsoId("__wR-ctojEeC60axPepSq7g_-1557239976")]
    [Description(@"Securities lending contract is called back.")]
    CallBack,
    
}
