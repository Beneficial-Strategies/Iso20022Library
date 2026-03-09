// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the ESG label or standard of a product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XR6bsM2vEeuAE-cYsQdwHQ")]
[Description(@"Specifies the ESG label or standard of a product.")]
[Derivations(typeof(ESGLabelOrStandard1Code))]
public enum ESGLabelOrStandardCode
{
    /// <summary>
    /// International Capital Markets Association (ICMA) Green Bond Principles.
    /// Encoded/decoded by serializers as &quot;A001&quot;.
    /// </summary>
    [EnumMember(Value = "A001")]
    [IsoId("_Rmxy8M2xEeuAE-cYsQdwHQ")]
    [Description(@"International Capital Markets Association (ICMA) Green Bond Principles.")]
    ICMAGreenBond,
    
    /// <summary>
    /// EU Green Bond Standard.
    /// Encoded/decoded by serializers as &quot;B002&quot;.
    /// </summary>
    [EnumMember(Value = "B002")]
    [IsoId("_XDlZ4M2xEeuAE-cYsQdwHQ")]
    [Description(@"EU Green Bond Standard.")]
    EUGreenBond,
    
    /// <summary>
    /// EU Ecolabel for financial products.
    /// Encoded/decoded by serializers as &quot;C003&quot;.
    /// </summary>
    [EnumMember(Value = "C003")]
    [IsoId("_bozRgM2xEeuAE-cYsQdwHQ")]
    [Description(@"EU Ecolabel for financial products.")]
    EUEcolabel,
    
    /// <summary>
    /// FNG-Siegel.
    /// Encoded/decoded by serializers as &quot;D004&quot;.
    /// </summary>
    [EnumMember(Value = "D004")]
    [IsoId("_gIkocM2xEeuAE-cYsQdwHQ")]
    [Description(@"FNG-Siegel.")]
    FNGSiegel,
    
    /// <summary>
    /// Climate Bonds Initiative (CBI) Climate Bonds Standard.
    /// Encoded/decoded by serializers as &quot;E005&quot;.
    /// </summary>
    [EnumMember(Value = "E005")]
    [IsoId("_kHwa0M2xEeuAE-cYsQdwHQ")]
    [Description(@"Climate Bonds Initiative (CBI) Climate Bonds Standard.")]
    CBIClimateBonds,
    
    /// <summary>
    /// International Capital Markets Association (ICMA) Social Bonds Principles.
    /// Encoded/decoded by serializers as &quot;F006&quot;.
    /// </summary>
    [EnumMember(Value = "F006")]
    [IsoId("_qL8K0M2xEeuAE-cYsQdwHQ")]
    [Description(@"International Capital Markets Association (ICMA) Social Bonds Principles.")]
    ICMASocialBonds,
    
    /// <summary>
    /// LuxFLAG ESG label.
    /// Encoded/decoded by serializers as &quot;G007&quot;.
    /// </summary>
    [EnumMember(Value = "G007")]
    [IsoId("_uZwPEM2xEeuAE-cYsQdwHQ")]
    [Description(@"LuxFLAG ESG label.")]
    LuxFLAGESG,
    
    /// <summary>
    /// LuxFLAG climate finance label.
    /// Encoded/decoded by serializers as &quot;H008&quot;.
    /// </summary>
    [EnumMember(Value = "H008")]
    [IsoId("_x5fFUM2xEeuAE-cYsQdwHQ")]
    [Description(@"LuxFLAG climate finance label.")]
    LuxFLAGClimate,
    
    /// <summary>
    /// LuxFLAG environment label.
    /// Encoded/decoded by serializers as &quot;I009&quot;.
    /// </summary>
    [EnumMember(Value = "I009")]
    [IsoId("_7UqmUM2xEeuAE-cYsQdwHQ")]
    [Description(@"LuxFLAG environment label.")]
    LuxFLAGEnvironment,
    
    /// <summary>
    /// Kein Verstoss gegen Atomwaffensperrvertrag.
    /// Encoded/decoded by serializers as &quot;J010&quot;.
    /// </summary>
    [EnumMember(Value = "J010")]
    [IsoId("_ATLuwM2yEeuAE-cYsQdwHQ")]
    [Description(@"Kein Verstoss gegen Atomwaffensperrvertrag.")]
    KeinVerstoßGegenAtomwaffensperrvertrag,
    
    /// <summary>
    /// Label &quot;Investissement Socialement Responsable&quot; (ISR).
    /// Encoded/decoded by serializers as &quot;K011&quot;.
    /// </summary>
    [EnumMember(Value = "K011")]
    [IsoId("_EENJUM2yEeuAE-cYsQdwHQ")]
    [Description(@"Label ""Investissement Socialement Responsable"" (ISR).")]
    ISR,
    
    /// <summary>
    /// Febelfin Towards Sustainability label.
    /// Encoded/decoded by serializers as &quot;L012&quot;.
    /// </summary>
    [EnumMember(Value = "L012")]
    [IsoId("_JiJ_wM2yEeuAE-cYsQdwHQ")]
    [Description(@"Febelfin Towards Sustainability label.")]
    FebelfinTowardsSustainability,
    
    /// <summary>
    /// UZ49 - das Oesterreichische Umweltzeichen.
    /// Encoded/decoded by serializers as &quot;M013&quot;.
    /// </summary>
    [EnumMember(Value = "M013")]
    [IsoId("_NtUYoM2yEeuAE-cYsQdwHQ")]
    [Description(@"UZ49 - das Oesterreichische Umweltzeichen.")]
    UZ49,
    
    /// <summary>
    /// Nordic Swan Ecolabel.
    /// Encoded/decoded by serializers as &quot;N014&quot;.
    /// </summary>
    [EnumMember(Value = "N014")]
    [IsoId("_SlY60M2yEeuAE-cYsQdwHQ")]
    [Description(@"Nordic Swan Ecolabel.")]
    NordicSwan,
    
    /// <summary>
    /// Greenfin label.
    /// Encoded/decoded by serializers as &quot;O015&quot;.
    /// </summary>
    [EnumMember(Value = "O015")]
    [IsoId("_VitAgM2yEeuAE-cYsQdwHQ")]
    [Description(@"Greenfin label.")]
    GreenfinLabel,
    
}
