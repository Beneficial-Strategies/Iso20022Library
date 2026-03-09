// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of terminal to perform the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hwYQAFHIEeeRzt0J6TBeaA")]
[Description(@"Type of terminal to perform the transaction.")]
[DerivedFrom(typeof(TerminalTypeCode))]
public enum TerminalType1Code
{
    /// <summary>
    /// Automated Teller Machine
    /// Encoded/decoded by serializers as &quot;ATMT&quot;.
    /// </summary>
    [EnumMember(Value = "ATMT")]
    [IsoId("_jUzQIVHIEeeRzt0J6TBeaA")]
    [Description(@"Automated Teller Machine")]
    ATM = TerminalTypeCode.ATM, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mobile or tablet used as a Point of Sale terminal
    /// Encoded/decoded by serializers as &quot;MPOS&quot;.
    /// </summary>
    [EnumMember(Value = "MPOS")]
    [IsoId("_jcsA0VHIEeeRzt0J6TBeaA")]
    [Description(@"Mobile or tablet used as a Point of Sale terminal")]
    mPOS = TerminalTypeCode.mPOS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_jnZcAVHIEeeRzt0J6TBeaA")]
    [Description(@"Other type defined at national level")]
    OtherNational = TerminalTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other private type of terminal.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_j5jjAVHIEeeRzt0J6TBeaA")]
    [Description(@"Other private type of terminal.")]
    OtherPrivate = TerminalTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of Sale terminal.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_kF5V4VHIEeeRzt0J6TBeaA")]
    [Description(@"Point of Sale terminal.")]
    POS = TerminalTypeCode.POS, // same ordinal as derivation source for type conversions
    
}
