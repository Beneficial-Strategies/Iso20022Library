// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Maintenance services provided by a terminal manager.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_b3W8wGpcEeS4r8z7dKyh1g")]
[Description(@"Maintenance services provided by a terminal manager.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory5Code
{
    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;AQPR&quot;.
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_gSqqcWpcEeS4r8z7dKyh1g")]
    [Description(@"Acquirer specific configuration parameters for the point of interaction (POI) system.")]
    AcquirerParameters = DataSetCategoryCode.AcquirerParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_gb0mcWpcEeS4r8z7dKyh1g")]
    [Description(@"Payment application specific configuration parameters for the point of interaction (POI) system.")]
    ApplicationParameters = DataSetCategoryCode.ApplicationParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The terminal manager is the master.
    /// Encoded/decoded by serializers as &quot;MTMG&quot;.
    /// </summary>
    [EnumMember(Value = "MTMG")]
    [IsoId("_hYUq8WpcEeS4r8z7dKyh1g")]
    [Description(@"The terminal manager is the master.")]
    MasterTerminalManager = DataSetCategoryCode.MasterTerminalManager, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as &quot;MRPR&quot;.
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_hj8sIWpcEeS4r8z7dKyh1g")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = DataSetCategoryCode.MerchantParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Monitoring of the terminal estate.
    /// Encoded/decoded by serializers as &quot;MTOR&quot;.
    /// </summary>
    [EnumMember(Value = "MTOR")]
    [IsoId("_hrsS4WpcEeS4r8z7dKyh1g")]
    [Description(@"Monitoring of the terminal estate.")]
    Monitoring = DataSetCategoryCode.Monitoring, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// Encoded/decoded by serializers as &quot;SCPR&quot;.
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_ixk84WpcEeS4r8z7dKyh1g")]
    [Description(@"Point of interaction parameters related to the security of software application and application protocol.")]
    SecurityParameters = DataSetCategoryCode.SecurityParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as &quot;SWPK&quot;.
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_i6OikWpcEeS4r8z7dKyh1g")]
    [Description(@"Software module.")]
    SoftwareModule = DataSetCategoryCode.SoftwareModule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters attached to the terminal as serial number or physical capabilities.
    /// Encoded/decoded by serializers as &quot;TRPR&quot;.
    /// </summary>
    [EnumMember(Value = "TRPR")]
    [IsoId("_jPr1MWpcEeS4r8z7dKyh1g")]
    [Description(@"Point of interaction parameters attached to the terminal as serial number or physical capabilities.")]
    TerminalParameters = DataSetCategoryCode.TerminalParameters, // same ordinal as derivation source for type conversions
    
}
