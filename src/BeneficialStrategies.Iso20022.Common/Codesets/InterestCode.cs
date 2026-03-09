// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates which type of interest is applied to a balance left on an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aZ-ChNp-Ed-ak6NoX_4Aeg_-657407757")]
[Description(@"Indicates which type of interest is applied to a balance left on an account.")]
[Derivations(typeof(InterestType1Code))]
public enum InterestCode
{
    /// <summary>
    /// During or within a business day.
    /// Encoded/decoded by serializers as &quot;INDY&quot;.
    /// </summary>
    [EnumMember(Value = "INDY")]
    [IsoId("_aZ-Chdp-Ed-ak6NoX_4Aeg_-376656461")]
    [Description(@"During or within a business day.")]
    IntraDay,
    
    /// <summary>
    /// Period of time between the end of a business day and the start of the next business day (usually the day after).
    /// Encoded/decoded by serializers as &quot;OVRN&quot;.
    /// </summary>
    [EnumMember(Value = "OVRN")]
    [IsoId("_aZ-Chtp-Ed-ak6NoX_4Aeg_-358184956")]
    [Description(@"Period of time between the end of a business day and the start of the next business day (usually the day after).")]
    OverNight,
    
}
