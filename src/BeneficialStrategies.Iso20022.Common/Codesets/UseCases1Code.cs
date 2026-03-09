// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the action on the cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yatghtp-Ed-ak6NoX_4Aeg_-2122748244")]
[Description(@"Specifies the action on the cash account.")]
[DerivedFrom(typeof(UseCasesCode))]
public enum UseCases1Code
{
    /// <summary>
    /// Code indicating the opening of an account.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_Yatgh9p-Ed-ak6NoX_4Aeg_-2048866565")]
    [Description(@"Code indicating the opening of an account.")]
    Opening = UseCasesCode.Opening, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code indicating the maintenance of an account.
    /// Encoded/decoded by serializers as &quot;MNTN&quot;.
    /// </summary>
    [EnumMember(Value = "MNTN")]
    [IsoId("_YatgiNp-Ed-ak6NoX_4Aeg_-2048866534")]
    [Description(@"Code indicating the maintenance of an account.")]
    Maintenance = UseCasesCode.Maintenance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code indicating the closing of an account.
    /// Encoded/decoded by serializers as &quot;CLSG&quot;.
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_Yatgidp-Ed-ak6NoX_4Aeg_-2048866503")]
    [Description(@"Code indicating the closing of an account.")]
    Closing = UseCasesCode.Closing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code indicating the view of an account.
    /// Encoded/decoded by serializers as &quot;VIEW&quot;.
    /// </summary>
    [EnumMember(Value = "VIEW")]
    [IsoId("_Ya3RgNp-Ed-ak6NoX_4Aeg_-2048866473")]
    [Description(@"Code indicating the view of an account.")]
    View = UseCasesCode.View, // same ordinal as derivation source for type conversions
    
}
