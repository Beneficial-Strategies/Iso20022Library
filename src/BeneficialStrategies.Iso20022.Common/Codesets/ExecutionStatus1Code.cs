// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message as a code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5OqesMX5EeiSF9q-coWegA")]
[Description(
    @"Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message as a code."
)]
[DerivedFrom(typeof(ExecutionStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExecutionStatus1Code>))]
#endif
public enum ExecutionStatus1Code
{
    /// <summary>
    /// Transaction which has been initiated and has not yet closed.
    /// Encoded/decoded by serializers as &quot;INTD&quot;.
    /// </summary>
    [EnumMember(Value = "INTD")]
    [IsoId("_68mnMcX5EeiSF9q-coWegA")]
    [Description(@"Transaction which has been initiated and has not yet closed.")]
    Initiated = ExecutionStatusCode.Initiated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending Initiation.
    /// Encoded/decoded by serializers as &quot;PINT&quot;.
    /// </summary>
    [EnumMember(Value = "PINT")]
    [IsoId("_7CGyQcX5EeiSF9q-coWegA")]
    [Description(@"Pending Initiation.")]
    PendingInitiation = ExecutionStatusCode.PendingInitiation, // same ordinal as derivation source for type conversions
}
