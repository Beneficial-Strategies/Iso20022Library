// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for DTC (The Depository Trust Company) to exit the shares.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_10TW5DL3EeKU9IrkkToqcw_1457482829")]
[Description(@"Specifies the reason for DTC (The Depository Trust Company) to exit the shares.")]
[DerivedFrom(typeof(SecuritiesExitReasonCode))]
public enum SecuritiesExitReason1Code
{
    /// <summary>
    /// Shares are restricted.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_10TW5TL3EeKU9IrkkToqcw_480606307")]
    [Description(@"Shares are restricted.")]
    Restricted = SecuritiesExitReasonCode.Restricted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Shares are non transferable.
    /// Encoded/decoded by serializers as &quot;NTRN&quot;.
    /// </summary>
    [EnumMember(Value = "NTRN")]
    [IsoId("_10dH4DL3EeKU9IrkkToqcw_1947755070")]
    [Description(@"Shares are non transferable.")]
    NonTransferable = SecuritiesExitReasonCode.NonTransferable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other reason.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_10dH4TL3EeKU9IrkkToqcw_1012448860")]
    [Description(@"Other reason.")]
    Other = SecuritiesExitReasonCode.Other, // same ordinal as derivation source for type conversions
    
}
