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
/// Provides additional information regarding corporate action option details.
/// </summary>
[IsoId("_1e_1RDL3EeKU9IrkkToqcw_-1892432228")]
[DisplayName("Corporate Action Option SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionOptionSD5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionOptionSD5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionOptionSD5( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1e_1RTL3EeKU9IrkkToqcw_-2017370071")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Workflow status of the specified option based on the consistency of the issuer declared data elements (excluding DTC data elements).
    /// </summary>
    [IsoId("_1fI_MDL3EeKU9IrkkToqcw_-713619834")]
    [DisplayName("Option Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnSts")]
    #endif
    [IsoXmlTag("OptnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public WorkflowStatus1Code? OptionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public WorkflowStatus1Code? OptionStatus { get; init; } 
    #else
    public WorkflowStatus1Code? OptionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the offeror will select random lots if the offer has been prorated. The offeror may accept or reject conditional tenders on a random basis. Holders must indicate their willingness to have their rejected conditional tender accepted by random lot (if necessary). The holder must surrender all shares held in order to be eligible for this preference.
    /// </summary>
    [IsoId("_1fI_MTL3EeKU9IrkkToqcw_-1595253566")]
    [DisplayName("Random Lot Preference Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RandLotPrefFlg")]
    #endif
    [IsoXmlTag("RandLotPrefFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RandomLotPreferenceFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RandomLotPreferenceFlag { get; init; } 
    #else
    public System.String? RandomLotPreferenceFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the new shares to be issued will be distributed, as opposed to the &quot;declared payable date.&quot; This date is typically used in some Asian markets.
    /// </summary>
    [IsoId("_1fI_MjL3EeKU9IrkkToqcw_-1644636037")]
    [DisplayName("New Share Dispatched Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewShrDsptchdDt")]
    #endif
    [IsoXmlTag("NewShrDsptchdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? NewShareDispatchedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? NewShareDispatchedDate { get; init; } 
    #else
    public System.DateOnly? NewShareDispatchedDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
