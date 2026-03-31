// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Outcome of the financial ATM transaction for the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RAy34IqSEeSRT5rEzcAHEw")]
[Description(@"Outcome of the financial ATM transaction for the customer.")]
[DerivedFrom(typeof(ATMTransactionStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ATMTransactionStatus1Code>))]
#endif
public enum ATMTransactionStatus1Code
{
    /// <summary>
    /// Undetermined status, for instance possibly forgotten notes.
    /// Encoded/decoded by serializers as &quot;DOBT&quot;.
    /// </summary>
    [EnumMember(Value = "DOBT")]
    [IsoId("_VAzJoYqSEeSRT5rEzcAHEw")]
    [Description(@"Undetermined status, for instance possibly forgotten notes.")]
    Doubt = ATMTransactionStatusCode.Doubt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_VE0uAYqSEeSRT5rEzcAHEw")]
    [Description(@"Transaction failed.")]
    Failure = ATMTransactionStatusCode.Failure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction was successfully completed.
    /// Encoded/decoded by serializers as &quot;SCSS&quot;.
    /// </summary>
    [EnumMember(Value = "SCSS")]
    [IsoId("_VMHo04qSEeSRT5rEzcAHEw")]
    [Description(@"Transaction was successfully completed.")]
    Success = ATMTransactionStatusCode.Success, // same ordinal as derivation source for type conversions
}
