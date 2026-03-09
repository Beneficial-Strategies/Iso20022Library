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
/// Provides the details to identify an account.
/// </summary>
[IsoId("_a99FF9cZEeqRFcf2R4bPBw")]
[DisplayName("Cash Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccount41
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_a_Qso9cZEeqRFcf2R4bPBw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? Identification { get; init; } 
    #else
    public AccountIdentification4Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the nature, or use of the account.
    /// </summary>
    [IsoId("_a_QspdcZEeqRFcf2R4bPBw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountType2Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountType2Choice_? Type { get; init; } 
    #else
    public CashAccountType2Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [IsoId("_a_Qsp9cZEeqRFcf2R4bPBw")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.||Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_a_QsqdcZEeqRFcf2R4bPBw")]
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
    /// Specifies an alternate assumed name for the identification of the account. 
    /// </summary>
    [IsoId("_a_Qsq9cZEeqRFcf2R4bPBw")]
    [DisplayName("Proxy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prxy")]
    #endif
    [IsoXmlTag("Prxy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProxyAccountIdentification1? Proxy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProxyAccountIdentification1? Proxy { get; init; } 
    #else
    public ProxyAccountIdentification1? Proxy { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_a_QsrdcZEeqRFcf2R4bPBw")]
    [DisplayName("Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ownr")]
    #endif
    [IsoXmlTag("Ownr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? Owner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? Owner { get; init; } 
    #else
    public PartyIdentification135? Owner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_a_Qsr9cZEeqRFcf2R4bPBw")]
    [DisplayName("Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Svcr")]
    #endif
    [IsoXmlTag("Svcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? Servicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? Servicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? Servicer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
