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
/// Identification information expressed as a country of fiscal domicile and a reference.
/// </summary>
[IsoId("_WUMt-u0REeWLj6RCdgRMog")]
[DisplayName("Market Claim Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarketClaimDetailsSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarketClaimDetailsSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarketClaimDetailsSD1( string reqFiscalDomicile )
    {
        FiscalDomicile = reqFiscalDomicile;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Country in which the account owner has one&apos;s fiscal domicile.
    /// </summary>
    [IsoId("_WUMt_-0REeWLj6RCdgRMog")]
    [DisplayName("Fiscal Domicile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FsclDmcl")]
    #endif
    [IsoXmlTag("FsclDmcl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode FiscalDomicile { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string FiscalDomicile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string FiscalDomicile { get; init; } 
    #else
    public string FiscalDomicile { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the document assigned by the account servicer.
    /// </summary>
    [IsoId("_WUMuAO0REeWLj6RCdgRMog")]
    [DisplayName("Account Servicer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrId")]
    #endif
    [IsoXmlTag("AcctSvcrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountServicerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountServicerIdentification { get; init; } 
    #else
    public System.String? AccountServicerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the document assigned by the account owner.
    /// </summary>
    [IsoId("_WUMt--0REeWLj6RCdgRMog")]
    [DisplayName("Account Owner Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrId")]
    #endif
    [IsoXmlTag("AcctOwnrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountOwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountOwnerIdentification { get; init; } 
    #else
    public System.String? AccountOwnerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_L6c2cO0SEeWLj6RCdgRMog")]
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
    /// Quantity of securities that do not impact the taxable record date entitlement.
    /// </summary>
    [IsoId("_Z3vbQO0TEeWLj6RCdgRMog")]
    [DisplayName("Cash Compensation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCompstn")]
    #endif
    [IsoXmlTag("CshCompstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? CashCompensation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? CashCompensation { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? CashCompensation { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities that impact the taxable record date entitlement.
    /// </summary>
    [IsoId("_7GFPcO0TEeWLj6RCdgRMog")]
    [DisplayName("Dividend Correction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddCrrctn")]
    #endif
    [IsoXmlTag("DvddCrrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? DividendCorrection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? DividendCorrection { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? DividendCorrection { get; set; } 
    #endif
    
    
    #nullable disable
    
}
