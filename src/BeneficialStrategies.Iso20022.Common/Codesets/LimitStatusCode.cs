// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of a limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aecS0tp-Ed-ak6NoX_4Aeg_231381284")]
[Description(@"Specifies the current status of a limit.")]
[Derivations(typeof(LimitStatus1Code))]
public enum LimitStatusCode
{
    /// <summary>
    /// Limit is currently in effect.
    /// Encoded/decoded by serializers as &quot;ENAB&quot;.
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_aecS09p-Ed-ak6NoX_4Aeg_231381285")]
    [Description(@"Limit is currently in effect.")]
    Enabled,
    
    /// <summary>
    /// Limit is not currently in effect.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_aecS1Np-Ed-ak6NoX_4Aeg_231381286")]
    [Description(@"Limit is not currently in effect.")]
    Disabled,
    
    /// <summary>
    /// Limit has been deleted or suspended.
    /// Encoded/decoded by serializers as &quot;DELD&quot;.
    /// </summary>
    [EnumMember(Value = "DELD")]
    [IsoId("_aecS1dp-Ed-ak6NoX_4Aeg_231381287")]
    [Description(@"Limit has been deleted or suspended.")]
    Deleted,
    
    /// <summary>
    /// Limit has been asked for and is not yet enabled.
    /// Encoded/decoded by serializers as &quot;REQD&quot;.
    /// </summary>
    [EnumMember(Value = "REQD")]
    [IsoId("_aecS1tp-Ed-ak6NoX_4Aeg_231381288")]
    [Description(@"Limit has been asked for and is not yet enabled.")]
    Requested,
    
}
