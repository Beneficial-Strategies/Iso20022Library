// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates how a date is adjusted when it falls on a non-business day.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bVIDONp-Ed-ak6NoX_4Aeg_627416389")]
[Description(@"Indicates how a date is adjusted when it falls on a non-business day.")]
[Derivations(typeof(BusinessDayConvention1Code))]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum BusinessDayConventionCode
{
    /// <summary>
    /// The date will be the first following day that is a business day.
    /// Encoded/decoded by serializers as &quot;FWNG&quot;.
    /// </summary>
    [EnumMember(Value = "FWNG")]
    [IsoId("_bVR0MNp-Ed-ak6NoX_4Aeg_627416390")]
    [Description(@"The date will be the first following day that is a business day.")]
    Following,
    
    /// <summary>
    /// The date will be the first following day that is a business day unless that day falls in the next calendar month, in which case that date will be the first preceding day that is a business day.
    /// Encoded/decoded by serializers as &quot;MODF&quot;.
    /// </summary>
    [EnumMember(Value = "MODF")]
    [IsoId("_bVR0Mdp-Ed-ak6NoX_4Aeg_627416391")]
    [Description(@"The date will be the first following day that is a business day unless that day falls in the next calendar month, in which case that date will be the first preceding day that is a business day.")]
    ModifiedFollowing,
    
    /// <summary>
    /// The date will be the first preceding day that is a business day.
    /// Encoded/decoded by serializers as &quot;PREC&quot;.
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_bVR0Mtp-Ed-ak6NoX_4Aeg_627416400")]
    [Description(@"The date will be the first preceding day that is a business day.")]
    Preceding,
    
    /// <summary>
    /// The date will be the first preceding day that is a business day unless that day falls on a day other than a sunday or a monday, and will be the first following day that is a business day, if the relevant date otherwise falls on a sunday or a monday.
    /// Encoded/decoded by serializers as &quot;NEAR&quot;.
    /// </summary>
    [EnumMember(Value = "NEAR")]
    [IsoId("_bVR0M9p-Ed-ak6NoX_4Aeg_627416407")]
    [Description(@"The date will be the first preceding day that is a business day unless that day falls on a day other than a sunday or a monday, and will be the first following day that is a business day, if the relevant date otherwise falls on a sunday or a monday.")]
    Nearest,
    
    /// <summary>
    /// Any other business day convention.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_uUXrwCibEemeS_hzZ1Fwog")]
    [Description(@"Any other business day convention.")]
    Other,
    
}
