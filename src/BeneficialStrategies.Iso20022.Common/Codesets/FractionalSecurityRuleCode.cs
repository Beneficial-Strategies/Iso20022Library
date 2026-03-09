// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the fractional security handling rule that does not have an ISO value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1rgnQDL3EeKU9IrkkToqcw_126985823")]
[Description(@"Specifies the fractional security handling rule that does not have an ISO value.")]
[Derivations(typeof(FractionalSecurityRule1Code))]
public enum FractionalSecurityRuleCode
{
    /// <summary>
    /// Round Up x and above on the beneficial owner fractions, where x is the rounding factor. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.
    /// Encoded/decoded by serializers as &quot;BORU&quot;.
    /// </summary>
    [EnumMember(Value = "BORU")]
    [IsoId("_1rgnQTL3EeKU9IrkkToqcw_-428904472")]
    [Description(@"Round Up x and above on the beneficial owner fractions, where x is the rounding factor. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.")]
    BeneficialOwnerRoundUpXAndAbove,
    
    /// <summary>
    /// Cash in Lieu on the beneficial owner fractions.
    /// Encoded/decoded by serializers as &quot;BCIL&quot;.
    /// </summary>
    [EnumMember(Value = "BCIL")]
    [IsoId("_1rgnQjL3EeKU9IrkkToqcw_1097474043")]
    [Description(@"Cash in Lieu on the beneficial owner fractions.")]
    BeneficialOwnerCashInLieu,
    
    /// <summary>
    /// Round Down x and below beneficial owner fractions, where x is the rounding factor. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.
    /// Encoded/decoded by serializers as &quot;BORD&quot;.
    /// </summary>
    [EnumMember(Value = "BORD")]
    [IsoId("_1rgnQzL3EeKU9IrkkToqcw_1047506999")]
    [Description(@"Round Down x and below beneficial owner fractions, where x is the rounding factor. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.")]
    BeneficialOwnerRoundDownXAndBelow,
    
}
