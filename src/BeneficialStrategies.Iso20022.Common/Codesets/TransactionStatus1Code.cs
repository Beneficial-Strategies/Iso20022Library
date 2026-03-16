// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status of an investment fund transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zdcnZQ93EeGeV5vP7Mvdig_-110011060")]
[Description(@"Specifies the processing status of an investment fund transaction.")]
[DerivedFrom(typeof(TransactionStatusCode))]
public enum TransactionStatus1Code
{
    /// <summary>
    /// Transaction has been reversed.
    /// Encoded/decoded by serializers as &quot;RVSL&quot;.
    /// </summary>
    [EnumMember(Value = "RVSL")]
    [IsoId("_zdmYYA93EeGeV5vP7Mvdig_-1941849246")]
    [Description(@"Transaction has been reversed.")]
    Reversal = TransactionStatusCode.Reversal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been rebooked.
    /// Encoded/decoded by serializers as &quot;REBO&quot;.
    /// </summary>
    [EnumMember(Value = "REBO")]
    [IsoId("_zdmYYQ93EeGeV5vP7Mvdig_-595137067")]
    [Description(@"Transaction has been rebooked.")]
    Rebooked = TransactionStatusCode.Rebooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_zdmYYg93EeGeV5vP7Mvdig_880282350")]
    [Description(@"Transaction has been cancelled.")]
    Cancelled = TransactionStatusCode.Cancelled, // same ordinal as derivation source for type conversions
}
