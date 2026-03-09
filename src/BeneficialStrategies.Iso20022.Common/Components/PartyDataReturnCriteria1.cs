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
/// Return criteria for information to be returned in the report deriving from a query about party reference data.
/// </summary>
[IsoId("_kn1p4e5NEeCisYr99QEiWA_-418922110")]
[DisplayName("Party Data Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyDataReturnCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the opening date of the party is requested.
    /// </summary>
    [IsoId("_kn1p4u5NEeCisYr99QEiWA_1255511384")]
    [DisplayName("Opening Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngDt")]
    #endif
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? OpeningDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OpeningDate { get; init; } 
    #else
    public System.String? OpeningDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the closing date of the party is requested.
    /// </summary>
    [IsoId("_kn-z0O5NEeCisYr99QEiWA_1566614728")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClosingDate { get; init; } 
    #else
    public System.String? ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the type is requested.
    /// </summary>
    [IsoId("_kn-z0e5NEeCisYr99QEiWA_1233025915")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Type { get; init; } 
    #else
    public System.String? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the unique identification to unambiguously identify the party within the system is requested.
    /// </summary>
    [IsoId("_kn-z0u5NEeCisYr99QEiWA_-1567819817")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartyIdentification { get; init; } 
    #else
    public System.String? PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the central security depository or the national central bank who initially created the party reference data is requested.
    /// </summary>
    [IsoId("_kolQwO5NEeCisYr99QEiWA_-1130555111")]
    [DisplayName("CSD Or NCB")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CSDOrNCB")]
    #endif
    [IsoXmlTag("CSDOrNCB")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? CSDOrNCB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CSDOrNCB { get; init; } 
    #else
    public System.String? CSDOrNCB { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the identification of the restriction is requested.
    /// </summary>
    [IsoId("_kolQwe5NEeCisYr99QEiWA_987416096")]
    [DisplayName("Restriction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctnId")]
    #endif
    [IsoXmlTag("RstrctnId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? RestrictionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RestrictionIdentification { get; init; } 
    #else
    public System.String? RestrictionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the date at which a restriction for party has been issued is requested.
    /// </summary>
    [IsoId("_kolQwu5NEeCisYr99QEiWA_-1873928008")]
    [DisplayName("Restricted On Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctdOnDt")]
    #endif
    [IsoXmlTag("RstrctdOnDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? RestrictedOnDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RestrictedOnDate { get; init; } 
    #else
    public System.String? RestrictedOnDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the name for the party is requested.
    /// </summary>
    [IsoId("_kolQw-5NEeCisYr99QEiWA_-2011913913")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the short name for the party is requested.
    /// </summary>
    [IsoId("_kolQxO5NEeCisYr99QEiWA_1047483532")]
    [DisplayName("Short Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtNm")]
    #endif
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? ShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShortName { get; init; } 
    #else
    public System.String? ShortName { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the address for the party is requested.
    /// </summary>
    [IsoId("_kouasO5NEeCisYr99QEiWA_1541856106")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Address { get; init; } 
    #else
    public System.String? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the technical addresses for the party are requested.
    /// </summary>
    [IsoId("_kouase5NEeCisYr99QEiWA_-149516394")]
    [DisplayName("Technical Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechAdr")]
    #endif
    [IsoXmlTag("TechAdr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? TechnicalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TechnicalAddress { get; init; } 
    #else
    public System.String? TechnicalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the market specific attributes for the party are requested.
    /// </summary>
    [IsoId("_kouasu5NEeCisYr99QEiWA_707367313")]
    [DisplayName("Market Specific Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktSpcfcAttr")]
    #endif
    [IsoXmlTag("MktSpcfcAttr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? MarketSpecificAttribute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MarketSpecificAttribute { get; init; } 
    #else
    public System.String? MarketSpecificAttribute { get; set; } 
    #endif
    
    
    #nullable disable
    
}
