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
/// Information which describes the organisation.
/// </summary>
[IsoId("_TsjBMW49EeiU9cctagi5ow")]
[DisplayName("Organisation Modification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrganisationModification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OrganisationModification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OrganisationModification2( FullLegalNameModification1 reqFullLegalName,string reqCountryOfOperation,AddressModification2 reqLegalAddress,OrganisationIdentification29 reqOrganisationIdentification )
    {
        FullLegalName = reqFullLegalName;
        CountryOfOperation = reqCountryOfOperation;
        LegalAddress = reqLegalAddress;
        OrganisationIdentification = reqOrganisationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_T4nHEW49EeiU9cctagi5ow")]
    [DisplayName("Full Legal Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullLglNm")]
    #endif
    [IsoXmlTag("FullLglNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FullLegalNameModification1 FullLegalName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FullLegalNameModification1 FullLegalName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FullLegalNameModification1 FullLegalName { get; init; } 
    #else
    public FullLegalNameModification1 FullLegalName { get; set; } 
    #endif
    
    /// <summary>
    /// Name used by a business for commercial purposes, although its registered legal name, used for contracts and other formal situations, may be another.
    /// </summary>
    [IsoId("_T4nHE249EeiU9cctagi5ow")]
    [DisplayName("Trading Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgNm")]
    #endif
    [IsoXmlTag("TradgNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradingNameModification1? TradingName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingNameModification1? TradingName { get; init; } 
    #else
    public TradingNameModification1? TradingName { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the organisation has its business activity.
    /// </summary>
    [IsoId("_T4nHFW49EeiU9cctagi5ow")]
    [DisplayName("Country Of Operation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfOpr")]
    #endif
    [IsoXmlTag("CtryOfOpr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode CountryOfOperation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string CountryOfOperation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string CountryOfOperation { get; init; } 
    #else
    public string CountryOfOperation { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_T4nHF249EeiU9cctagi5ow")]
    [DisplayName("Registration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnDt")]
    #endif
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RegistrationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RegistrationDate { get; init; } 
    #else
    public System.DateOnly? RegistrationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies an operational address, for example, of a shared services centre.
    /// </summary>
    [IsoId("_T4nHGW49EeiU9cctagi5ow")]
    [DisplayName("Operational Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OprlAdr")]
    #endif
    [IsoXmlTag("OprlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AddressModification2? OperationalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddressModification2? OperationalAddress { get; init; } 
    #else
    public AddressModification2? OperationalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the address where the business activity is taking place.
    /// </summary>
    [IsoId("_T4nHG249EeiU9cctagi5ow")]
    [DisplayName("Business Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizAdr")]
    #endif
    [IsoXmlTag("BizAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AddressModification2? BusinessAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddressModification2? BusinessAddress { get; init; } 
    #else
    public AddressModification2? BusinessAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the address where the entity resides and is registered. More generically, it is the home address (Residential address).
    /// </summary>
    [IsoId("_T4nHHW49EeiU9cctagi5ow")]
    [DisplayName("Legal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglAdr")]
    #endif
    [IsoXmlTag("LglAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AddressModification2 LegalAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AddressModification2 LegalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddressModification2 LegalAddress { get; init; } 
    #else
    public AddressModification2 LegalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Address where invoices must be sent.
    /// </summary>
    [IsoId("_T4nHH249EeiU9cctagi5ow")]
    [DisplayName("Billing Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllgAdr")]
    #endif
    [IsoXmlTag("BllgAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AddressModification2? BillingAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddressModification2? BillingAddress { get; init; } 
    #else
    public AddressModification2? BillingAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous way of identifying an organisation.
    /// </summary>
    [IsoId("_T4nHIW49EeiU9cctagi5ow")]
    [DisplayName("Organisation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgId")]
    #endif
    [IsoXmlTag("OrgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification29 OrganisationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification29 OrganisationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification29 OrganisationIdentification { get; init; } 
    #else
    public OrganisationIdentification29 OrganisationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Person in the customer&apos;s organisation who can be contacted by the account servicer in relation to the account(s) identified in this instruction.
    /// </summary>
    [IsoId("_T4nHI249EeiU9cctagi5ow")]
    [DisplayName("Representative Officer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprtvOffcr")]
    #endif
    [IsoXmlTag("RprtvOffcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyModification2? RepresentativeOfficer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyModification2? RepresentativeOfficer { get; init; } 
    #else
    public PartyModification2? RepresentativeOfficer { get; set; } 
    #endif
    
    /// <summary>
    /// Person responsible of the treasury department within the customer’s organisation.
    /// </summary>
    [IsoId("_T4nHJW49EeiU9cctagi5ow")]
    [DisplayName("Treasury Manager")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrsrMgr")]
    #endif
    [IsoXmlTag("TrsrMgr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyModification2? TreasuryManager { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyModification2? TreasuryManager { get; init; } 
    #else
    public PartyModification2? TreasuryManager { get; set; } 
    #endif
    
    /// <summary>
    /// Person that has the mandate to delegate authority, to assign mandates to other individuals (mandate holders) to perform specific bank operations on the account.
    /// </summary>
    [IsoId("_T4nHJ249EeiU9cctagi5ow")]
    [DisplayName("Main Mandate Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MainMndtHldr")]
    #endif
    [IsoXmlTag("MainMndtHldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyModification2? MainMandateHolder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyModification2? MainMandateHolder { get; init; } 
    #else
    public PartyModification2? MainMandateHolder { get; set; } 
    #endif
    
    /// <summary>
    /// Person that may be the potential sender of a message related to the life cycle of the account.
    /// </summary>
    [IsoId("_T4nHKW49EeiU9cctagi5ow")]
    [DisplayName("Sender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sndr")]
    #endif
    [IsoXmlTag("Sndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyModification2? Sender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyModification2? Sender { get; init; } 
    #else
    public PartyModification2? Sender { get; set; } 
    #endif
    
    /// <summary>
    /// Person that is officially and legally mandated to represent the organisation. Depending on legislation, the legal representative(s) might for instance be assigned by the Board, identified in the by-laws of the organisation, be publicly announced in the official journal of a country, etc.
    /// </summary>
    [IsoId("_T4nHK249EeiU9cctagi5ow")]
    [DisplayName("Legal Representative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglRprtv")]
    #endif
    [IsoXmlTag("LglRprtv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyModification2? LegalRepresentative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyModification2? LegalRepresentative { get; init; } 
    #else
    public PartyModification2? LegalRepresentative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
