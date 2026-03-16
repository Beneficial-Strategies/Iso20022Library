// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Encoding type of the property.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMPropertyTypeCode")]
[Description(@"Encoding type of the property.")]
public enum ATMPropertyTypeCode
{
    /// <summary>
    /// The property is encoded as a Boolean.
    /// Encoded/decoded by serializers as &quot;BOOL&quot;.
    /// </summary>
    [EnumMember(Value = "BOOL")]
    [IsoId("_ATMPropertyTypeCode_Boolean")]
    [Description(@"The property is encoded as a Boolean.")]
    Boolean,

    /// <summary>
    /// The property is a CSV string representing a table of data.
    /// Encoded/decoded by serializers as &quot;CSVF&quot;.
    /// </summary>
    [EnumMember(Value = "CSVF")]
    [IsoId("_ATMPropertyTypeCode_CSV")]
    [Description(@"The property is a CSV string representing a table of data.")]
    CSV,

    /// <summary>
    /// The property is encoded in JSON.
    /// Encoded/decoded by serializers as &quot;JSON&quot;.
    /// </summary>
    [EnumMember(Value = "JSON")]
    [IsoId("_ATMPropertyTypeCode_JSON")]
    [Description(@"The property is encoded in JSON.")]
    JSON,

    /// <summary>
    /// The property is encoded as a Number.
    /// Encoded/decoded by serializers as &quot;NMBR&quot;.
    /// </summary>
    [EnumMember(Value = "NMBR")]
    [IsoId("_ATMPropertyTypeCode_Number")]
    [Description(@"The property is encoded as a Number.")]
    Number,

    /// <summary>
    /// The property is encoded as a String.
    /// Encoded/decoded by serializers as &quot;STRG&quot;.
    /// </summary>
    [EnumMember(Value = "STRG")]
    [IsoId("_ATMPropertyTypeCode_String")]
    [Description(@"The property is encoded as a String.")]
    String,

}
