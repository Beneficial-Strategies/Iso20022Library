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
[IsoId("_SuYP39p-Ed-ak6NoX_4Aeg_-719790573")]
[DisplayName("Transport By Sea")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportBySea3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    [IsoId("_SuYP4Np-Ed-ak6NoX_4Aeg_-719790542")]
    [DisplayName("Port Of Loading")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PortOfLoadng")]
    #endif
    [IsoXmlTag("PortOfLoadng")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PortOfLoading { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PortOfLoading { get; init; } 
    #else
    public System.String? PortOfLoading { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    [IsoId("_SuiA0Np-Ed-ak6NoX_4Aeg_-719790520")]
    [DisplayName("Port Of Discharge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PortOfDschrge")]
    #endif
    [IsoXmlTag("PortOfDschrge")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    public SimpleValueList<System.String> PortOfDischarge { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SuiA0Np-Ed-ak6NoX_4Aeg_-719790520
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_SuiA0dp-Ed-ak6NoX_4Aeg_-719790397")]
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
