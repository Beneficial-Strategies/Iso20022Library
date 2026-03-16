// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Shipping Data3.
/// </summary>
[IsoId("_O2HLQXTtEe6h-4AZRg9sVg")]
[DisplayName("Shipping Data3")]
public partial record ShippingData3
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Incentive Amount.
    /// </summary>
    [DisplayName("Incentive Amount")]
    [IsoXmlTag("IncntivAmt")]
    public ImpliedCurrencyAndAmount? IncentiveAmount { get; init; } 

    /// <summary>
    /// Insurance.
    /// </summary>
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; } 

    /// <summary>
    /// Insurance Amount.
    /// </summary>
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 

    /// <summary>
    /// Invoice Creation Date Time.
    /// </summary>
    [DisplayName("Invoice Creation Date Time")]
    [IsoXmlTag("InvcCreDtTm")]
    public IsoISODateTime? InvoiceCreationDateTime { get; init; } 

    /// <summary>
    /// Invoice Number.
    /// </summary>
    [DisplayName("Invoice Number")]
    [IsoXmlTag("InvcNb")]
    public IsoMax70Text? InvoiceNumber { get; init; } 

    /// <summary>
    /// Miscellaneous Expenses.
    /// </summary>
    [DisplayName("Miscellaneous Expenses")]
    [IsoXmlTag("MiscExpnss")]
    public ImpliedCurrencyAndAmount? MiscellaneousExpenses { get; init; } 

    /// <summary>
    /// Net Amount.
    /// </summary>
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ImpliedCurrencyAndAmount? NetAmount { get; init; } 

    /// <summary>
    /// Number Of Packages.
    /// </summary>
    [DisplayName("Number Of Packages")]
    [IsoXmlTag("NbOfPackgs")]
    public IsoMax6NumericText? NumberOfPackages { get; init; } 

    /// <summary>
    /// Package.
    /// </summary>
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public ValueList<ShippingPackage3> Package { get; init; } = [];

    /// <summary>
    /// Service Descriptor Code.
    /// </summary>
    [DisplayName("Service Descriptor Code")]
    [IsoXmlTag("SvcDscrptrCd")]
    public IsoMax40Text? ServiceDescriptorCode { get; init; } 

    /// <summary>
    /// Summary Commodity Identification.
    /// </summary>
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 

    /// <summary>
    /// Tax.
    /// </summary>
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax41> Tax { get; init; } = [];

    
    #nullable disable
    
}
