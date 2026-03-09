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
/// Provides additional information regarding corporate action instructed balance details at option protect level.
/// </summary>
[IsoId("_lycUYegYEei5aPS232E3Mw")]
[DisplayName("Corporate Action Instructed Balance Option Protect Instruction SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionInstructedBalanceOptionProtectInstructionSD3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionInstructedBalanceOptionProtectInstructionSD3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionInstructedBalanceOptionProtectInstructionSD3( OptionNumber1Choice_ reqOptionNumber )
    {
        OptionNumber = reqOptionNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_mWv7UegYEei5aPS232E3Mw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Option number of the protect instruction.
    /// </summary>
    [IsoId("_mWv7U-gYEei5aPS232E3Mw")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionNumber1Choice_ OptionNumber { get; init; } 
    #else
    public OptionNumber1Choice_ OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// For cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account. The protect safekeeping account will be the account which submitted the original protect instruction.
    /// </summary>
    [IsoId("_mWv7XegYEei5aPS232E3Mw")]
    [DisplayName("Protect Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctSfkpgAcct")]
    #endif
    [IsoXmlTag("PrtctSfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINMax35Text? ProtectSafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProtectSafekeepingAccount { get; init; } 
    #else
    public System.String? ProtectSafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of the protect instruction which has not been covered.
    /// </summary>
    [IsoId("_mWv7Z-gYEei5aPS232E3Mw")]
    [DisplayName("Protect Identification Uncovered Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctIdUcvrdQty")]
    #endif
    [IsoXmlTag("PrtctIdUcvrdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationUncoveredQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationUncoveredQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationUncoveredQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Protect oversubscription quantity.
    /// </summary>
    [IsoId("_mWv7aegYEei5aPS232E3Mw")]
    [DisplayName("Protect Identification Oversubscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctIdOvrsbcptQty")]
    #endif
    [IsoXmlTag("PrtctIdOvrsbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationOversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationOversubscriptionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? ProtectIdentificationOversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the protect instruction.
    /// </summary>
    [IsoId("_mWv7a-gYEei5aPS232E3Mw")]
    [DisplayName("Protect Identification Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctIdSts")]
    #endif
    [IsoXmlTag("PrtctIdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCProtectInstructionStatus1Code? ProtectIdentificationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCProtectInstructionStatus1Code? ProtectIdentificationStatus { get; init; } 
    #else
    public DTCProtectInstructionStatus1Code? ProtectIdentificationStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
