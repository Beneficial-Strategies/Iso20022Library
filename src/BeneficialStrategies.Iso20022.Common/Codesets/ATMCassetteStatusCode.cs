// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of a cassette in an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMCassetteStatusCode")]
[Description(@"Status of a cassette in an ATM.")]
public enum ATMCassetteStatusCode
{
    /// <summary>
    /// The cash unit is full.
    /// Encoded/decoded by serializers as &quot;CUFL&quot;.
    /// </summary>
    [EnumMember(Value = "CUFL")]
    [IsoId("_ATMCassetteStatusCode_Full")]
    [Description(@"The cash unit is full.")]
    Full,

    /// <summary>
    /// The cash unit is high, that is it has reached or exceeded the threshold defined for this cassette.
    /// Encoded/decoded by serializers as &quot;CUHG&quot;.
    /// </summary>
    [EnumMember(Value = "CUHG")]
    [IsoId("_ATMCassetteStatusCode_High")]
    [Description(@"The cash unit is high, that is it has reached or exceeded the threshold defined for this cassette.")]
    High,

    /// <summary>
    /// The cash unit is low, that is it has reached or is below the threshold defined for this cassette.
    /// Encoded/decoded by serializers as &quot;CULW&quot;.
    /// </summary>
    [EnumMember(Value = "CULW")]
    [IsoId("_ATMCassetteStatusCode_Low")]
    [Description(@"The cash unit is low, that is it has reached or is below the threshold defined for this cassette.")]
    Low,

    /// <summary>
    /// The device has been inserted when the device was not in an exchange state.
    /// Encoded/decoded by serializers as &quot;CUMP&quot;.
    /// </summary>
    [EnumMember(Value = "CUMP")]
    [IsoId("_ATMCassetteStatusCode_Manipulated")]
    [Description(@"The device has been inserted when the device was not in an exchange state.")]
    Manipulated,

    /// <summary>
    /// The cash unit is missing.
    /// Encoded/decoded by serializers as &quot;CUMS&quot;.
    /// </summary>
    [EnumMember(Value = "CUMS")]
    [IsoId("_ATMCassetteStatusCode_Missing")]
    [Description(@"The cash unit is missing.")]
    Missing,

    /// <summary>
    /// The cash unit is empty.
    /// Encoded/decoded by serializers as &quot;CUMT&quot;.
    /// </summary>
    [EnumMember(Value = "CUMT")]
    [IsoId("_ATMCassetteStatusCode_Empty")]
    [Description(@"The cash unit is empty.")]
    Empty,

    /// <summary>
    /// The values of this cash unit are not available.
    /// Encoded/decoded by serializers as &quot;CUNA&quot;.
    /// </summary>
    [EnumMember(Value = "CUNA")]
    [IsoId("_ATMCassetteStatusCode_NotAvailable")]
    [Description(@"The values of this cash unit are not available.")]
    NotAvailable,

    /// <summary>
    /// The cash unit is inoperative.
    /// Encoded/decoded by serializers as &quot;CUNP&quot;.
    /// </summary>
    [EnumMember(Value = "CUNP")]
    [IsoId("_ATMCassetteStatusCode_Inoperative")]
    [Description(@"The cash unit is inoperative.")]
    Inoperative,

    /// <summary>
    /// There are no reference values available for this cash unit.
    /// Encoded/decoded by serializers as &quot;CUNR&quot;.
    /// </summary>
    [EnumMember(Value = "CUNR")]
    [IsoId("_ATMCassetteStatusCode_NoReference")]
    [Description(@"There are no reference values available for this cash unit.")]
    NoReference,

    /// <summary>
    /// The cash unit is in a good state.
    /// Encoded/decoded by serializers as &quot;CUOK&quot;.
    /// </summary>
    [EnumMember(Value = "CUOK")]
    [IsoId("_ATMCassetteStatusCode_Ok")]
    [Description(@"The cash unit is in a good state.")]
    Ok,

}
