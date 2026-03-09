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
/// Investment fund transactions for a specific financial instrument.
/// </summary>
[IsoId("_VGq85Np-Ed-ak6NoX_4Aeg_1018199129")]
[DisplayName("Investment Fund Transactions By Fund")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentFundTransactionsByFund1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentFundTransactionsByFund1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentFundTransactionsByFund1( SecurityIdentification1Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_VGq85dp-Ed-ak6NoX_4Aeg_-117997473")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification1Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification1Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification1Choice_ Identification { get; init; } 
    #else
    public SecurityIdentification1Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_VGq85tp-Ed-ak6NoX_4Aeg_-117997413")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_VGq859p-Ed-ak6NoX_4Aeg_-117997361")]
    [DisplayName("Supplementary Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryId")]
    #endif
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SupplementaryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SupplementaryIdentification { get; init; } 
    #else
    public System.String? SupplementaryIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the form, ie, ownership, of the security.
    /// </summary>
    [IsoId("_VGq86Np-Ed-ak6NoX_4Aeg_-117997070")]
    [DisplayName("Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Form")]
    #endif
    [IsoXmlTag("Form")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FormOfSecurity1Code? Form { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FormOfSecurity1Code? Form { get; init; } 
    #else
    public FormOfSecurity1Code? Form { get; set; } 
    #endif
    
    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, eg, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_VGq86dp-Ed-ak6NoX_4Aeg_-117996940")]
    [DisplayName("Class Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssTp")]
    #endif
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClassType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassType { get; init; } 
    #else
    public System.String? ClassType { get; set; } 
    #endif
    
    /// <summary>
    /// Income policy relating to a class type, ie, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_VGq86tp-Ed-ak6NoX_4Aeg_-117996855")]
    [DisplayName("Distribution Policy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstrbtnPlcy")]
    #endif
    [IsoXmlTag("DstrbtnPlcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    #else
    public DistributionPolicy1Code? DistributionPolicy { get; set; } 
    #endif
    
    /// <summary>
    /// Process of buying, selling, switching or transferring fund units.
    /// </summary>
    [IsoId("_VG0G0Np-Ed-ak6NoX_4Aeg_-3482322")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    public ValueList<InvestmentFundTransaction2> TransactionDetails { get; init; } = new ValueList<InvestmentFundTransaction2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _VG0G0Np-Ed-ak6NoX_4Aeg_-3482322
    
    /// <summary>
    /// Balance of the financial instrument for this specific statement page.
    /// </summary>
    [IsoId("_VG0G0dp-Ed-ak6NoX_4Aeg_456431676")]
    [DisplayName("Balance By Page")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalByPg")]
    #endif
    [IsoXmlTag("BalByPg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaginationBalance1? BalanceByPage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaginationBalance1? BalanceByPage { get; init; } 
    #else
    public PaginationBalance1? BalanceByPage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
