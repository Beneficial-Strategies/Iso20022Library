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
/// Provides additional information regarding corporate action date details.
/// </summary>
[IsoId("_1ePnUzL3EeKU9IrkkToqcw_1659480407")]
[DisplayName("Corporate Action Date SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDateSD4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionDateSD4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionDateSD4( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1ePnVDL3EeKU9IrkkToqcw_662408054")]
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
    /// Date on which accounting for due bills starts and associated tracking begins.
    /// </summary>
    [IsoId("_1ePnVTL3EeKU9IrkkToqcw_-568372746")]
    [DisplayName("Interim Accounting Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmAcctgStartDt")]
    #endif
    [IsoXmlTag("IntrmAcctgStartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? InterimAccountingStartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? InterimAccountingStartDate { get; init; } 
    #else
    public System.DateOnly? InterimAccountingStartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the event security is no longer listed on the exchange.
    /// </summary>
    [IsoId("_1ePnVjL3EeKU9IrkkToqcw_-868959552")]
    [DisplayName("Delisting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlistgDt")]
    #endif
    [IsoXmlTag("DlistgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DelistingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DelistingDate { get; init; } 
    #else
    public System.DateOnly? DelistingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which a holder can exercise warrants.
    /// </summary>
    [IsoId("_1eZYUDL3EeKU9IrkkToqcw_608195982")]
    [DisplayName("Exercise Period Begin Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExrcPrdBegnDt")]
    #endif
    [IsoXmlTag("ExrcPrdBegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExercisePeriodBeginDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExercisePeriodBeginDate { get; init; } 
    #else
    public System.DateOnly? ExercisePeriodBeginDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which a holder listed as a member of the claimant group in a lawsuit may object to the proposed solution.
    /// </summary>
    [IsoId("_1eZYUTL3EeKU9IrkkToqcw_757336184")]
    [DisplayName("Objection Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ObjctnDt")]
    #endif
    [IsoXmlTag("ObjctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ObjectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ObjectionDate { get; init; } 
    #else
    public System.DateOnly? ObjectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which claimants may exclude themselves from an ongoing class action lawsuit.
    /// </summary>
    [IsoId("_1eZYUjL3EeKU9IrkkToqcw_526220081")]
    [DisplayName("Exclusion Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExclsnDt")]
    #endif
    [IsoXmlTag("ExclsnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExclusionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExclusionDate { get; init; } 
    #else
    public System.DateOnly? ExclusionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which a holder must file claim forms to become a member of the claimant group in a lawsuit.
    /// </summary>
    [IsoId("_1eZYUzL3EeKU9IrkkToqcw_338802594")]
    [DisplayName("Proof Of Claim Filing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ProofOfClmFilgDt")]
    #endif
    [IsoXmlTag("ProofOfClmFilgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ProofOfClaimFilingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ProofOfClaimFilingDate { get; init; } 
    #else
    public System.DateOnly? ProofOfClaimFilingDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
