// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies information about excess cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tL3U4ALoEeutW5-TpeYJhA")]
[Description(@"Specifies information about excess cash.")]
[DerivedFrom(typeof(ReturnExcessCashCode))]
public enum ReturnExcessCash1Code
{
    /// <summary>
    /// Excess cash in the currency is returned.
    /// Encoded/decoded by serializers as &quot;RTND&quot;.
    /// </summary>
    [EnumMember(Value = "RTND")]
    [IsoId("_u2qp0QLoEeutW5-TpeYJhA")]
    [Description(@"Excess cash in the currency is returned.")]
    AutomaticallyReturned = ReturnExcessCashCode.AutomaticallyReturned, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Automatic return of excess cash has not been requested for the currency. 
    /// Encoded/decoded by serializers as &quot;RTDN&quot;.
    /// </summary>
    [EnumMember(Value = "RTDN")]
    [IsoId("_vAVjMgLoEeutW5-TpeYJhA")]
    [Description(@"Automatic return of excess cash has not been requested for the currency. ")]
    NoAutomaticReturn = ReturnExcessCashCode.NoAutomaticReturn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Automatic return of cash is temporarily suspended (for example due to a currency holiday).
    /// Encoded/decoded by serializers as &quot;SSPD&quot;.
    /// </summary>
    [EnumMember(Value = "SSPD")]
    [IsoId("_vKC40gLoEeutW5-TpeYJhA")]
    [Description(@"Automatic return of cash is temporarily suspended (for example due to a currency holiday).")]
    Suspended = ReturnExcessCashCode.Suspended, // same ordinal as derivation source for type conversions
    
}
