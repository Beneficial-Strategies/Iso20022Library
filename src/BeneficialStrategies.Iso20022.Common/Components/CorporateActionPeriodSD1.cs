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
/// Provides additional information regarding corporate action details periods details.
/// </summary>
[IsoId("_1TE5JjL3EeKU9IrkkToqcw_-513074553")]
[DisplayName("Corporate Action Period SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPeriodSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionPeriodSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionPeriodSD1( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1TODEDL3EeKU9IrkkToqcw_1666762332")]
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
    /// Period during which the securities can be submitted to Reorganisation deposit service at DTC (The Depository Trust Corporation). DTC First Day for Reorg Deposit (start date) is the day on which security is eligible for reorganisation deposit service at DTC. DTC Last Day for Reorg Deposit is the last day on which securities are eligible to be submitted for reorganisation deposit service at DTC.
    /// </summary>
    [IsoId("_1TODETL3EeKU9IrkkToqcw_-626663858")]
    [DisplayName("DTC Reorganisation Deposit Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCReorgDpstPrd")]
    #endif
    [IsoXmlTag("DTCReorgDpstPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period3? DTCReorganisationDepositPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period3? DTCReorganisationDepositPeriod { get; init; } 
    #else
    public Period3? DTCReorganisationDepositPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the co-depositories deliveries are suspended at DTC (The Depository Trust Corporation). DTC Last Day for Depository Delivery (start date) - the last day on which depository deliveries will be accepted. DTC Chill Release Day for Depository Delivery (end date) - day when chill is released and depositories can resume delivery activities.
    /// </summary>
    [IsoId("_1TODEjL3EeKU9IrkkToqcw_-285404633")]
    [DisplayName("DTC Chill Period For Depository Delivery")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCChillPrdForDpstryDlvry")]
    #endif
    [IsoXmlTag("DTCChillPrdForDpstryDlvry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period3? DTCChillPeriodForDepositoryDelivery { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period3? DTCChillPeriodForDepositoryDelivery { get; init; } 
    #else
    public Period3? DTCChillPeriodForDepositoryDelivery { get; set; } 
    #endif
    
    
    #nullable disable
    
}
