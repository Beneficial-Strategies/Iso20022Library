// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the Foreign Account Tax Compliance Act (FATCA) status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VA8RAAjUEeS5F6qHcKOrew")]
[Description(@"Specifies the Foreign Account Tax Compliance Act (FATCA) status.")]
[DerivedFrom(typeof(FATCAStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FATCAStatus1Code>))]
#endif
public enum FATCAStatus1Code
{
    /// <summary>
    /// Account holder type is an owner-documented financial institution with specified US owner(s).
    /// Encoded/decoded by serializers as &quot;F101&quot;.
    /// </summary>
    [EnumMember(Value = "F101")]
    [IsoId("_XFWYwQjUEeS5F6qHcKOrew")]
    [Description(
        @"Account holder type is an owner-documented financial institution with specified US owner(s)."
    )]
    FATCA101 = FATCAStatusCode.FATCA101, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is a passive non-financial entity with substantial US owner(s).
    /// Encoded/decoded by serializers as &quot;F102&quot;.
    /// </summary>
    [EnumMember(Value = "F102")]
    [IsoId("_XN1mYQjUEeS5F6qHcKOrew")]
    [Description(
        @"Account holder type is a passive non-financial entity with substantial US owner(s)."
    )]
    FATCA102 = FATCAStatusCode.FATCA102, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is a non-participating financial institution.
    /// Encoded/decoded by serializers as &quot;F103&quot;.
    /// </summary>
    [EnumMember(Value = "F103")]
    [IsoId("_XWw44QjUEeS5F6qHcKOrew")]
    [Description(@"Account holder type is a non-participating financial institution.")]
    FATCA103 = FATCAStatusCode.FATCA103, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is a specified US person.
    /// Encoded/decoded by serializers as &quot;F104&quot;.
    /// </summary>
    [EnumMember(Value = "F104")]
    [IsoId("_XfFucQjUEeS5F6qHcKOrew")]
    [Description(@"Account holder type is a specified US person.")]
    FATCA104 = FATCAStatusCode.FATCA104, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account holder type is a direct reporting non-financial foreign entity (NFFE).
    /// Encoded/decoded by serializers as &quot;F105&quot;.
    /// </summary>
    [EnumMember(Value = "F105")]
    [IsoId("_Xnk8EQjUEeS5F6qHcKOrew")]
    [Description(@"Account holder type is a direct reporting non-financial foreign entity (NFFE).")]
    FATCA105 = FATCAStatusCode.FATCA105, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account pool reporting type is a recalcitrant account holder with US indicia.
    /// Encoded/decoded by serializers as &quot;F201&quot;.
    /// </summary>
    [EnumMember(Value = "F201")]
    [IsoId("_Xv5xoQjUEeS5F6qHcKOrew")]
    [Description(@"Account pool reporting type is a recalcitrant account holder with US indicia.")]
    FATCA201 = FATCAStatusCode.FATCA201, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account pool reporting type is a recalcitrant account holder without US indicia.
    /// Encoded/decoded by serializers as &quot;F202&quot;.
    /// </summary>
    [EnumMember(Value = "F202")]
    [IsoId("_X4POQQjUEeS5F6qHcKOrew")]
    [Description(
        @"Account pool reporting type is a recalcitrant account holder without US indicia."
    )]
    FATCA202 = FATCAStatusCode.FATCA202, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account pool reporting type is a dormant account.
    /// Encoded/decoded by serializers as &quot;F203&quot;.
    /// </summary>
    [EnumMember(Value = "F203")]
    [IsoId("_YAt00QjUEeS5F6qHcKOrew")]
    [Description(@"Account pool reporting type is a dormant account.")]
    FATCA203 = FATCAStatusCode.FATCA203, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account pool reporting type is a non-participating foreign financial institution.
    /// Encoded/decoded by serializers as &quot;F204&quot;.
    /// </summary>
    [EnumMember(Value = "F204")]
    [IsoId("_YDjGYQjUEeS5F6qHcKOrew")]
    [Description(
        @"Account pool reporting type is a non-participating foreign financial institution."
    )]
    FATCA204 = FATCAStatusCode.FATCA204, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account pool reporting type is a recalcitrant account holder that is a US person.
    /// Encoded/decoded by serializers as &quot;F205&quot;.
    /// </summary>
    [EnumMember(Value = "F205")]
    [IsoId("_YL378QjUEeS5F6qHcKOrew")]
    [Description(
        @"Account pool reporting type is a recalcitrant account holder that is a US person."
    )]
    FATCA205 = FATCAStatusCode.FATCA205, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account pool reporting type is recalcitrant account holder that is a passive non-financial foreign entity (NFFE).
    /// Encoded/decoded by serializers as &quot;F206&quot;.
    /// </summary>
    [EnumMember(Value = "F206")]
    [IsoId("_YUWigQjUEeS5F6qHcKOrew")]
    [Description(
        @"Account pool reporting type is recalcitrant account holder that is a passive non-financial foreign entity (NFFE)."
    )]
    FATCA206 = FATCAStatusCode.FATCA206, // same ordinal as derivation source for type conversions
}
