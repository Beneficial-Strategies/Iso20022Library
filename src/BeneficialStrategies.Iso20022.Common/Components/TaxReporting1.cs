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
/// Information for tax reporting.
/// </summary>
[IsoId("_jTmkYCCREeWJd9HF2tO7BA")]
[DisplayName("Tax Reporting")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxReporting1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxReporting1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxReporting1( string reqTaxationCountry )
    {
        TaxationCountry = reqTaxationCountry;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Country of taxation of the organisation or individual person.
    /// </summary>
    [IsoId("_xEux8SCREeWJd9HF2tO7BA")]
    [DisplayName("Taxation Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxtnCtry")]
    #endif
    [IsoXmlTag("TaxtnCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode TaxationCountry { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string TaxationCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string TaxationCountry { get; init; } 
    #else
    public string TaxationCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Tax rate to be applied.
    /// </summary>
    [IsoId("_rk2_gFxTEeWD__CZJAtsow")]
    [DisplayName("Tax Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRate")]
    #endif
    [IsoXmlTag("TaxRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxRate { get; init; } 
    #else
    public System.Decimal? TaxRate { get; set; } 
    #endif
    
    /// <summary>
    /// Party that pays the tax.
    /// </summary>
    [IsoId("_7yU9ECCREeWJd9HF2tO7BA")]
    [DisplayName("Tax Payer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxPyer")]
    #endif
    [IsoXmlTag("TaxPyer")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification70Choice_? TaxPayer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification70Choice_? TaxPayer { get; init; } 
    #else
    public PartyIdentification70Choice_? TaxPayer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives the tax.
    /// </summary>
    [IsoId("_AdFcACCSEeWJd9HF2tO7BA")]
    [DisplayName("Tax Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRcpt")]
    #endif
    [IsoXmlTag("TaxRcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification70Choice_? TaxRecipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification70Choice_? TaxRecipient { get; init; } 
    #else
    public PartyIdentification70Choice_? TaxRecipient { get; set; } 
    #endif
    
    /// <summary>
    /// Cash account information for the payment of tax.
    /// </summary>
    [IsoId("_EKjMQCCSEeWJd9HF2tO7BA")]
    [DisplayName("Cash Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctDtls")]
    #endif
    [IsoXmlTag("CshAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount32? CashAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount32? CashAccountDetails { get; init; } 
    #else
    public CashAccount32? CashAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information for the reporting of tax.
    /// </summary>
    [IsoId("_Nw2XUCDCEeWPMvNwVtiMsA")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
