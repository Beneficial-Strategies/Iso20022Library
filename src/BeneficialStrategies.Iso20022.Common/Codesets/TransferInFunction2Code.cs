// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the function of the transfer in confirmation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p7s5kCVOEeWI0orciOKunQ")]
[Description(@"Specifies the function of the transfer in confirmation.")]
[DerivedFrom(typeof(TransferInFunctionCode))]
public enum TransferInFunction2Code
{
    /// <summary>
    /// The transfer-in is a confirmation (rather than an advice).
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_ukgQsSVOEeWI0orciOKunQ")]
    [Description(@"The transfer-in is a confirmation (rather than an advice).")]
    Confirmation = TransferInFunctionCode.Confirmation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The transfer-in provides advice about account information for a transfer.
    /// Encoded/decoded by serializers as &quot;ADVI&quot;.
    /// </summary>
    [EnumMember(Value = "ADVI")]
    [IsoId("_uw_0kSVOEeWI0orciOKunQ")]
    [Description(@"The transfer-in provides advice about account information for a transfer.")]
    Advice = TransferInFunctionCode.Advice, // same ordinal as derivation source for type conversions
    
}
