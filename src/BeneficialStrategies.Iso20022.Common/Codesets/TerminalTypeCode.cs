// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of terminal under the control of the card acceptor used for the card transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_71JA8ECGEeeXpbqDpLawug")]
[Description(
    @"Type of terminal under the control of the card acceptor used for the card transaction."
)]
[Derivations(typeof(TerminalType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TerminalTypeCode>))]
#endif
public enum TerminalTypeCode
{
    /// <summary>
    /// Automated Teller Machine
    /// Encoded/decoded by serializers as &quot;ATMT&quot;.
    /// </summary>
    [EnumMember(Value = "ATMT")]
    [IsoId("_CyLEgECHEeeXpbqDpLawug")]
    [Description(@"Automated Teller Machine")]
    ATM,

    /// <summary>
    /// Point of Sale terminal.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_GY-zIECHEeeXpbqDpLawug")]
    [Description(@"Point of Sale terminal.")]
    POS,

    /// <summary>
    /// Mobile or tablet used as a Point of Sale terminal
    /// Encoded/decoded by serializers as &quot;MPOS&quot;.
    /// </summary>
    [EnumMember(Value = "MPOS")]
    [IsoId("_K_CYQECHEeeXpbqDpLawug")]
    [Description(@"Mobile or tablet used as a Point of Sale terminal")]
    mPOS,

    /// <summary>
    /// Other type defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_QkQ7YECHEeeXpbqDpLawug")]
    [Description(@"Other type defined at national level")]
    OtherNational,

    /// <summary>
    /// Other private type of terminal.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_VOi5MECHEeeXpbqDpLawug")]
    [Description(@"Other private type of terminal.")]
    OtherPrivate,
}
