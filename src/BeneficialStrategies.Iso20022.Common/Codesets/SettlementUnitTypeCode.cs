// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of settlement foreseen for the security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hblKkmliEeGaMcKyqKNRfQ_601711854")]
[Description(@"Type of settlement foreseen for the security.")]
[Derivations(typeof(SettlementUnitType1Code))]
public enum SettlementUnitTypeCode
{
    /// <summary>
    /// Represent the face amount, for example the principal of a debt instrument.
    /// Encoded/decoded by serializers as &quot;FAMT&quot;.
    /// </summary>
    [EnumMember(Value = "FAMT")]
    [IsoId("_hblKk2liEeGaMcKyqKNRfQ_1606915778")]
    [Description(@"Represent the face amount, for example the principal of a debt instrument.")]
    FaceAmount,

    /// <summary>
    /// Represent the unit as a number, for example a number of shares.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_hblKlGliEeGaMcKyqKNRfQ_1719234918")]
    [Description(@"Represent the unit as a number, for example a number of shares.")]
    Unit,
}
