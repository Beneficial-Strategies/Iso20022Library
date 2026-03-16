// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the source of Foreign Account Tax Compliance Act (FATCA) status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9WkQ8AjUEeS5F6qHcKOrew")]
[Description(@"Specifies the source of Foreign Account Tax Compliance Act (FATCA) status.")]
[DerivedFrom(typeof(FATCASourceStatusCode))]
public enum FATCASourceStatus1Code
{
    /// <summary>
    /// Source of the Foreign Account Tax Compliance Act (FATCA) status calculated.
    /// Encoded/decoded by serializers as &quot;CALC&quot;.
    /// </summary>
    [EnumMember(Value = "CALC")]
    [IsoId("_QakGUQjVEeS5F6qHcKOrew")]
    [Description(@"Source of the Foreign Account Tax Compliance Act (FATCA) status calculated.")]
    Calculated = FATCASourceStatusCode.Calculated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Source of the Foreign Account Tax Compliance Act (FATCA) status is as declared by the investor.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_QjVn0QjVEeS5F6qHcKOrew")]
    [Description(
        @"Source of the Foreign Account Tax Compliance Act (FATCA) status is as declared by the investor."
    )]
    Declared = FATCASourceStatusCode.Declared, // same ordinal as derivation source for type conversions
}
