// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Shipping or Courier Service delivery. 
/// </summary>
[IsoId("_2Q4osZF_EeukDPgU2BMkjQ")]
[DisplayName("Shipping Data")]
public partial record ShippingData2
{
    #nullable enable
    
    /// <summary>
    /// Contains the invoice number.
    /// </summary>
    [IsoId("_2YtH8ZF_EeukDPgU2BMkjQ")]
    [DisplayName("Invoice Number")]
    [IsoXmlTag("InvcNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? InvoiceNumber { get; init; } 
    
    /// <summary>
    /// Contains the date and time the electronic invoice was created.
    /// </summary>
    [IsoId("_2YtH85F_EeukDPgU2BMkjQ")]
    [DisplayName("Invoice Creation Date Time")]
    [IsoXmlTag("InvcCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? InvoiceCreationDateTime { get; init; } 
    
    /// <summary>
    /// Contains a card acceptor designated code for the shipping service provided.
    /// </summary>
    [IsoId("_2YtH9ZF_EeukDPgU2BMkjQ")]
    [DisplayName("Service Descriptor Code")]
    [IsoXmlTag("SvcDscrptrCd")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    public IsoMax40Text? ServiceDescriptorCode { get; init; } 
    
    /// <summary>
    /// Contains the amount of any incentives applied to the transaction. 
    /// </summary>
    [IsoId("_2YtH95F_EeukDPgU2BMkjQ")]
    [DisplayName("Incentive Amount")]
    [IsoXmlTag("IncntivAmt")]
    public ImpliedCurrencyAndAmount? IncentiveAmount { get; init; } 
    
    /// <summary>
    /// Contains the amount of any miscellaneous expenses applicable to the transaction. 
    /// </summary>
    [IsoId("_2YtH-ZF_EeukDPgU2BMkjQ")]
    [DisplayName("Miscellaneous Expenses")]
    [IsoXmlTag("MiscExpnss")]
    public ImpliedCurrencyAndAmount? MiscellaneousExpenses { get; init; } 
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_2YtH-5F_EeukDPgU2BMkjQ")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    
    /// <summary>
    /// Amount of insurance.
    /// </summary>
    [IsoId("_2YtH_ZF_EeukDPgU2BMkjQ")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    
    /// <summary>
    /// Contains the net amount of shipping expenses.
    /// </summary>
    [IsoId("_2YtH_5F_EeukDPgU2BMkjQ")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ImpliedCurrencyAndAmount? NetAmount { get; init; } 
    
    /// <summary>
    /// Contains the total tax amount for the entire purchase. 
    /// </summary>
    [IsoId("_2YtIAZF_EeukDPgU2BMkjQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax39? Tax { get; init; } 
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_2YtIA5F_EeukDPgU2BMkjQ")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    
    /// <summary>
    /// Contains the total number of packages being shipped or sent by the service provider.
    /// </summary>
    [IsoId("_2YtIBZF_EeukDPgU2BMkjQ")]
    [DisplayName("Number Of Packages")]
    [IsoXmlTag("NbOfPackgs")]
    [IsoSimpleType(IsoSimpleType.Max6NumericText)]
    public IsoMax6NumericText? NumberOfPackages { get; init; } 
    
    /// <summary>
    /// Contains the details of the package being shipped. 
    /// </summary>
    [IsoId("_2YtvAZF_EeukDPgU2BMkjQ")]
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public ShippingPackage2? Package { get; init; } 
    
    /// <summary>
    /// Contains additional shipping data.
    /// </summary>
    [IsoId("_2YtvA5F_EeukDPgU2BMkjQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
