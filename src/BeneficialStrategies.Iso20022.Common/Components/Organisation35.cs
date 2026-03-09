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
/// Organised structure that is set up for a particular purpose. For example, a business, government body, department, charity, or financial institution.
/// </summary>
[IsoId("_XjHp9249EeiU9cctagi5ow")]
[DisplayName("Organisation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Organisation35
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Organisation35 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Organisation35( System.String reqFullLegalName )
    {
        FullLegalName = reqFullLegalName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_XtGsYW49EeiU9cctagi5ow")]
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
    [IsoId("_XtGsY249EeiU9cctagi5ow")]
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
    /// Status of a legal entity.
    /// </summary>
    [IsoId("_XtGsZW49EeiU9cctagi5ow")]
    [DisplayName("Organisation Legal Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgLglSts")]
    #endif
    [IsoXmlTag("OrgLglSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationLegalStatus1Code? OrganisationLegalStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationLegalStatus1Code? OrganisationLegalStatus { get; init; } 
    #else
    public OrganisationLegalStatus1Code? OrganisationLegalStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Date of establishment or date of founding of an institution is the date on which that institution chooses to claim as its starting point.
    /// </summary>
    [IsoId("_XtGsZ249EeiU9cctagi5ow")]
    [DisplayName("Established Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstblishdDt")]
    #endif
    [IsoXmlTag("EstblishdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EstablishedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EstablishedDate { get; init; } 
    #else
    public System.DateOnly? EstablishedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Registration number for the organisation.
    /// </summary>
    [IsoId("_XtGsaW49EeiU9cctagi5ow")]
    [DisplayName("Registration Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnNb")]
    #endif
    [IsoXmlTag("RegnNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? RegistrationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RegistrationNumber { get; init; } 
    #else
    public System.String? RegistrationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    [IsoId("_XtGsa249EeiU9cctagi5ow")]
    [DisplayName("Registration Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnCtry")]
    #endif
    [IsoXmlTag("RegnCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? RegistrationCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RegistrationCountry { get; init; } 
    #else
    public string? RegistrationCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Date a given organisation was officially registered.
    /// </summary>
    [IsoId("_XtGsbW49EeiU9cctagi5ow")]
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
    /// Taxation unique reference number.
    /// </summary>
    [IsoId("_XtGsb249EeiU9cctagi5ow")]
    [DisplayName("Taxation Identification Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxtnIdNb")]
    #endif
    [IsoXmlTag("TaxtnIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TaxationIdentificationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxationIdentificationNumber { get; init; } 
    #else
    public System.String? TaxationIdentificationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Country of taxation of an individual person or an organisation.
    /// </summary>
    [IsoId("_XtGscW49EeiU9cctagi5ow")]
    [DisplayName("Taxation Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxtnCtry")]
    #endif
    [IsoXmlTag("TaxtnCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? TaxationCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TaxationCountry { get; init; } 
    #else
    public string? TaxationCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the organisation has its business activity.
    /// </summary>
    [IsoId("_XtGsc249EeiU9cctagi5ow")]
    [DisplayName("Country Of Operation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfOpr")]
    #endif
    [IsoXmlTag("CtryOfOpr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfOperation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfOperation { get; init; } 
    #else
    public string? CountryOfOperation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the new bank holds a copy of a registered company’s board resolution for the account switch.
    /// </summary>
    [IsoId("_XtGsdW49EeiU9cctagi5ow")]
    [DisplayName("Board Resolution Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrdRsltnInd")]
    #endif
    [IsoXmlTag("BrdRsltnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? BoardResolutionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BoardResolutionIndicator { get; init; } 
    #else
    public System.String? BoardResolutionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Address where the business activity is taking place.
    /// </summary>
    [IsoId("_XtGsd249EeiU9cctagi5ow")]
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
    /// Address, for example, of a shared services centre.
    /// </summary>
    [IsoId("_XtGseW49EeiU9cctagi5ow")]
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
    /// Address where the entity resides and is registered. More generically, it is the home address (residential address).
    /// </summary>
    [IsoId("_XtGse249EeiU9cctagi5ow")]
    [DisplayName("Legal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglAdr")]
    #endif
    [IsoXmlTag("LglAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress24? LegalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress24? LegalAddress { get; init; } 
    #else
    public PostalAddress24? LegalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Person in the customer&apos;s organisation who can be contacted by the account servicer.
    /// </summary>
    [IsoId("_XtGsfW49EeiU9cctagi5ow")]
    [DisplayName("Representative Officer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprtvOffcr")]
    #endif
    [IsoXmlTag("RprtvOffcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? RepresentativeOfficer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? RepresentativeOfficer { get; init; } 
    #else
    public PartyIdentification135? RepresentativeOfficer { get; set; } 
    #endif
    
    /// <summary>
    /// Person responsible of the treasury department within an organisation.
    /// </summary>
    [IsoId("_XtGsf249EeiU9cctagi5ow")]
    [DisplayName("Treasury Manager")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrsrMgr")]
    #endif
    [IsoXmlTag("TrsrMgr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? TreasuryManager { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? TreasuryManager { get; init; } 
    #else
    public PartyIdentification135? TreasuryManager { get; set; } 
    #endif
    
    /// <summary>
    /// Person who will delegate some authority to other individuals (mandate holders) to perform some specific bank operations on the account.
    /// </summary>
    [IsoId("_XtGsgW49EeiU9cctagi5ow")]
    [DisplayName("Main Mandate Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MainMndtHldr")]
    #endif
    [IsoXmlTag("MainMndtHldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? MainMandateHolder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? MainMandateHolder { get; init; } 
    #else
    public PartyIdentification135? MainMandateHolder { get; set; } 
    #endif
    
    /// <summary>
    /// Sender of a message related to the life cycle of an account.
    /// </summary>
    [IsoId("_XtGsg249EeiU9cctagi5ow")]
    [DisplayName("Sender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sndr")]
    #endif
    [IsoXmlTag("Sndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? Sender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? Sender { get; init; } 
    #else
    public PartyIdentification135? Sender { get; set; } 
    #endif
    
    
    #nullable disable
    
}
