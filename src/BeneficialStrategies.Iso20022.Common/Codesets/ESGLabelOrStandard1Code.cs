// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the ESG label or standard of a product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eSB0MNA7EeuSBa1PsnseFg")]
[Description(@"Specifies the ESG label or standard of a product.")]
[DerivedFrom(typeof(ESGLabelOrStandardCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ESGLabelOrStandard1Code>))]
#endif
public enum ESGLabelOrStandard1Code
{
    /// <summary>
    /// Climate Bonds Initiative (CBI) Climate Bonds Standard.
    /// Encoded/decoded by serializers as &quot;E005&quot;.
    /// </summary>
    [EnumMember(Value = "E005")]
    [IsoId("_6j68gdA7EeuSBa1PsnseFg")]
    [Description(@"Climate Bonds Initiative (CBI) Climate Bonds Standard.")]
    CBIClimateBonds = ESGLabelOrStandardCode.CBIClimateBonds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EU Ecolabel for financial products.
    /// Encoded/decoded by serializers as &quot;C003&quot;.
    /// </summary>
    [EnumMember(Value = "C003")]
    [IsoId("_6o14wdA7EeuSBa1PsnseFg")]
    [Description(@"EU Ecolabel for financial products.")]
    EUEcolabel = ESGLabelOrStandardCode.EUEcolabel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EU Green Bond Standard.
    /// Encoded/decoded by serializers as &quot;B002&quot;.
    /// </summary>
    [EnumMember(Value = "B002")]
    [IsoId("_6w5BgdA7EeuSBa1PsnseFg")]
    [Description(@"EU Green Bond Standard.")]
    EUGreenBond = ESGLabelOrStandardCode.EUGreenBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Febelfin Towards Sustainability label.
    /// Encoded/decoded by serializers as &quot;L012&quot;.
    /// </summary>
    [EnumMember(Value = "L012")]
    [IsoId("_62_pgdA7EeuSBa1PsnseFg")]
    [Description(@"Febelfin Towards Sustainability label.")]
    FebelfinTowardsSustainability = ESGLabelOrStandardCode.FebelfinTowardsSustainability, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FNG-Siegel.
    /// Encoded/decoded by serializers as &quot;D004&quot;.
    /// </summary>
    [EnumMember(Value = "D004")]
    [IsoId("_6_CyQdA7EeuSBa1PsnseFg")]
    [Description(@"FNG-Siegel.")]
    FNGSiegel = ESGLabelOrStandardCode.FNGSiegel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Greenfin label.
    /// Encoded/decoded by serializers as &quot;O015&quot;.
    /// </summary>
    [EnumMember(Value = "O015")]
    [IsoId("_7KEWgdA7EeuSBa1PsnseFg")]
    [Description(@"Greenfin label.")]
    GreenfinLabel = ESGLabelOrStandardCode.GreenfinLabel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// International Capital Markets Association (ICMA) Green Bond Principles.
    /// Encoded/decoded by serializers as &quot;A001&quot;.
    /// </summary>
    [EnumMember(Value = "A001")]
    [IsoId("_7PIcsdA7EeuSBa1PsnseFg")]
    [Description(@"International Capital Markets Association (ICMA) Green Bond Principles.")]
    ICMAGreenBond = ESGLabelOrStandardCode.ICMAGreenBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// International Capital Markets Association (ICMA) Social Bonds Principles.
    /// Encoded/decoded by serializers as &quot;F006&quot;.
    /// </summary>
    [EnumMember(Value = "F006")]
    [IsoId("_7UgE4dA7EeuSBa1PsnseFg")]
    [Description(@"International Capital Markets Association (ICMA) Social Bonds Principles.")]
    ICMASocialBonds = ESGLabelOrStandardCode.ICMASocialBonds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Label &quot;Investissement Socialement Responsable&quot; (ISR).
    /// Encoded/decoded by serializers as &quot;K011&quot;.
    /// </summary>
    [EnumMember(Value = "K011")]
    [IsoId("_7Z3GAdA7EeuSBa1PsnseFg")]
    [Description(@"Label ""Investissement Socialement Responsable"" (ISR).")]
    ISR = ESGLabelOrStandardCode.ISR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Kein Verstoss gegen Atomwaffensperrvertrag.
    /// Encoded/decoded by serializers as &quot;J010&quot;.
    /// </summary>
    [EnumMember(Value = "J010")]
    [IsoId("_7iW6sdA7EeuSBa1PsnseFg")]
    [Description(@"Kein Verstoss gegen Atomwaffensperrvertrag.")]
    KeinVerstoßGegenAtomwaffensperrvertrag =
        ESGLabelOrStandardCode.KeinVerstoßGegenAtomwaffensperrvertrag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// LuxFLAG climate finance label.
    /// Encoded/decoded by serializers as &quot;H008&quot;.
    /// </summary>
    [EnumMember(Value = "H008")]
    [IsoId("_7oBd0dA7EeuSBa1PsnseFg")]
    [Description(@"LuxFLAG climate finance label.")]
    LuxFLAGClimate = ESGLabelOrStandardCode.LuxFLAGClimate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// LuxFLAG environment label.
    /// Encoded/decoded by serializers as &quot;I009&quot;.
    /// </summary>
    [EnumMember(Value = "I009")]
    [IsoId("_7uR20dA7EeuSBa1PsnseFg")]
    [Description(@"LuxFLAG environment label.")]
    LuxFLAGEnvironment = ESGLabelOrStandardCode.LuxFLAGEnvironment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// LuxFLAG ESG label.
    /// Encoded/decoded by serializers as &quot;G007&quot;.
    /// </summary>
    [EnumMember(Value = "G007")]
    [IsoId("_70iP0dA7EeuSBa1PsnseFg")]
    [Description(@"LuxFLAG ESG label.")]
    LuxFLAGESG = ESGLabelOrStandardCode.LuxFLAGESG, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Nordic Swan Ecolabel.
    /// Encoded/decoded by serializers as &quot;N014&quot;.
    /// </summary>
    [EnumMember(Value = "N014")]
    [IsoId("_78vJkdA7EeuSBa1PsnseFg")]
    [Description(@"Nordic Swan Ecolabel.")]
    NordicSwan = ESGLabelOrStandardCode.NordicSwan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// UZ49 - das Oesterreichische Umweltzeichen.
    /// Encoded/decoded by serializers as &quot;M013&quot;.
    /// </summary>
    [EnumMember(Value = "M013")]
    [IsoId("_8EohUdA7EeuSBa1PsnseFg")]
    [Description(@"UZ49 - das Oesterreichische Umweltzeichen.")]
    UZ49 = ESGLabelOrStandardCode.UZ49, // same ordinal as derivation source for type conversions
}
