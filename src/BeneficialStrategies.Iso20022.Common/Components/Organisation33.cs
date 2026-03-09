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
[IsoId("_B8VHuW49EeiU9cctagi5ow")]
[DisplayName("Organisation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Organisation33
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Organisation33 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Organisation33( System.String reqFullLegalName,string reqCountryOfOperation,PostalAddress24 reqLegalAddress,OrganisationIdentification29 reqOrganisationIdentification )
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
    [IsoId("_CFttMW49EeiU9cctagi5ow")]
    [DisplayName("Full Legal Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullLglNm")]
    #endif
    [IsoXmlTag("FullLglNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text FullLegalName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FullLegalName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FullLegalName { get; init; } 
    #else
    public System.String FullLegalName { get; set; } 
    #endif
    
    /// <summary>
    /// Name used by a business for commercial purposes, although its registered legal name, used for contracts and other formal situations, may be another.
    /// </summary>
    [IsoId("_CFttM249EeiU9cctagi5ow")]
    [DisplayName("Trading Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgNm")]
    #endif
    [IsoXmlTag("TradgNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? TradingName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradingName { get; init; } 
    #else
    public System.String? TradingName { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the organisation has its business activity.
    /// </summary>
    [IsoId("_CFttNW49EeiU9cctagi5ow")]
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
    [IsoId("_CFttN249EeiU9cctagi5ow")]
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
    [IsoId("_CFttOW49EeiU9cctagi5ow")]
    [DisplayName("Operational Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OprlAdr")]
    #endif
    [IsoXmlTag("OprlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress24? OperationalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress24? OperationalAddress { get; init; } 
    #else
    public PostalAddress24? OperationalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the address where the business activity is taking place.
    /// </summary>
    [IsoId("_CFttO249EeiU9cctagi5ow")]
    [DisplayName("Business Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizAdr")]
    #endif
    [IsoXmlTag("BizAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress24? BusinessAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress24? BusinessAddress { get; init; } 
    #else
    public PostalAddress24? BusinessAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the address where the entity resides and is registered. More generically, it is the home address (Residential address).
    /// </summary>
    [IsoId("_CFttPW49EeiU9cctagi5ow")]
    [DisplayName("Legal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglAdr")]
    #endif
    [IsoXmlTag("LglAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PostalAddress24 LegalAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PostalAddress24 LegalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress24 LegalAddress { get; init; } 
    #else
    public PostalAddress24 LegalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Address where invoices must be sent.
    /// </summary>
    [IsoId("_CFttP249EeiU9cctagi5ow")]
    [DisplayName("Billing Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllgAdr")]
    #endif
    [IsoXmlTag("BllgAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress24? BillingAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress24? BillingAddress { get; init; } 
    #else
    public PostalAddress24? BillingAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous way of identifying an organisation.
    /// </summary>
    [IsoId("_CFttQW49EeiU9cctagi5ow")]
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
    [IsoId("_CFttQ249EeiU9cctagi5ow")]
    [DisplayName("Representative Officer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprtvOffcr")]
    #endif
    [IsoXmlTag("RprtvOffcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137? RepresentativeOfficer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137? RepresentativeOfficer { get; init; } 
    #else
    public PartyIdentification137? RepresentativeOfficer { get; set; } 
    #endif
    
    /// <summary>
    /// Person responsible of the treasury department within the customer’s organisation.
    /// </summary>
    [IsoId("_CFttRW49EeiU9cctagi5ow")]
    [DisplayName("Treasury Manager")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrsrMgr")]
    #endif
    [IsoXmlTag("TrsrMgr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137? TreasuryManager { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137? TreasuryManager { get; init; } 
    #else
    public PartyIdentification137? TreasuryManager { get; set; } 
    #endif
    
    /// <summary>
    /// Person that has the mandate to delegate authority, to assign mandates to other individuals (mandate holders) to perform specific bank operations on the account.
    /// </summary>
    [IsoId("_CFttR249EeiU9cctagi5ow")]
    [DisplayName("Main Mandate Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MainMndtHldr")]
    #endif
    [IsoXmlTag("MainMndtHldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137? MainMandateHolder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137? MainMandateHolder { get; init; } 
    #else
    public PartyIdentification137? MainMandateHolder { get; set; } 
    #endif
    
    /// <summary>
    /// Person that may be the potential sender of a message related to the life cycle of the account.
    /// </summary>
    [IsoId("_CFttSW49EeiU9cctagi5ow")]
    [DisplayName("Sender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sndr")]
    #endif
    [IsoXmlTag("Sndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137? Sender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137? Sender { get; init; } 
    #else
    public PartyIdentification137? Sender { get; set; } 
    #endif
    
    /// <summary>
    /// Person that is officially and legally mandated to represent the organisation. Depending on legislation, the legal representative(s) might for instance be assigned by the Board, identified in the by-laws of the organisation, be publicly announced in the official journal of a country, etc.
    /// </summary>
    [IsoId("_CFttS249EeiU9cctagi5ow")]
    [DisplayName("Legal Representative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglRprtv")]
    #endif
    [IsoXmlTag("LglRprtv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137? LegalRepresentative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137? LegalRepresentative { get; init; } 
    #else
    public PartyIdentification137? LegalRepresentative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
