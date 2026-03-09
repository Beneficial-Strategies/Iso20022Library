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
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
[IsoId("_EAoRMZEFEem7fvtoGpNpow")]
[DisplayName("Investment Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccount71
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentAccount71 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentAccount71( System.String reqAccountIdentification )
    {
        AccountIdentification = reqAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_EUtq05EFEem7fvtoGpNpow")]
    [DisplayName("Owner Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrId")]
    #endif
    [IsoXmlTag("OwnrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification139? OwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification139? OwnerIdentification { get; init; } 
    #else
    public PartyIdentification139? OwnerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_EUtq1ZEFEem7fvtoGpNpow")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AccountIdentification { get; init; } 
    #else
    public System.String AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_EUtq15EFEem7fvtoGpNpow")]
    [DisplayName("Account Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctNm")]
    #endif
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountName { get; init; } 
    #else
    public System.String? AccountName { get; set; } 
    #endif
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to be reconciled individually.
    /// </summary>
    [IsoId("_EUtq2ZEFEem7fvtoGpNpow")]
    [DisplayName("Account Designation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDsgnt")]
    #endif
    [IsoXmlTag("AcctDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountDesignation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountDesignation { get; init; } 
    #else
    public System.String? AccountDesignation { get; set; } 
    #endif
    
    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("_EUtq55EFEem7fvtoGpNpow")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification139? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification139? AccountServicer { get; init; } 
    #else
    public PartyIdentification139? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    [IsoId("_EUtq6ZEFEem7fvtoGpNpow")]
    [DisplayName("Sub Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctDtls")]
    #endif
    [IsoXmlTag("SubAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubAccount5? SubAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubAccount5? SubAccountDetails { get; init; } 
    #else
    public SubAccount5? SubAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_EUtq25EFEem7fvtoGpNpow")]
    [DisplayName("Intermediary Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyInf")]
    #endif
    [IsoXmlTag("IntrmyInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Intermediary43? IntermediaryInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Intermediary43? IntermediaryInformation { get; init; } 
    #else
    public Intermediary43? IntermediaryInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Form, that is, ownership, of the security, that is, registered or bearer.
    /// </summary>
    [IsoId("_vvhqobHhEem4X-SfagDa8w")]
    [DisplayName("Securities Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesForm")]
    #endif
    [IsoXmlTag("SctiesForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    #else
    public FormOfSecurity1Code? SecuritiesForm { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a security exists only as an electronic record, that is, there is no physical document representing the security.
    /// </summary>
    [IsoId("_2isAgbHhEem4X-SfagDa8w")]
    [DisplayName("Dematerialised Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmtrlsdInd")]
    #endif
    [IsoXmlTag("DmtrlsdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DematerialisedIndicator { get; init; } 
    #else
    public System.String? DematerialisedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_EUtq4ZEFEem7fvtoGpNpow")]
    [DisplayName("Income Preference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmPref")]
    #endif
    [IsoXmlTag("IncmPref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncomePreference2Code? IncomePreference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncomePreference2Code? IncomePreference { get; init; } 
    #else
    public IncomePreference2Code? IncomePreference { get; set; } 
    #endif
    
    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    [IsoId("_EUtq45EFEem7fvtoGpNpow")]
    [DisplayName("Beneficiary Certification Completion")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryCertfctnCmpltn")]
    #endif
    [IsoXmlTag("BnfcryCertfctnCmpltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; } 
    #else
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; set; } 
    #endif
    
    /// <summary>
    /// Place requested as the place of safekeeping.
    /// </summary>
    [IsoId("_EUtq5ZEFEem7fvtoGpNpow")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of parties involved in the settlement of the transaction.
    /// </summary>
    [IsoId("_EUtq65EFEem7fvtoGpNpow")]
    [DisplayName("Settlement Parties Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPtiesDtls")]
    #endif
    [IsoXmlTag("SttlmPtiesDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundSettlementParameters16? SettlementPartiesDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundSettlementParameters16? SettlementPartiesDetails { get; init; } 
    #else
    public FundSettlementParameters16? SettlementPartiesDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
