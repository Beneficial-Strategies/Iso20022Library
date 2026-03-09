// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of command performed by the ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mEDfga47EeWRfYPBaeOY8w")]
[Description(@"Type of command performed by the ATM.")]
[DerivedFrom(typeof(ATMCommandCode))]
public enum ATMCommand5Code
{
    /// <summary>
    /// Provide the ATM counters, resetting those that are applicable.
    /// Encoded/decoded by serializers as &quot;ABAL&quot;.
    /// </summary>
    [EnumMember(Value = "ABAL")]
    [IsoId("_mQuCga47EeWRfYPBaeOY8w")]
    [Description(@"Provide the ATM counters, resetting those that are applicable.")]
    ATMBalance = ATMCommandCode.ATMBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as &quot;CCNT&quot;.
    /// </summary>
    [EnumMember(Value = "CCNT")]
    [IsoId("_mQuCg647EeWRfYPBaeOY8w")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry = ATMCommandCode.CountersInquiry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Provide the value of the ATM counters, no reinitialisation of the counters.
    /// Encoded/decoded by serializers as &quot;RPTC&quot;.
    /// </summary>
    [EnumMember(Value = "RPTC")]
    [IsoId("_p8M1wa47EeWRfYPBaeOY8w")]
    [Description(@"Provide the value of the ATM counters, no reinitialisation of the counters.")]
    CountersReport = ATMCommandCode.CountersReport, // same ordinal as derivation source for type conversions
    
}
