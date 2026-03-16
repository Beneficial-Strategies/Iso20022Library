// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the source of Foreign Account Tax Compliance Act (FATCA) status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yHODoQjUEeS5F6qHcKOrew")]
[Description(@"Specifies the source of Foreign Account Tax Compliance Act (FATCA) status.")]
[Derivations(typeof(FATCASourceStatus1Code))]
public enum FATCASourceStatusCode
{
    /// <summary>
    /// Source of the Foreign Account Tax Compliance Act (FATCA) status is as declared by the investor.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_2BUhsAjUEeS5F6qHcKOrew")]
    [Description(
        @"Source of the Foreign Account Tax Compliance Act (FATCA) status is as declared by the investor."
    )]
    Declared,

    /// <summary>
    /// Source of the Foreign Account Tax Compliance Act (FATCA) status calculated.
    /// Encoded/decoded by serializers as &quot;CALC&quot;.
    /// </summary>
    [EnumMember(Value = "CALC")]
    [IsoId("_2FoZ8AjUEeS5F6qHcKOrew")]
    [Description(@"Source of the Foreign Account Tax Compliance Act (FATCA) status calculated.")]
    Calculated,
}
