// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether registration should occur upon receipt.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_l3X10fIrEd-dOvqmSLSz5g")]
[Description(@"Specifies whether registration should occur upon receipt.")]
[DerivedFrom(typeof(RegistrationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Registration2Code>))]
#endif
public enum Registration2Code
{
    /// <summary>
    /// You or your party set the instruction in a hold/frozen/preadvice mode.
    /// Encoded/decoded by serializers as &quot;PTYH&quot;.
    /// </summary>
    [EnumMember(Value = "PTYH")]
    [IsoId("_q5kOJGtdEeCY4-KZ9JEyUQ_105432583")]
    [Description(@"You or your party set the instruction in a hold/frozen/preadvice mode.")]
    PartyHold = RegistrationCode.PartyHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central securities depository sets the instruction in a hold/frozen/preadvice mode.
    /// Encoded/decoded by serializers as &quot;CSDH&quot;.
    /// </summary>
    [EnumMember(Value = "CSDH")]
    [IsoId("_q5kOJWtdEeCY4-KZ9JEyUQ_-891639770")]
    [Description(
        @"Central securities depository sets the instruction in a hold/frozen/preadvice mode."
    )]
    CSDHold = RegistrationCode.CSDHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditional delivery rules in the market infrastructure platform for conditional delivery.
    /// Encoded/decoded by serializers as &quot;CDEL&quot;.
    /// </summary>
    [EnumMember(Value = "CDEL")]
    [IsoId("_q5kOJmtdEeCY4-KZ9JEyUQ_-914504853")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditional delivery rules in the market infrastructure platform for conditional delivery."
    )]
    ConditionalDelivery = RegistrationCode.ConditionalDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.
    /// Encoded/decoded by serializers as &quot;CVAL&quot;.
    /// </summary>
    [EnumMember(Value = "CVAL")]
    [IsoId("_q5t_IGtdEeCY4-KZ9JEyUQ_7658457")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform."
    )]
    CSDValidation = RegistrationCode.CSDValidation, // same ordinal as derivation source for type conversions
}
