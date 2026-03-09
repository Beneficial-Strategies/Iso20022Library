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
[IsoId("_QM2HONp-Ed-ak6NoX_4Aeg_-1220331346")]
[DisplayName("Organisation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Organisation7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Organisation7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Organisation7( System.String reqFullLegalName,string reqCountryOfOperation,System.DateOnly reqRegistrationDate,PostalAddress6 reqLegalAddress,OrganisationIdentification6 reqOrganisationIdentification )
    {
        FullLegalName = reqFullLegalName;
        CountryOfOperation = reqCountryOfOperation;
        RegistrationDate = reqRegistrationDate;
        LegalAddress = reqLegalAddress;
        OrganisationIdentification = reqOrganisationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QM2HOdp-Ed-ak6NoX_4Aeg_-1334170412")]
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
    [IsoId("_QM2HOtp-Ed-ak6NoX_4Aeg_1963724531")]
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
    [IsoId("_QM_4MNp-Ed-ak6NoX_4Aeg_966652178")]
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
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_QM_4Mdp-Ed-ak6NoX_4Aeg_-30420175")]
    [DisplayName("Registration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnDt")]
    #endif
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate RegistrationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly RegistrationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly RegistrationDate { get; init; } 
    #else
    public System.DateOnly RegistrationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Is an operational address, for example, of a shared services center.
    /// </summary>
    [IsoId("_QM_4Mtp-Ed-ak6NoX_4Aeg_-1205611200")]
    [DisplayName("Operational Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OprlAdr")]
    #endif
    [IsoXmlTag("OprlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress6? OperationalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress6? OperationalAddress { get; init; } 
    #else
    public PostalAddress6? OperationalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Is the address where the business activity is taking place.
    /// </summary>
    [IsoId("_QM_4M9p-Ed-ak6NoX_4Aeg_2092283743")]
    [DisplayName("Business Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizAdr")]
    #endif
    [IsoXmlTag("BizAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress6? BusinessAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress6? BusinessAddress { get; init; } 
    #else
    public PostalAddress6? BusinessAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Is the address where the entity resides and is registered. More generically, it is the home address (Residential address).
    /// </summary>
    [IsoId("_QM_4NNp-Ed-ak6NoX_4Aeg_1095211390")]
    [DisplayName("Legal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglAdr")]
    #endif
    [IsoXmlTag("LglAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PostalAddress6 LegalAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PostalAddress6 LegalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress6 LegalAddress { get; init; } 
    #else
    public PostalAddress6 LegalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous way of identifying an organisation.
    /// </summary>
    [IsoId("_QM_4Ndp-Ed-ak6NoX_4Aeg_-1262530733")]
    [DisplayName("Organisation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgId")]
    #endif
    [IsoXmlTag("OrgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification6 OrganisationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification6 OrganisationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification6 OrganisationIdentification { get; init; } 
    #else
    public OrganisationIdentification6 OrganisationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Person in the customer&apos;s organisation who can be contacted by the account servicer.
    /// </summary>
    [IsoId("_QM_4Ntp-Ed-ak6NoX_4Aeg_2035364210")]
    [DisplayName("Representative Officer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprtvOffcr")]
    #endif
    [IsoXmlTag("RprtvOffcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification40? RepresentativeOfficer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification40? RepresentativeOfficer { get; init; } 
    #else
    public PartyIdentification40? RepresentativeOfficer { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the person responsible of the treasury department within an organisation.
    /// </summary>
    [IsoId("_QM_4N9p-Ed-ak6NoX_4Aeg_1038291857")]
    [DisplayName("Treasury Manager")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrsrMgr")]
    #endif
    [IsoXmlTag("TrsrMgr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification40? TreasuryManager { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification40? TreasuryManager { get; init; } 
    #else
    public PartyIdentification40? TreasuryManager { get; set; } 
    #endif
    
    /// <summary>
    /// Is the main mandate holder that will delegate some authority to other individuals (mandate holders) to perform some specific bank operations on the account.
    /// </summary>
    [IsoId("_QM_4ONp-Ed-ak6NoX_4Aeg_41219504")]
    [DisplayName("Main Mandate Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MainMndtHldr")]
    #endif
    [IsoXmlTag("MainMndtHldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification40? MainMandateHolder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification40? MainMandateHolder { get; init; } 
    #else
    public PartyIdentification40? MainMandateHolder { get; set; } 
    #endif
    
    /// <summary>
    /// Potential sender of a message related to the life cyle of an account.
    /// </summary>
    [IsoId("_QM_4Odp-Ed-ak6NoX_4Aeg_-878814148")]
    [DisplayName("Sender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sndr")]
    #endif
    [IsoXmlTag("Sndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification40? Sender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification40? Sender { get; init; } 
    #else
    public PartyIdentification40? Sender { get; set; } 
    #endif
    
    
    #nullable disable
    
}
