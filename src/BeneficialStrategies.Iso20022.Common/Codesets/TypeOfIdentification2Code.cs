// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__ztF49ojEeC60axPepSq7g_97735513")]
[Description(
    @"Specifies the type of alternate identification which can be used to give an alternate identification of the party identified."
)]
[DerivedFrom(typeof(TypeOfIdentificationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeOfIdentification2Code>))]
#endif
public enum TypeOfIdentification2Code
{
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;ARNU&quot;.
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("__ztF5NojEeC60axPepSq7g_1743002948")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber = TypeOfIdentificationCode.AlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to a tax exempt entity.
    /// Encoded/decoded by serializers as &quot;CHTY&quot;.
    /// </summary>
    [EnumMember(Value = "CHTY")]
    [IsoId("__ztF5dojEeC60axPepSq7g_-721218168")]
    [Description(@"Number assigned to a tax exempt entity.")]
    TaxExemptIdentificationNumber = TypeOfIdentificationCode.TaxExemptIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to a corporate entity.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("__z224NojEeC60axPepSq7g_-1013175906")]
    [Description(@"Number assigned to a corporate entity.")]
    CorporateIdentification = TypeOfIdentificationCode.CorporateIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to a foreign investor (other than the alien number).
    /// Encoded/decoded by serializers as &quot;FIIN&quot;.
    /// </summary>
    [EnumMember(Value = "FIIN")]
    [IsoId("__z224dojEeC60axPepSq7g_-1896409193")]
    [Description(@"Number assigned to a foreign investor (other than the alien number).")]
    ForeignInvestmentIdentityNumber = TypeOfIdentificationCode.ForeignInvestmentIdentityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("__z224tojEeC60axPepSq7g_-1718290521")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber = TypeOfIdentificationCode.TaxIdentificationNumber, // same ordinal as derivation source for type conversions
}
