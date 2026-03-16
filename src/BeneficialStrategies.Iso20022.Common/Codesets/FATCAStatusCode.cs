// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the Foreign Account Tax Compliance Act (FATCA) status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_D8aD4QjSEeS5F6qHcKOrew")]
[Description(@"Specifies the Foreign Account Tax Compliance Act (FATCA) status.")]
[Derivations(typeof(FATCAStatus1Code))]
public enum FATCAStatusCode
{
    /// <summary>
    /// Account holder type is an owner-documented financial institution with specified US owner(s).
    /// Encoded/decoded by serializers as &quot;F101&quot;.
    /// </summary>
    [EnumMember(Value = "F101")]
    [IsoId("_HAp4AAjSEeS5F6qHcKOrew")]
    [Description(
        @"Account holder type is an owner-documented financial institution with specified US owner(s)."
    )]
    FATCA101,

    /// <summary>
    /// Account holder type is a passive non-financial entity with substantial US owner(s).
    /// Encoded/decoded by serializers as &quot;F102&quot;.
    /// </summary>
    [EnumMember(Value = "F102")]
    [IsoId("_3IzZEAjSEeS5F6qHcKOrew")]
    [Description(
        @"Account holder type is a passive non-financial entity with substantial US owner(s)."
    )]
    FATCA102,

    /// <summary>
    /// Account holder type is a non-participating financial institution.
    /// Encoded/decoded by serializers as &quot;F103&quot;.
    /// </summary>
    [EnumMember(Value = "F103")]
    [IsoId("_55_HQAjSEeS5F6qHcKOrew")]
    [Description(@"Account holder type is a non-participating financial institution.")]
    FATCA103,

    /// <summary>
    /// Account holder type is a specified US person.
    /// Encoded/decoded by serializers as &quot;F104&quot;.
    /// </summary>
    [EnumMember(Value = "F104")]
    [IsoId("_9YB7cAjSEeS5F6qHcKOrew")]
    [Description(@"Account holder type is a specified US person.")]
    FATCA104,

    /// <summary>
    /// Account holder type is a direct reporting non-financial foreign entity (NFFE).
    /// Encoded/decoded by serializers as &quot;F105&quot;.
    /// </summary>
    [EnumMember(Value = "F105")]
    [IsoId("_Wzlv0AjTEeS5F6qHcKOrew")]
    [Description(@"Account holder type is a direct reporting non-financial foreign entity (NFFE).")]
    FATCA105,

    /// <summary>
    /// Account pool reporting type is a recalcitrant account holder with US indicia.
    /// Encoded/decoded by serializers as &quot;F201&quot;.
    /// </summary>
    [EnumMember(Value = "F201")]
    [IsoId("_ap1BkAjTEeS5F6qHcKOrew")]
    [Description(@"Account pool reporting type is a recalcitrant account holder with US indicia.")]
    FATCA201,

    /// <summary>
    /// Account pool reporting type is a recalcitrant account holder without US indicia.
    /// Encoded/decoded by serializers as &quot;F202&quot;.
    /// </summary>
    [EnumMember(Value = "F202")]
    [IsoId("_82OZcAjTEeS5F6qHcKOrew")]
    [Description(
        @"Account pool reporting type is a recalcitrant account holder without US indicia."
    )]
    FATCA202,

    /// <summary>
    /// Account pool reporting type is a dormant account.
    /// Encoded/decoded by serializers as &quot;F203&quot;.
    /// </summary>
    [EnumMember(Value = "F203")]
    [IsoId("__wfyMAjTEeS5F6qHcKOrew")]
    [Description(@"Account pool reporting type is a dormant account.")]
    FATCA203,

    /// <summary>
    /// Account pool reporting type is a non-participating foreign financial institution.
    /// Encoded/decoded by serializers as &quot;F204&quot;.
    /// </summary>
    [EnumMember(Value = "F204")]
    [IsoId("_D9ySAAjUEeS5F6qHcKOrew")]
    [Description(
        @"Account pool reporting type is a non-participating foreign financial institution."
    )]
    FATCA204,

    /// <summary>
    /// Account pool reporting type is a recalcitrant account holder that is a US person.
    /// Encoded/decoded by serializers as &quot;F205&quot;.
    /// </summary>
    [EnumMember(Value = "F205")]
    [IsoId("_HllfIAjUEeS5F6qHcKOrew")]
    [Description(
        @"Account pool reporting type is a recalcitrant account holder that is a US person."
    )]
    FATCA205,

    /// <summary>
    /// Account pool reporting type is recalcitrant account holder that is a passive non-financial foreign entity (NFFE).
    /// Encoded/decoded by serializers as &quot;F206&quot;.
    /// </summary>
    [EnumMember(Value = "F206")]
    [IsoId("_LukGsAjUEeS5F6qHcKOrew")]
    [Description(
        @"Account pool reporting type is recalcitrant account holder that is a passive non-financial foreign entity (NFFE)."
    )]
    FATCA206,
}
