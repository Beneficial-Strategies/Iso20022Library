// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of place of safekeeping.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-xP0Np-Ed-ak6NoX_4Aeg_-664604106")]
[Description(@"Specifies the type of place of safekeeping.")]
[Derivations(
    typeof(SafekeepingPlace3Code),
    typeof(SafekeepingPlace1Code),
    typeof(SafekeepingPlace2Code)
)]
public enum SafekeepingPlaceCode
{
    /// <summary>
    /// Financial instruments held at a local custodian.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_Y-xP0dp-Ed-ak6NoX_4Aeg_-385698735")]
    [Description(@"Financial instruments held at a local custodian.")]
    SharesHeldAtLocalCustodian,

    /// <summary>
    /// Financial instruments held at an International Central Securities Depository.
    /// Encoded/decoded by serializers as &quot;ICSD&quot;.
    /// </summary>
    [EnumMember(Value = "ICSD")]
    [IsoId("_Y-xP0tp-Ed-ak6NoX_4Aeg_-385698683")]
    [Description(@"Financial instruments held at an International Central Securities Depository.")]
    SharesHeldAtICSD,

    /// <summary>
    /// Financial instruments held at a National Central Securities Depository.
    /// Encoded/decoded by serializers as &quot;NCSD&quot;.
    /// </summary>
    [EnumMember(Value = "NCSD")]
    [IsoId("_Y-xP09p-Ed-ak6NoX_4Aeg_-385698406")]
    [Description(@"Financial instruments held at a National Central Securities Depository.")]
    SharesHeldAtNCSD,

    /// <summary>
    /// Used for certain financial instruments, for example, US mutual funds, where settlement is internal only, that is, there is no external movement of securities.
    /// Encoded/decoded by serializers as &quot;SHHE&quot;.
    /// </summary>
    [EnumMember(Value = "SHHE")]
    [IsoId("_Y-xP1Np-Ed-ak6NoX_4Aeg_-1627115101")]
    [Description(
        @"Used for certain financial instruments, for example, US mutual funds, where settlement is internal only, that is, there is no external movement of securities."
    )]
    SharesHeldElsewhere,

    /// <summary>
    /// All places of safekeeping where the financial instrument is held.
    /// Encoded/decoded by serializers as &quot;ALLP&quot;.
    /// </summary>
    [EnumMember(Value = "ALLP")]
    [IsoId("_Y-xP1dp-Ed-ak6NoX_4Aeg_663786746")]
    [Description(@"All places of safekeeping where the financial instrument is held.")]
    AllPlaces,
}
