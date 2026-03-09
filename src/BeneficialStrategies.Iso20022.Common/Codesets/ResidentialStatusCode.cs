// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the residential status of an individual.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZU0_Ydp-Ed-ak6NoX_4Aeg_-1411597800")]
[Description(@"Specifies the residential status of an individual.")]
[Derivations(typeof(ResidentialStatus1Code))]
public enum ResidentialStatusCode
{
    /// <summary>
    /// Resident.
    /// Encoded/decoded by serializers as &quot;RESI&quot;.
    /// </summary>
    [EnumMember(Value = "RESI")]
    [IsoId("_ZU0_Ytp-Ed-ak6NoX_4Aeg_-1093909086")]
    [Description(@"Resident.")]
    Resident,
    
    /// <summary>
    /// Permanent resident.
    /// Encoded/decoded by serializers as &quot;PRES&quot;.
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_ZU0_Y9p-Ed-ak6NoX_4Aeg_-1073588583")]
    [Description(@"Permanent resident.")]
    PermanentResident,
    
    /// <summary>
    /// Non-resident.
    /// Encoded/decoded by serializers as &quot;NRES&quot;.
    /// </summary>
    [EnumMember(Value = "NRES")]
    [IsoId("_ZU0_ZNp-Ed-ak6NoX_4Aeg_-1065279846")]
    [Description(@"Non-resident.")]
    NonResident,
    
}
