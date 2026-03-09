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
/// Company in charge of a vehicle rental service.
/// </summary>
[IsoId("_mU3xscWlEeuhguwJmlgagQ")]
[DisplayName("Vehicle Rental Company")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VehicleRentalCompany2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the vehicle rental company.
    /// </summary>
    [IsoId("_mZTlwcWlEeuhguwJmlgagQ")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the vehicle rental company.
    /// </summary>
    [IsoId("_mZTlw8WlEeuhguwJmlgagQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification258? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification258? Identification { get; init; } 
    #else
    public PartyIdentification258? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Address of the vehicle rental company.
    /// </summary>
    [IsoId("_mZTlxcWlEeuhguwJmlgagQ")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address2? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address2? Address { get; init; } 
    #else
    public Address2? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Contact details at vehicle rental company location.
    /// </summary>
    [IsoId("_mZTlx8WlEeuhguwJmlgagQ")]
    [DisplayName("Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctct")]
    #endif
    [IsoXmlTag("Ctct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contact3? Contact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact3? Contact { get; init; } 
    #else
    public Contact3? Contact { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the vehicle rental company.
    /// ISO 3166
    /// </summary>
    [IsoId("_mZTlycWlEeuhguwJmlgagQ")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISOMax3ACountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    /// <summary>
    /// Type of vehicle rental activity.
    /// </summary>
    [IsoId("_mZTly8WlEeuhguwJmlgagQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CarRentalActivity1Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CarRentalActivity1Code? Type { get; init; } 
    #else
    public CarRentalActivity1Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of vehicle rental activity. 
    /// </summary>
    [IsoId("_mZTlzcWlEeuhguwJmlgagQ")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
