// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of price value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qd8KkeEPEd-1Ktb5rVaajw")]
[Description(@"Specifies a type of price value.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType9Code
{
    /// <summary>
    /// Price to be specified by account owner.
    /// Encoded/decoded by serializers as &quot;TBSP&quot;.
    /// </summary>
    [EnumMember(Value = "TBSP")]
    [IsoId("_q5bEM2tdEeCY4-KZ9JEyUQ_-401797513")]
    [Description(@"Price to be specified by account owner.")]
    ToBeSpecified = PriceValueTypeCode.ToBeSpecified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is not required to be specified by account owner.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_q5bENGtdEeCY4-KZ9JEyUQ_-519195689")]
    [Description(@"Price is not required to be specified by account owner.")]
    Unspecified = PriceValueTypeCode.Unspecified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_q5bENWtdEeCY4-KZ9JEyUQ_-1516268042")]
    [Description(@"Price is unknown by the sender or has not been established.")]
    Unknown = PriceValueTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
}
