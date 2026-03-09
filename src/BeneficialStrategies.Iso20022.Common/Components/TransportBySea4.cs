// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related for the transportation of goods by sea.
/// </summary>
[IsoId("_SuiA0tp-Ed-ak6NoX_4Aeg_-1269157967")]
[DisplayName("Transport By Sea")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportBySea4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransportBySea4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransportBySea4( System.String reqPortOfLoading,System.String reqPortOfDischarge )
    {
        PortOfLoading = reqPortOfLoading;
        PortOfDischarge = reqPortOfDischarge;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    [IsoId("_SuiA09p-Ed-ak6NoX_4Aeg_-1269157628")]
    [DisplayName("Port Of Loading")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PortOfLoadng")]
    #endif
    [IsoXmlTag("PortOfLoadng")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PortOfLoading { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PortOfLoading { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PortOfLoading { get; init; } 
    #else
    public System.String PortOfLoading { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    [IsoId("_SuiA1Np-Ed-ak6NoX_4Aeg_-1269157906")]
    [DisplayName("Port Of Discharge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PortOfDschrge")]
    #endif
    [IsoXmlTag("PortOfDschrge")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PortOfDischarge { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PortOfDischarge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PortOfDischarge { get; init; } 
    #else
    public System.String PortOfDischarge { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a vessel.
    /// </summary>
    [IsoId("_SuiA1dp-Ed-ak6NoX_4Aeg_-1269157965")]
    [DisplayName("Vessel Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VsslNm")]
    #endif
    [IsoXmlTag("VsslNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? VesselName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VesselName { get; init; } 
    #else
    public System.String? VesselName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_SuiA1tp-Ed-ak6NoX_4Aeg_-1764443526")]
    [DisplayName("Sea Carrier Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeaCrrierNm")]
    #endif
    [IsoXmlTag("SeaCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SeaCarrierName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SeaCarrierName { get; init; } 
    #else
    public System.String? SeaCarrierName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
