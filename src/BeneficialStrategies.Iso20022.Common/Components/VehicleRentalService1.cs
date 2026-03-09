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
/// Vehicle rental service provides detailed vehicle rental information.
/// </summary>
[IsoId("_9dqxI_TdEeife6veM7daYw")]
[DisplayName("Vehicle Rental Service")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VehicleRentalService1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Company in charge of a vehicle rental service.
    /// </summary>
    [IsoId("_9dqxJPTdEeife6veM7daYw")]
    [DisplayName("Vehicle Rental Company")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VhclRntlCpny")]
    #endif
    [IsoXmlTag("VhclRntlCpny")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VehicleRentalCompany1? VehicleRentalCompany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VehicleRentalCompany1? VehicleRentalCompany { get; init; } 
    #else
    public VehicleRentalCompany1? VehicleRentalCompany { get; set; } 
    #endif
    
    /// <summary>
    /// Customer renting a vehicle.
    /// </summary>
    [IsoId("_9dqxJfTdEeife6veM7daYw")]
    [DisplayName("Customer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cstmr")]
    #endif
    [IsoXmlTag("Cstmr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VehicleRentalCustomer1? Customer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VehicleRentalCustomer1? Customer { get; init; } 
    #else
    public VehicleRentalCustomer1? Customer { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_h6EcwfTeEeife6veM7daYw")]
    [DisplayName("Summary Commodity Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SummryCmmdtyId")]
    #endif
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SummaryCommodityIdentification { get; init; } 
    #else
    public System.String? SummaryCommodityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement (contract) related to a vehicle rental service.
    /// </summary>
    [IsoId("_exWYUPTeEeife6veM7daYw")]
    [DisplayName("Rental Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RntlAgrmt")]
    #endif
    [IsoXmlTag("RntlAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VehicleRentalAgreement1? RentalAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VehicleRentalAgreement1? RentalAgreement { get; init; } 
    #else
    public VehicleRentalAgreement1? RentalAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Invoice related to a vehicle rental service.
    /// </summary>
    [IsoId("_sJKG8PTeEeife6veM7daYw")]
    [DisplayName("Rental Invoice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RntlInvc")]
    #endif
    [IsoXmlTag("RntlInvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VehicleRentalInvoice1? RentalInvoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VehicleRentalInvoice1? RentalInvoice { get; init; } 
    #else
    public VehicleRentalInvoice1? RentalInvoice { get; set; } 
    #endif
    
    /// <summary>
    /// Additional user-defined data pertaining to the vehicle rental. 
    /// </summary>
    [IsoId("_w51nsfTeEeife6veM7daYw")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
