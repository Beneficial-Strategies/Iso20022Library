// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the named type of the undertaking.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-YzAEHyjEeGWJuGCfvwOsQ")]
[Description(@"Specifies the named type of the undertaking.")]
[DerivedFrom(typeof(UndertakingNameCode))]
public enum UndertakingName1Code
{
    /// <summary>
    /// Undertaking is a standby letter of credit.
    /// Encoded/decoded by serializers as &quot;STBY&quot;.
    /// </summary>
    [EnumMember(Value = "STBY")]
    [IsoId("_NKQpRnykEeGWJuGCfvwOsQ")]
    [Description(@"Undertaking is a standby letter of credit.")]
    StandbyLetterOfCredit = UndertakingNameCode.StandbyLetterOfCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Undertaking is a demand guarantee.
    /// Encoded/decoded by serializers as &quot;DGAR&quot;.
    /// </summary>
    [EnumMember(Value = "DGAR")]
    [IsoId("_qkAn4doiEeGA-6DT389Lyw")]
    [Description(@"Undertaking is a demand guarantee.")]
    DemandGuarantee = UndertakingNameCode.DemandGuarantee, // same ordinal as derivation source for type conversions
    
}
