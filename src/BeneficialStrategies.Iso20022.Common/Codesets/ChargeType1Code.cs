// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of service for which a charge is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a9SK8dp-Ed-ak6NoX_4Aeg_1141943265")]
[Description(@"Type of service for which a charge is asked or paid.")]
[DerivedFrom(typeof(ChargeTypeCode))]
public enum ChargeType1Code
{
    /// <summary>
    /// Fee paid to a broker for services provided.
    /// Encoded/decoded by serializers as &quot;BRKF&quot;.
    /// </summary>
    [EnumMember(Value = "BRKF")]
    [IsoId("_a9SK8tp-Ed-ak6NoX_4Aeg_1912147156")]
    [Description(@"Fee paid to a broker for services provided.")]
    BrokerageFee = ChargeTypeCode.BrokerageFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fee paid for services provided.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_a9SK89p-Ed-ak6NoX_4Aeg_1922304879")]
    [Description(@"Fee paid for services provided.")]
    Commission = ChargeTypeCode.Commission, // same ordinal as derivation source for type conversions
}
