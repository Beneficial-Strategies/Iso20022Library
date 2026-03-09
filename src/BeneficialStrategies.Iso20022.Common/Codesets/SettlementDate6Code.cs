// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the time an event occurred relative to an implied date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XwY_MLbwEeaqL_M7XFD7PQ")]
[Description(@"Specifies the time an event occurred relative to an implied date.")]
[DerivedFrom(typeof(SettlementDateCode))]
public enum SettlementDate6Code
{
    /// <summary>
    /// Settlement takes place on the trade date plus five business days.
    /// Encoded/decoded by serializers as &quot;TFIV&quot;.
    /// </summary>
    [EnumMember(Value = "TFIV")]
    [IsoId("_aDXucbbwEeaqL_M7XFD7PQ")]
    [Description(@"Settlement takes place on the trade date plus five business days.")]
    TPlusFive = SettlementDateCode.TPlusFive, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus four business days.
    /// Encoded/decoded by serializers as &quot;TFOR&quot;.
    /// </summary>
    [EnumMember(Value = "TFOR")]
    [IsoId("_aLtLEbbwEeaqL_M7XFD7PQ")]
    [Description(@"Settlement takes place on the trade date plus four business days.")]
    TPlusFour = SettlementDateCode.TPlusFour, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus one business day.
    /// Encoded/decoded by serializers as &quot;TONE&quot;.
    /// </summary>
    [EnumMember(Value = "TONE")]
    [IsoId("_aU7YgbbwEeaqL_M7XFD7PQ")]
    [Description(@"Settlement takes place on the trade date plus one business day.")]
    TPlusOne = SettlementDateCode.TPlusOne, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus three business days.
    /// Encoded/decoded by serializers as &quot;TTRE&quot;.
    /// </summary>
    [EnumMember(Value = "TTRE")]
    [IsoId("_ahIBcbbwEeaqL_M7XFD7PQ")]
    [Description(@"Settlement takes place on the trade date plus three business days.")]
    TPlusThree = SettlementDateCode.TPlusThree, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place on the trade date plus two business days.
    /// Encoded/decoded by serializers as &quot;TTWO&quot;.
    /// </summary>
    [EnumMember(Value = "TTWO")]
    [IsoId("_apKjIbbwEeaqL_M7XFD7PQ")]
    [Description(@"Settlement takes place on the trade date plus two business days.")]
    TPlusTwo = SettlementDateCode.TPlusTwo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event occurs on the same day or at time T.
    /// Encoded/decoded by serializers as &quot;SAMD&quot;.
    /// </summary>
    [EnumMember(Value = "SAMD")]
    [IsoId("_nfpGUbbwEeaqL_M7XFD7PQ")]
    [Description(@"Event occurs on the same day or at time T.")]
    SameDay = SettlementDateCode.SameDay, // same ordinal as derivation source for type conversions
    
}
