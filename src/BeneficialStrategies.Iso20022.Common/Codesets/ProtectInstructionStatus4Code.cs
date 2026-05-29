// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the protect transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3EeYcLpbEeilsanBGAzy4A")]
[Description(@"Specifies the status of the protect transaction.")]
[DerivedFrom(typeof(DTCInstructionStatusCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ProtectInstructionStatus4Code>))]
public enum ProtectInstructionStatus4Code
{
    /// <summary>
    /// Protect instruction which has not been fully covered. Will include partial covers.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_BshVMbpcEeilsanBGAzy4A")]
    [Description(
        @"Protect instruction which has not been fully covered. Will include partial covers."
    )]
    Open = DTCInstructionStatusCode.Open, // same ordinal as derivation source for type conversions
}
