// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of place of safekeeping.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-eU59p-Ed-ak6NoX_4Aeg_1551577154")]
[Description(@"Specifies the type of place of safekeeping.")]
[DerivedFrom(typeof(SafekeepingPlaceCode))]
public enum SafekeepingPlace1Code
{
    /// <summary>
    /// Financial instruments held at a local custodian.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_Y-oF4Np-Ed-ak6NoX_4Aeg_-532747937")]
    [Description(@"Financial instruments held at a local custodian.")]
    SharesHeldAtLocalCustodian = SafekeepingPlaceCode.SharesHeldAtLocalCustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments held at an International Central Securities Depository.
    /// Encoded/decoded by serializers as &quot;ICSD&quot;.
    /// </summary>
    [EnumMember(Value = "ICSD")]
    [IsoId("_Y-oF4dp-Ed-ak6NoX_4Aeg_-495806728")]
    [Description(@"Financial instruments held at an International Central Securities Depository.")]
    SharesHeldAtICSD = SafekeepingPlaceCode.SharesHeldAtICSD, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments held at a National Central Securities Depository.
    /// Encoded/decoded by serializers as &quot;NCSD&quot;.
    /// </summary>
    [EnumMember(Value = "NCSD")]
    [IsoId("_Y-oF4tp-Ed-ak6NoX_4Aeg_279949982")]
    [Description(@"Financial instruments held at a National Central Securities Depository.")]
    SharesHeldAtNCSD = SafekeepingPlaceCode.SharesHeldAtNCSD, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used for certain financial instruments, for example, US mutual funds, where settlement is internal only, that is, there is no external movement of securities.
    /// Encoded/decoded by serializers as &quot;SHHE&quot;.
    /// </summary>
    [EnumMember(Value = "SHHE")]
    [IsoId("_Y-oF49p-Ed-ak6NoX_4Aeg_-1284489900")]
    [Description(
        @"Used for certain financial instruments, for example, US mutual funds, where settlement is internal only, that is, there is no external movement of securities."
    )]
    SharesHeldElsewhere = SafekeepingPlaceCode.SharesHeldElsewhere, // same ordinal as derivation source for type conversions
}
