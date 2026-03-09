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
/// Tax region that levies a tax on the services in a statement.
/// </summary>
[IsoId("_6Th8IpqlEeGSON8vddiWzQ_1934585019")]
[DisplayName("Billing Tax Region")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingTaxRegion1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingTaxRegion1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingTaxRegion1( System.String reqRegionNumber,System.String reqRegionName,System.String reqCustomerTaxIdentification,AmountAndDirection34 reqSettlementAmount,AmountAndDirection34 reqTaxDueToRegion )
    {
        RegionNumber = reqRegionNumber;
        RegionName = reqRegionName;
        CustomerTaxIdentification = reqCustomerTaxIdentification;
        SettlementAmount = reqSettlementAmount;
        TaxDueToRegion = reqTaxDueToRegion;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies a particular unique zone of taxes assigned by taxing authorities. A tax region number is unique. Every account is considered to reside within a tax region, although some tax regions may not charge taxes on services.
    /// </summary>
    [IsoId("_6Th8I5qlEeGSON8vddiWzQ_1296791674")]
    [DisplayName("Region Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgnNb")]
    #endif
    [IsoXmlTag("RgnNb")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax40Text RegionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RegionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RegionNumber { get; init; } 
    #else
    public System.String RegionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Name associated with a specific tax region number.
    /// </summary>
    [IsoId("_6Th8JJqlEeGSON8vddiWzQ_-485782008")]
    [DisplayName("Region Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgnNm")]
    #endif
    [IsoXmlTag("RgnNm")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax40Text RegionName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RegionName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RegionName { get; init; } 
    #else
    public System.String RegionName { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the financial institution’s customer tax identification number. ||Usage: |This is the number passed from the financial institution to the taxing authority to indicate the specific customer tied to the taxes calculated for this tax region and group of delivered services. It is typically the tax identification tied to a customer’s account.
    /// </summary>
    [IsoId("_6Th8JZqlEeGSON8vddiWzQ_-1539060367")]
    [DisplayName("Customer Tax Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrTaxId")]
    #endif
    [IsoXmlTag("CstmrTaxId")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax40Text CustomerTaxIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CustomerTaxIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CustomerTaxIdentification { get; init; } 
    #else
    public System.String CustomerTaxIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the tax calculation was performed. ||Usage: |This date can be used to verify the tax rate value on the calculation date.
    /// </summary>
    [IsoId("_6Th8JpqlEeGSON8vddiWzQ_-1887349622")]
    [DisplayName("Point Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtDt")]
    #endif
    [IsoXmlTag("PtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? PointDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? PointDate { get; init; } 
    #else
    public System.DateOnly? PointDate { get; set; } 
    #endif
    
    /// <summary>
    /// Tax information that relates to the sending financial institution.
    /// </summary>
    [IsoId("_6Th8J5qlEeGSON8vddiWzQ_317807571")]
    [DisplayName("Sending Financial Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndgFI")]
    #endif
    [IsoXmlTag("SndgFI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingTaxIdentification1? SendingFinancialInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingTaxIdentification1? SendingFinancialInstitution { get; init; } 
    #else
    public BillingTaxIdentification1? SendingFinancialInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number to be used by the customer to cross-reference between the tax region information and a tax invoice or notice.
    /// </summary>
    [IsoId("_6Th8KJqlEeGSON8vddiWzQ_-1496589094")]
    [DisplayName("Invoice Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcNb")]
    #endif
    [IsoXmlTag("InvcNb")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax40Text? InvoiceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InvoiceNumber { get; init; } 
    #else
    public System.String? InvoiceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Tax values are based on tax calculation method C.
    /// </summary>
    [IsoId("_6TrGEJqlEeGSON8vddiWzQ_320703223")]
    [DisplayName("Method C")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtdC")]
    #endif
    [IsoXmlTag("MtdC")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingMethod4? MethodC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingMethod4? MethodC { get; init; } 
    #else
    public BillingMethod4? MethodC { get; set; } 
    #endif
    
    /// <summary>
    /// Total tax amount expressed in the account’s settlement (or charging) currency. ||Usage: This total sums the individual service level taxes as calculated for each service by methods A, B and D. The sum of these amounts across all tax regions for the statement is displayed as the tax total sum in the compensation section.
    /// </summary>
    [IsoId("_6TrGEZqlEeGSON8vddiWzQ_1481996990")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection34 SettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection34 SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34 SettlementAmount { get; init; } 
    #else
    public AmountAndDirection34 SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of all taxes for a specific customer within the tax region expressed in the tax region’s host currency. ||Usage: It is the same value as total tax amount and is included for the specific use of tax calculation methods A, B and D.
    /// </summary>
    [IsoId("_6TrGEpqlEeGSON8vddiWzQ_1246849716")]
    [DisplayName("Tax Due To Region")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDueToRgn")]
    #endif
    [IsoXmlTag("TaxDueToRgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection34 TaxDueToRegion { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection34 TaxDueToRegion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34 TaxDueToRegion { get; init; } 
    #else
    public AmountAndDirection34 TaxDueToRegion { get; set; } 
    #endif
    
    
    #nullable disable
    
}
