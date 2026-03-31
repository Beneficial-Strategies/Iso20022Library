// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the level of approval depending on a number of factors, including payment type, threshold amount or local country or operations practice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bjlV8Np-Ed-ak6NoX_4Aeg_-1874566431")]
[Description(
    @"Specifies the level of approval depending on a number of factors, including payment type, threshold amount or local country or operations practice."
)]
[Derivations(typeof(Authorisation1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AuthorisationCode>))]
#endif
public enum AuthorisationCode
{
    /// <summary>
    /// Indicates a file has been pre authorised or approved within the originating customer environment and no further approval is required.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_bjlV8dp-Ed-ak6NoX_4Aeg_-1817309753")]
    [Description(
        @"Indicates a file has been pre authorised or approved within the originating customer environment and no further approval is required."
    )]
    PreAuthorisedFile,

    /// <summary>
    /// Indicates that a file requires additional file level approval, with the ability to view both the payment information block and supporting customer credit transaction detail.
    /// Encoded/decoded by serializers as &quot;FDET&quot;.
    /// </summary>
    [EnumMember(Value = "FDET")]
    [IsoId("_bjlV8tp-Ed-ak6NoX_4Aeg_-1056326828")]
    [Description(
        @"Indicates that a file requires additional file level approval, with the ability to view both the payment information block and supporting customer credit transaction detail."
    )]
    FileLevelAuthorisationDetails,

    /// <summary>
    /// Indicates that a file requires additional file level approval, with the ability to view only the payment information block level information.
    /// Encoded/decoded by serializers as &quot;FSUM&quot;.
    /// </summary>
    [EnumMember(Value = "FSUM")]
    [IsoId("_bjlV89p-Ed-ak6NoX_4Aeg_-899328936")]
    [Description(
        @"Indicates that a file requires additional file level approval, with the ability to view only the payment information block level information."
    )]
    FileLevelAuthorisationSummary,

    /// <summary>
    /// Indicates that a file requires all customer transactions to be authorised or approved.
    /// Encoded/decoded by serializers as &quot;ILEV&quot;.
    /// </summary>
    [EnumMember(Value = "ILEV")]
    [IsoId("_bjlV9Np-Ed-ak6NoX_4Aeg_-584409191")]
    [Description(
        @"Indicates that a file requires all customer transactions to be authorised or approved."
    )]
    InstructionLevelAuthorisation,
}
