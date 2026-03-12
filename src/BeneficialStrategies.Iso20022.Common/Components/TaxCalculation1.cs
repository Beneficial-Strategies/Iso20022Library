// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details for the tax calculation.
/// </summary>
[IsoId("_6R49apqlEeGSON8vddiWzQ_163014572")]
[DisplayName("Tax Calculation")]
public partial record TaxCalculation1
{
    #nullable enable
    
    /// <summary>
    /// Currency that all totals for taxable services must be converted to for calculating taxes owed for this tax region. This also is the currency in which the payment of tax obligations is usually submitted to the taxing authority.
    /// </summary>
    [IsoId("_6R49a5qlEeGSON8vddiWzQ_622741619")]
    [DisplayName("Host Currency")]
    [IsoXmlTag("HstCcy")]
    public required ActiveOrHistoricCurrencyCode HostCurrency { get; init; } 
    
    /// <summary>
    /// Taxable service charge amount conversions to host currency. ||Usage: One occurrence must be present for each different service pricing currency in the statement.
    /// </summary>
    [IsoId("_6R49bJqlEeGSON8vddiWzQ_1186516095")]
    [DisplayName("Taxable Service Charge Conversion")]
    [IsoXmlTag("TaxblSvcChrgConvs")]
    public ValueList<BillingServicesAmount3> TaxableServiceChargeConversion { get; init; } = new ValueList<BillingServicesAmount3>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _6R49bJqlEeGSON8vddiWzQ_1186516095
    
    /// <summary>
    /// Total of all services subject to tax for a specific tax region. ||Usage: |This field will equal the sum of all the separate host tax charge for service equivalent totals for each individual currency. It is expressed in the tax region’s Host currency. This total is used to determine the tax due by calculating using each tax identifications rate.
    /// </summary>
    [IsoId("_6SCHUJqlEeGSON8vddiWzQ_-2016390303")]
    [DisplayName("Total Taxable Service Charge Host Amount")]
    [IsoXmlTag("TtlTaxblSvcChrgHstAmt")]
    public required AmountAndDirection34 TotalTaxableServiceChargeHostAmount { get; init; } 
    
    /// <summary>
    /// Provides for the specific tax identification within the same tax region. ||Usage: A maximum of three specific tax identifications may be provided. These elements use the total host currency taxable amount as the basis of the calculation. |This element is only valid for method C.
    /// </summary>
    [IsoId("_6SCHUZqlEeGSON8vddiWzQ_603580500")]
    [DisplayName("Tax Identification")]
    [IsoXmlTag("TaxId")]
    [MinLength(1)]
    [MaxLength(3)]
    public ValueList<BillingServicesTax3> TaxIdentification { get; init; } = new ValueList<BillingServicesTax3>(){};
    
    /// <summary>
    /// Total amount of all taxes for a specific customer within the tax region. This is a sum of all individual total tax amounts for tax identification ’s expressed in the tax region’s host currency.
    /// </summary>
    [IsoId("_6SCHUpqlEeGSON8vddiWzQ_-1201503719")]
    [DisplayName("Total Tax")]
    [IsoXmlTag("TtlTax")]
    public required AmountAndDirection34 TotalTax { get; init; } 
    
    
    #nullable disable
    
}
