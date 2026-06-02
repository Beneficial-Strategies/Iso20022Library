// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of terminal to perform the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oZEwwSRhEfCa6bxMAKEOKg")]
[Description(@"Type of terminal to perform the transaction.")]
[DerivedFrom(typeof(TerminalTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TerminalType2Code>))]
public enum TerminalType2Code
{
    /// <summary>
    /// Automated Teller Machine
    /// Encoded/decoded by serializers as &quot;ATMT&quot;.
    /// </summary>
    [EnumMember(Value = "ATMT")]
    [IsoId("_obekgSRhEfCa6bxMAKEOKg")]
    [Description(@"Automated Teller Machine")]
    ATM = TerminalTypeCode.ATM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mobile or tablet used as a Point of Sale terminal
    /// Encoded/decoded by serializers as &quot;MPOS&quot;.
    /// </summary>
    [EnumMember(Value = "MPOS")]
    [IsoId("_obekgyRhEfCa6bxMAKEOKg")]
    [Description(@"Mobile or tablet used as a Point of Sale terminal")]
    mPOS = TerminalTypeCode.mPOS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of Sale terminal.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_obekiSRhEfCa6bxMAKEOKg")]
    [Description(@"Point of Sale terminal.")]
    POS = TerminalTypeCode.POS, // same ordinal as derivation source for type conversions
}
