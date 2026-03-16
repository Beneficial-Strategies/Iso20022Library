// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of settlement foreseen for the security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hblKlWliEeGaMcKyqKNRfQ_-582370355")]
[Description(@"Type of settlement foreseen for the security.")]
[DerivedFrom(typeof(SettlementUnitTypeCode))]
public enum SettlementUnitType1Code
{
    /// <summary>
    /// Represent the face amount, for example the principal of a debt instrument.
    /// Encoded/decoded by serializers as &quot;FAMT&quot;.
    /// </summary>
    [EnumMember(Value = "FAMT")]
    [IsoId("_hblKlmliEeGaMcKyqKNRfQ_40062376")]
    [Description(@"Represent the face amount, for example the principal of a debt instrument.")]
    FaceAmount = SettlementUnitTypeCode.FaceAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Represent the unit as a number, for example a number of shares.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_hblKl2liEeGaMcKyqKNRfQ_-1210061355")]
    [Description(@"Represent the unit as a number, for example a number of shares.")]
    Unit = SettlementUnitTypeCode.Unit, // same ordinal as derivation source for type conversions
}
