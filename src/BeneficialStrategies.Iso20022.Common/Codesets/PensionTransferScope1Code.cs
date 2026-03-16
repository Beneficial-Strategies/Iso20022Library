// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the scope of a pension transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5Ej7kE4YEeiQHa-q1Uephw")]
[Description(@"Specifies the scope of a pension transfer.")]
[DerivedFrom(typeof(PensionTransferScopeCode))]
public enum PensionTransferScope1Code
{
    /// <summary>
    /// Transfer is for the crystallised portion.
    /// Encoded/decoded by serializers as &quot;CRYS&quot;.
    /// </summary>
    [EnumMember(Value = "CRYS")]
    [IsoId("_6W9-oU4YEeiQHa-q1Uephw")]
    [Description(@"Transfer is for the crystallised portion.")]
    CrystallisedPart = PensionTransferScopeCode.CrystallisedPart, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer is for a specific drawdown tranche.
    /// Encoded/decoded by serializers as &quot;SDDT&quot;.
    /// </summary>
    [EnumMember(Value = "SDDT")]
    [IsoId("_6b_okU4YEeiQHa-q1Uephw")]
    [Description(@"Transfer is for a specific drawdown tranche.")]
    DrawdownTranche = PensionTransferScopeCode.DrawdownTranche, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer is for the full pension.
    /// Encoded/decoded by serializers as &quot;FULP&quot;.
    /// </summary>
    [EnumMember(Value = "FULP")]
    [IsoId("_6hnvcU4YEeiQHa-q1Uephw")]
    [Description(@"Transfer is for the full pension.")]
    FullPension = PensionTransferScopeCode.FullPension, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer is for the uncrystallised portion.
    /// Encoded/decoded by serializers as &quot;UCRY&quot;.
    /// </summary>
    [EnumMember(Value = "UCRY")]
    [IsoId("_6lp64U4YEeiQHa-q1Uephw")]
    [Description(@"Transfer is for the uncrystallised portion.")]
    UncrystallisedPart = PensionTransferScopeCode.UncrystallisedPart, // same ordinal as derivation source for type conversions
}
