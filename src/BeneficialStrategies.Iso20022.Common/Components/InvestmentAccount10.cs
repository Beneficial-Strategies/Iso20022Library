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
[IsoId("_U8-1ZNp-Ed-ak6NoX_4Aeg_1336807406")]
[DisplayName("Investment Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccount10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentAccount10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentAccount10( AccountIdentification1 reqAccountIdentification )
    {
        AccountIdentification = reqAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_U8-1Zdp-Ed-ak6NoX_4Aeg_433269377")]
    [DisplayName("Owner Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrId")]
    #endif
    [IsoXmlTag("OwnrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification1Choice_? OwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification1Choice_? OwnerIdentification { get; init; } 
    #else
    public PartyIdentification1Choice_? OwnerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_U8-1Ztp-Ed-ak6NoX_4Aeg_433268902")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification1 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification1 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification1 AccountIdentification { get; init; } 
    #else
    public AccountIdentification1 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_U8-1Z9p-Ed-ak6NoX_4Aeg_432348480")]
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
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_U8-1aNp-Ed-ak6NoX_4Aeg_432348836")]
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
    /// Party that provides services relating to financial products to investors, eg, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_U9ImYNp-Ed-ak6NoX_4Aeg_433269040")]
    [DisplayName("Intermediary Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyInf")]
    #endif
    [IsoXmlTag("IntrmyInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Intermediary1? IntermediaryInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Intermediary1? IntermediaryInformation { get; init; } 
    #else
    public Intermediary1? IntermediaryInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Form, ie, ownership, of the security, eg, registered or bearer.
    /// </summary>
    [IsoId("_U9ImYdp-Ed-ak6NoX_4Aeg_433270359")]
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
    /// Indicates whether a security exists only as an electronic record, ie, there is no physical document representing the security.
    /// </summary>
    [IsoId("_U9ImYtp-Ed-ak6NoX_4Aeg_238056455")]
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
    [IsoId("_U9ImY9p-Ed-ak6NoX_4Aeg_1777316854")]
    [DisplayName("Income Preference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmPref")]
    #endif
    [IsoXmlTag("IncmPref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncomePreference1Code? IncomePreference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncomePreference1Code? IncomePreference { get; init; } 
    #else
    public IncomePreference1Code? IncomePreference { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the beneficial ownership certification has been sent, certifying that the beneficial owner is eligible to own a specific investment fund or investment fund class.
    /// </summary>
    [IsoId("_U9ImZNp-Ed-ak6NoX_4Aeg_-471390939")]
    [DisplayName("Beneficiary Certification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryCertfctnInd")]
    #endif
    [IsoXmlTag("BnfcryCertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BeneficiaryCertificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BeneficiaryCertificationIndicator { get; init; } 
    #else
    public System.String? BeneficiaryCertificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Place requested as the place of safekeeping.
    /// </summary>
    [IsoId("_U9ImZdp-Ed-ak6NoX_4Aeg_-809158432")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification1Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification1Choice_? SafekeepingPlace { get; init; } 
    #else
    public PartyIdentification1Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Party related to an account that is not the legal account owner, eg, the power of attorney.
    /// </summary>
    [IsoId("_U9ImZtp-Ed-ak6NoX_4Aeg_621294269")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification1Choice_? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification1Choice_? AccountServicer { get; init; } 
    #else
    public PartyIdentification1Choice_? AccountServicer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
