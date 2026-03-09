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
/// Customer renting a vehicle.
/// </summary>
[IsoId("_fx0Cj_SsEeife6veM7daYw")]
[DisplayName("Vehicle Rental Customer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VehicleRentalCustomer1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VehicleRentalCustomer1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VehicleRentalCustomer1( System.String reqRenterName,System.String reqCorporateIdentifier )
    {
        RenterName = reqRenterName;
        CorporateIdentifier = reqCorporateIdentifier;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the vehicle rental customer.
    /// </summary>
    [IsoId("_fx0CkfSsEeife6veM7daYw")]
    [DisplayName("Renter Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RntrNm")]
    #endif
    [IsoXmlTag("RntrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text RenterName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RenterName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RenterName { get; init; } 
    #else
    public System.String RenterName { get; set; } 
    #endif
    
    /// <summary>
    /// Corporate name of the vehicle rental customer.
    /// </summary>
    [IsoId("_fx0CmPSsEeife6veM7daYw")]
    [DisplayName("Corporate Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpNm")]
    #endif
    [IsoXmlTag("CorpNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CorporateName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CorporateName { get; init; } 
    #else
    public System.String? CorporateName { get; set; } 
    #endif
    
    /// <summary>
    /// Corporate identifier of the vehicle rental customer.
    /// </summary>
    [IsoId("_fx0pkPSsEeife6veM7daYw")]
    [DisplayName("Corporate Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpIdr")]
    #endif
    [IsoXmlTag("CorpIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CorporateIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CorporateIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CorporateIdentifier { get; init; } 
    #else
    public System.String CorporateIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Party assigning an identification to a vehicle rental customer.
    /// </summary>
    [IsoId("_fx0Cl_SsEeife6veM7daYw")]
    [DisplayName("Assigner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnr")]
    #endif
    [IsoXmlTag("Assgnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerAssigner1Code? Assigner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerAssigner1Code? Assigner { get; init; } 
    #else
    public CustomerAssigner1Code? Assigner { get; set; } 
    #endif
    
    /// <summary>
    /// Vehicle rental driver.
    /// </summary>
    [IsoId("_fx0ClPSsEeife6veM7daYw")]
    [DisplayName("Primary Driver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryDrvr")]
    #endif
    [IsoXmlTag("PmryDrvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DriverInParty1? PrimaryDriver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DriverInParty1? PrimaryDriver { get; init; } 
    #else
    public DriverInParty1? PrimaryDriver { get; set; } 
    #endif
    
    /// <summary>
    /// Type of identification of the additional vehicle rental customer.
    /// </summary>
    [IsoId("_fx0CmfSsEeife6veM7daYw")]
    [DisplayName("Additional Driver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlDrvr")]
    #endif
    [IsoXmlTag("AddtlDrvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DriverInParty1? AdditionalDriver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DriverInParty1? AdditionalDriver { get; init; } 
    #else
    public DriverInParty1? AdditionalDriver { get; set; } 
    #endif
    
    /// <summary>
    /// Loyalty programme details. 
    /// </summary>
    [IsoId("_sLqMsfSvEeife6veM7daYw")]
    [DisplayName("Loyalty Programme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyPrgrmm")]
    #endif
    [IsoXmlTag("LltyPrgrmm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; } 
    #else
    public LoyaltyProgramme2? LoyaltyProgramme { get; set; } 
    #endif
    
    
    #nullable disable
    
}
