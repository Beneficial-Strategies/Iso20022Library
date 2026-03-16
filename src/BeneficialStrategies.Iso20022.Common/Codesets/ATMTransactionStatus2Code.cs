// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of the amount presented to the customer in the last bundle.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6bELsIqSEeSRT5rEzcAHEw")]
[Description(@"Status of the amount presented to the customer in the last bundle.")]
[DerivedFrom(typeof(ATMTransactionStatusCode))]
public enum ATMTransactionStatus2Code
{
    /// <summary>
    /// Total presented amount is equal to the amount to dispense.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_-SIj4YqSEeSRT5rEzcAHEw")]
    [Description(@"Total presented amount is equal to the amount to dispense.")]
    Full = ATMTransactionStatusCode.Full, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total presented amount is lower than the amount to dispense.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_-fsew4qSEeSRT5rEzcAHEw")]
    [Description(@"Total presented amount is lower than the amount to dispense.")]
    Partial = ATMTransactionStatusCode.Partial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total presented amount is equal to zero.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_-szts4qSEeSRT5rEzcAHEw")]
    [Description(@"Total presented amount is equal to zero.")]
    None = ATMTransactionStatusCode.None, // same ordinal as derivation source for type conversions
}
