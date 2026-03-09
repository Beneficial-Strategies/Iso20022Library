// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of movement preliminary advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bRs7x9p-Ed-ak6NoX_4Aeg_-934341596")]
[Description(@"Type of movement preliminary advice.")]
[DerivedFrom(typeof(CorporateActionPreliminaryAdviceTypeCode))]
public enum CorporateActionPreliminaryAdviceType1Code
{
    /// <summary>
    /// New movement preliminary advice.
    /// Encoded/decoded by serializers as &quot;NEWM&quot;.
    /// </summary>
    [EnumMember(Value = "NEWM")]
    [IsoId("_bRs7yNp-Ed-ak6NoX_4Aeg_1528787514")]
    [Description(@"New movement preliminary advice.")]
    New = CorporateActionPreliminaryAdviceTypeCode.New, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Movement preliminary advice replacing a previously sent preliminary advice.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_bRs7ydp-Ed-ak6NoX_4Aeg_-1299031019")]
    [Description(@"Movement preliminary advice replacing a previously sent preliminary advice.")]
    Replacement = CorporateActionPreliminaryAdviceTypeCode.Replacement, // same ordinal as derivation source for type conversions
    
}
