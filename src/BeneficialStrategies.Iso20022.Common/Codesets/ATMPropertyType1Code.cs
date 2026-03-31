// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Encoding type of the property.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMPropertyType1Code")]
[Description(@"Encoding type of the property.")]
[DerivedFrom(typeof(ATMPropertyTypeCode))]
public enum ATMPropertyType1Code
{
    /// <summary>
    /// The property is encoded as a Boolean.
    /// Encoded/decoded by serializers as &quot;BOOL&quot;.
    /// </summary>
    [EnumMember(Value = "BOOL")]
    [IsoId("_ATMPropertyType1Code_Boolean")]
    [Description(@"The property is encoded as a Boolean.")]
    Boolean = ATMPropertyTypeCode.Boolean,

    /// <summary>
    /// The property is a CSV string representing a table of data.
    /// Encoded/decoded by serializers as &quot;CSVF&quot;.
    /// </summary>
    [EnumMember(Value = "CSVF")]
    [IsoId("_ATMPropertyType1Code_CSV")]
    [Description(@"The property is a CSV string representing a table of data.")]
    CSV = ATMPropertyTypeCode.CSV,

    /// <summary>
    /// The property is encoded in JSON.
    /// Encoded/decoded by serializers as &quot;JSON&quot;.
    /// </summary>
    [EnumMember(Value = "JSON")]
    [IsoId("_ATMPropertyType1Code_JSON")]
    [Description(@"The property is encoded in JSON.")]
    JSON = ATMPropertyTypeCode.JSON,

    /// <summary>
    /// The property is encoded as a Number.
    /// Encoded/decoded by serializers as &quot;NMBR&quot;.
    /// </summary>
    [EnumMember(Value = "NMBR")]
    [IsoId("_ATMPropertyType1Code_Number")]
    [Description(@"The property is encoded as a Number.")]
    Number = ATMPropertyTypeCode.Number,

    /// <summary>
    /// The property is encoded as a String.
    /// Encoded/decoded by serializers as &quot;STRG&quot;.
    /// </summary>
    [EnumMember(Value = "STRG")]
    [IsoId("_ATMPropertyType1Code_String")]
    [Description(@"The property is encoded as a String.")]
    String = ATMPropertyTypeCode.String,
}
