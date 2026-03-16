// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of a cassette in an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMCassetteStatus1Code")]
[Description(@"Status of a cassette in an ATM.")]
[DerivedFrom(typeof(ATMCassetteStatusCode))]
public enum ATMCassetteStatus1Code
{
    /// <summary>
    /// The cash unit is full.
    /// Encoded/decoded by serializers as &quot;CUFL&quot;.
    /// </summary>
    [EnumMember(Value = "CUFL")]
    [IsoId("_ATMCassetteStatus1Code_Full")]
    [Description(@"The cash unit is full.")]
    Full = ATMCassetteStatusCode.Full,

    /// <summary>
    /// The cash unit is high, that is it has reached or exceeded the threshold defined for this cassette.
    /// Encoded/decoded by serializers as &quot;CUHG&quot;.
    /// </summary>
    [EnumMember(Value = "CUHG")]
    [IsoId("_ATMCassetteStatus1Code_High")]
    [Description(@"The cash unit is high, that is it has reached or exceeded the threshold defined for this cassette.")]
    High = ATMCassetteStatusCode.High,

    /// <summary>
    /// The cash unit is low, that is it has reached or is below the threshold defined for this cassette.
    /// Encoded/decoded by serializers as &quot;CULW&quot;.
    /// </summary>
    [EnumMember(Value = "CULW")]
    [IsoId("_ATMCassetteStatus1Code_Low")]
    [Description(@"The cash unit is low, that is it has reached or is below the threshold defined for this cassette.")]
    Low = ATMCassetteStatusCode.Low,

    /// <summary>
    /// The device has been inserted when the device was not in an exchange state.
    /// Encoded/decoded by serializers as &quot;CUMP&quot;.
    /// </summary>
    [EnumMember(Value = "CUMP")]
    [IsoId("_ATMCassetteStatus1Code_Manipulated")]
    [Description(@"The device has been inserted when the device was not in an exchange state.")]
    Manipulated = ATMCassetteStatusCode.Manipulated,

    /// <summary>
    /// The cash unit is missing.
    /// Encoded/decoded by serializers as &quot;CUMS&quot;.
    /// </summary>
    [EnumMember(Value = "CUMS")]
    [IsoId("_ATMCassetteStatus1Code_Missing")]
    [Description(@"The cash unit is missing.")]
    Missing = ATMCassetteStatusCode.Missing,

    /// <summary>
    /// The cash unit is empty.
    /// Encoded/decoded by serializers as &quot;CUMT&quot;.
    /// </summary>
    [EnumMember(Value = "CUMT")]
    [IsoId("_ATMCassetteStatus1Code_Empty")]
    [Description(@"The cash unit is empty.")]
    Empty = ATMCassetteStatusCode.Empty,

    /// <summary>
    /// The values of this cash unit are not available.
    /// Encoded/decoded by serializers as &quot;CUNA&quot;.
    /// </summary>
    [EnumMember(Value = "CUNA")]
    [IsoId("_ATMCassetteStatus1Code_NotAvailable")]
    [Description(@"The values of this cash unit are not available.")]
    NotAvailable = ATMCassetteStatusCode.NotAvailable,

    /// <summary>
    /// The cash unit is inoperative.
    /// Encoded/decoded by serializers as &quot;CUNP&quot;.
    /// </summary>
    [EnumMember(Value = "CUNP")]
    [IsoId("_ATMCassetteStatus1Code_Inoperative")]
    [Description(@"The cash unit is inoperative.")]
    Inoperative = ATMCassetteStatusCode.Inoperative,

    /// <summary>
    /// There are no reference values available for this cash unit.
    /// Encoded/decoded by serializers as &quot;CUNR&quot;.
    /// </summary>
    [EnumMember(Value = "CUNR")]
    [IsoId("_ATMCassetteStatus1Code_NoReference")]
    [Description(@"There are no reference values available for this cash unit.")]
    NoReference = ATMCassetteStatusCode.NoReference,

    /// <summary>
    /// The cash unit is in a good state.
    /// Encoded/decoded by serializers as &quot;CUOK&quot;.
    /// </summary>
    [EnumMember(Value = "CUOK")]
    [IsoId("_ATMCassetteStatus1Code_Ok")]
    [Description(@"The cash unit is in a good state.")]
    Ok = ATMCassetteStatusCode.Ok,

}
