// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about the investment fund class.
/// </summary>
[IsoId("_m-vKpvNBEeCuA5Tr22BnwA_337995700")]
[DisplayName("Investment Fund")]
public partial record InvestmentFund1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the investment fund or investment fund class.
    /// </summary>
    [IsoId("_m-vKp_NBEeCuA5Tr22BnwA_-1318599223")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_m-vKqPNBEeCuA5Tr22BnwA_693141038")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; } 
    
    /// <summary>
    /// Number of shares outstanding for the investment fund or investment fund share class.
    /// </summary>
    [IsoId("_m-vKqfNBEeCuA5Tr22BnwA_-744176110")]
    [DisplayName("Total Units Outstanding")]
    [IsoXmlTag("TtlUnitsOutsdng")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TotalUnitsOutstanding { get; init; } 
    
    /// <summary>
    /// Total transactional units (subscriptions and redemptions) which are applied to the investment fund or investment fund share class for the report period.
    /// </summary>
    [IsoId("_m-47oPNBEeCuA5Tr22BnwA_1556646480")]
    [DisplayName("Transactional Units")]
    [IsoXmlTag("TxnlUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? TransactionalUnits { get; init; } 
    
    /// <summary>
    /// Total value of the investment fund or investment fund share class units.
    /// </summary>
    [IsoId("_m-47ofNBEeCuA5Tr22BnwA_-2045687")]
    [DisplayName("Total Value")]
    [IsoXmlTag("TtlVal")]
    public AmountAndDirection30? TotalValue { get; init; } 
    
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_m-47ovNBEeCuA5Tr22BnwA_-574968216")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public PriceInformation10? Price { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_m-47o_NBEeCuA5Tr22BnwA_-14332001")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
