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
[IsoId("_bjbk9Np-Ed-ak6NoX_4Aeg_300324450")]
[Description(
    @"Specifies the level of approval depending on a number of factors, including payment type, threshold amount or local country or operations practice."
)]
[DerivedFrom(typeof(AuthorisationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Authorisation1Code>))]
#endif
public enum Authorisation1Code
{
    /// <summary>
    /// Indicates a file has been pre authorised or approved within the originating customer environment and no further approval is required.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_bjbk9dp-Ed-ak6NoX_4Aeg_300324481")]
    [Description(
        @"Indicates a file has been pre authorised or approved within the originating customer environment and no further approval is required."
    )]
    PreAuthorisedFile = AuthorisationCode.PreAuthorisedFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that a file requires additional file level approval, with the ability to view both the payment information block and supporting customer credit transaction detail.
    /// Encoded/decoded by serializers as &quot;FDET&quot;.
    /// </summary>
    [EnumMember(Value = "FDET")]
    [IsoId("_bjbk9tp-Ed-ak6NoX_4Aeg_300324503")]
    [Description(
        @"Indicates that a file requires additional file level approval, with the ability to view both the payment information block and supporting customer credit transaction detail."
    )]
    FileLevelAuthorisationDetails = AuthorisationCode.FileLevelAuthorisationDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that a file requires additional file level approval, with the ability to view only the payment information block level information.
    /// Encoded/decoded by serializers as &quot;FSUM&quot;.
    /// </summary>
    [EnumMember(Value = "FSUM")]
    [IsoId("_bjbk99p-Ed-ak6NoX_4Aeg_300324534")]
    [Description(
        @"Indicates that a file requires additional file level approval, with the ability to view only the payment information block level information."
    )]
    FileLevelAuthorisationSummary = AuthorisationCode.FileLevelAuthorisationSummary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that a file requires all customer transactions to be authorised or approved.
    /// Encoded/decoded by serializers as &quot;ILEV&quot;.
    /// </summary>
    [EnumMember(Value = "ILEV")]
    [IsoId("_bjbk-Np-Ed-ak6NoX_4Aeg_300324565")]
    [Description(
        @"Indicates that a file requires all customer transactions to be authorised or approved."
    )]
    InstructionLevelAuthorisation = AuthorisationCode.InstructionLevelAuthorisation, // same ordinal as derivation source for type conversions
}
