// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of an ATM transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EBcskIqSEeSRT5rEzcAHEw")]
[Description(@"Status of an ATM transaction.")]
[Derivations(typeof(ATMTransactionStatus1Code), typeof(ATMTransactionStatus2Code))]
public enum ATMTransactionStatusCode
{
    /// <summary>
    /// Transaction was successfully completed.
    /// Encoded/decoded by serializers as &quot;SCSS&quot;.
    /// </summary>
    [EnumMember(Value = "SCSS")]
    [IsoId("_H6TNcIqSEeSRT5rEzcAHEw")]
    [Description(@"Transaction was successfully completed.")]
    Success,

    /// <summary>
    /// Undetermined status, for instance possibly forgotten notes.
    /// Encoded/decoded by serializers as &quot;DOBT&quot;.
    /// </summary>
    [EnumMember(Value = "DOBT")]
    [IsoId("_LT2jMIqSEeSRT5rEzcAHEw")]
    [Description(@"Undetermined status, for instance possibly forgotten notes.")]
    Doubt,

    /// <summary>
    /// Transaction failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_NcpbsIqSEeSRT5rEzcAHEw")]
    [Description(@"Transaction failed.")]
    Failure,

    /// <summary>
    /// Total presented amount is equal to the amount to dispense.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_x4MLsIqSEeSRT5rEzcAHEw")]
    [Description(@"Total presented amount is equal to the amount to dispense.")]
    Full,

    /// <summary>
    /// Total presented amount is lower than the amount to dispense.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_1AKpQIqSEeSRT5rEzcAHEw")]
    [Description(@"Total presented amount is lower than the amount to dispense.")]
    Partial,

    /// <summary>
    /// Total presented amount is equal to zero.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_29fRkIqSEeSRT5rEzcAHEw")]
    [Description(@"Total presented amount is equal to zero.")]
    None,
}
