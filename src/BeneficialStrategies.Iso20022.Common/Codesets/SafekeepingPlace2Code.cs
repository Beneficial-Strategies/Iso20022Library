// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of place of safekeeping.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-oF5Np-Ed-ak6NoX_4Aeg_1138474587")]
[Description(@"Specifies the type of place of safekeeping.")]
[DerivedFrom(typeof(SafekeepingPlaceCode))]
public enum SafekeepingPlace2Code
{
    /// <summary>
    /// Used for certain financial instruments, for example, US mutual funds, where settlement is internal only, that is, there is no external movement of securities.
    /// Encoded/decoded by serializers as &quot;SHHE&quot;.
    /// </summary>
    [EnumMember(Value = "SHHE")]
    [IsoId("_Y-oF5dp-Ed-ak6NoX_4Aeg_1256685256")]
    [Description(
        @"Used for certain financial instruments, for example, US mutual funds, where settlement is internal only, that is, there is no external movement of securities."
    )]
    SharesHeldElsewhere = SafekeepingPlaceCode.SharesHeldElsewhere, // same ordinal as derivation source for type conversions

    /// <summary>
    /// All places of safekeeping where the financial instrument is held.
    /// Encoded/decoded by serializers as &quot;ALLP&quot;.
    /// </summary>
    [EnumMember(Value = "ALLP")]
    [IsoId("_Y-oF5tp-Ed-ak6NoX_4Aeg_1256685274")]
    [Description(@"All places of safekeeping where the financial instrument is held.")]
    AllPlaces = SafekeepingPlaceCode.AllPlaces, // same ordinal as derivation source for type conversions
}
