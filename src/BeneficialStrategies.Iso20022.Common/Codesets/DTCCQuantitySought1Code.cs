// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the quantity sought type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1sjJEzL3EeKU9IrkkToqcw_-1077750329")]
[Description(@"Specifies the quantity sought type.")]
[DerivedFrom(typeof(DTCCQuantitySoughtCode))]
public enum DTCCQuantitySought1Code
{
    /// <summary>
    /// Quantity Sought expressed as quantity.
    /// Encoded/decoded by serializers as &quot;QTTY&quot;.
    /// </summary>
    [EnumMember(Value = "QTTY")]
    [IsoId("_1sjJFDL3EeKU9IrkkToqcw_2031372842")]
    [Description(@"Quantity Sought expressed as quantity.")]
    Quantity = DTCCQuantitySoughtCode.Quantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Check Quantity Sought Comments for quantity sought (irregular expression).
    /// Encoded/decoded by serializers as &quot;CHCO&quot;.
    /// </summary>
    [EnumMember(Value = "CHCO")]
    [IsoId("_1sjJFTL3EeKU9IrkkToqcw_-1982735493")]
    [Description(@"Check Quantity Sought Comments for quantity sought (irregular expression).")]
    CheckComments = DTCCQuantitySoughtCode.CheckComments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity sought is expressed as percentage.
    /// Encoded/decoded by serializers as &quot;PRTG&quot;.
    /// </summary>
    [EnumMember(Value = "PRTG")]
    [IsoId("_1sjJFjL3EeKU9IrkkToqcw_-1528648224")]
    [Description(@"Quantity sought is expressed as percentage.")]
    Percentage = DTCCQuantitySoughtCode.Percentage, // same ordinal as derivation source for type conversions
}
