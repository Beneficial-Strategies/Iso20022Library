// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZSJe2Np-Ed-ak6NoX_4Aeg_-2111038385")]
[Description(@"Specifies the status of a system.")]
[Derivations(typeof(SystemStatus2Code),typeof(SystemStatus3Code))]
public enum SystemStatusCode
{
    /// <summary>
    /// System is suspended, that is, not operational.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_ZSSowNp-Ed-ak6NoX_4Aeg_1625331815")]
    [Description(@"System is suspended, that is, not operational.")]
    Suspended,
    
    /// <summary>
    /// System is functioning normally, that is, operational.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ZSSowdp-Ed-ak6NoX_4Aeg_1625331816")]
    [Description(@"System is functioning normally, that is, operational.")]
    Active,
    
    /// <summary>
    /// System is closed (eg. normal closure of an RTGS).
    /// Encoded/decoded by serializers as &quot;CLSD&quot;.
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_ZSSowtp-Ed-ak6NoX_4Aeg_1391489559")]
    [Description(@"System is closed (eg. normal closure of an RTGS).")]
    Closed,
    
    /// <summary>
    /// System needs to wait for completion of intermediate internal activities before going to a status Closed.
    /// Encoded/decoded by serializers as &quot;CLSG&quot;.
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_ZSSow9p-Ed-ak6NoX_4Aeg_1391489836")]
    [Description(@"System needs to wait for completion of intermediate internal activities before going to a status Closed.")]
    Closing,
    
    /// <summary>
    /// System is starting a new maintenance period.
    /// Encoded/decoded by serializers as &quot;RMPS&quot;.
    /// </summary>
    [EnumMember(Value = "RMPS")]
    [IsoId("_JXo-AIpdEeiaB-4Hjqs8aw")]
    [Description(@"System is starting a new maintenance period.")]
    ReserveMaintenancePeriodStart,
    
}
