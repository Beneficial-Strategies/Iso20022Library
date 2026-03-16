// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the fractional security handling rule that does not have an ISO value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1rgnRDL3EeKU9IrkkToqcw_1341412333")]
[Description(@"Specifies the fractional security handling rule that does not have an ISO value.")]
[DerivedFrom(typeof(FractionalSecurityRuleCode))]
public enum FractionalSecurityRule1Code
{
    /// <summary>
    /// Round Up x and above on the beneficial owner fractions, where x is the rounding factor. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.
    /// Encoded/decoded by serializers as &quot;BORU&quot;.
    /// </summary>
    [EnumMember(Value = "BORU")]
    [IsoId("_1rgnRTL3EeKU9IrkkToqcw_1498659018")]
    [Description(
        @"Round Up x and above on the beneficial owner fractions, where x is the rounding factor. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down."
    )]
    BeneficialOwnerRoundUpXAndAbove = FractionalSecurityRuleCode.BeneficialOwnerRoundUpXAndAbove, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash in Lieu on the beneficial owner fractions.
    /// Encoded/decoded by serializers as &quot;BCIL&quot;.
    /// </summary>
    [EnumMember(Value = "BCIL")]
    [IsoId("_1rqYQDL3EeKU9IrkkToqcw_1487560241")]
    [Description(@"Cash in Lieu on the beneficial owner fractions.")]
    BeneficialOwnerCashInLieu = FractionalSecurityRuleCode.BeneficialOwnerCashInLieu, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Round Down x and below beneficial owner fractions, where x is the rounding factor. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.
    /// Encoded/decoded by serializers as &quot;BORD&quot;.
    /// </summary>
    [EnumMember(Value = "BORD")]
    [IsoId("_1rqYQTL3EeKU9IrkkToqcw_1373721175")]
    [Description(
        @"Round Down x and below beneficial owner fractions, where x is the rounding factor. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down."
    )]
    BeneficialOwnerRoundDownXAndBelow =
        FractionalSecurityRuleCode.BeneficialOwnerRoundDownXAndBelow, // same ordinal as derivation source for type conversions
}
