// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for fleet transactions.
/// </summary>
[IsoId("_hlHzIUrhEfCMZJtj4J7UGQ")]
[DisplayName("Fleet Line Item7")]
public record FleetLineItem7
{
    /// <summary>
    /// Indicates whether or not the line item represents a fuel or non-fuel product or service.
    /// </summary>
    [IsoId("_hnkDIUrhEfCMZJtj4J7UGQ")]
    [DisplayName("Fuel")]
    [IsoXmlTag("Fuel")]
    public required IsoTrueFalseIndicator Fuel { get; init; }

    /// <summary>
    /// Type of service received at the acceptor location.
    /// </summary>
    [IsoId("_hnkDI0rhEfCMZJtj4J7UGQ")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public FleetServiceType1Code? ServiceType { get; init; }

    /// <summary>
    /// Code that identifies the brand of the fuel purchased.
    /// </summary>
    [IsoId("_hnkDJUrhEfCMZJtj4J7UGQ")]
    [DisplayName("Fuel Brand Code")]
    [IsoXmlTag("FuelBrndCd")]
    public IsoMax4Text? FuelBrandCode { get; init; }

    /// <summary>
    /// Product code of fleet product or service being purchased.
    /// </summary>
    [IsoId("_hnkDJ0rhEfCMZJtj4J7UGQ")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    public IsoMax4Text? ProductCode { get; init; }

    /// <summary>
    /// Contains a code that identifies a category of fleet products or services.
    /// </summary>
    [IsoId("_hnkDKUrhEfCMZJtj4J7UGQ")]
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    public IsoMax35Text? ProductCategory { get; init; }

    /// <summary>
    /// Contains a code that identifies the product qualifier of the fleet product or service.
    /// </summary>
    [IsoId("_hnkDK0rhEfCMZJtj4J7UGQ")]
    [DisplayName("Product Qualifier")]
    [IsoXmlTag("PdctQlfr")]
    public IsoMax6Text? ProductQualifier { get; init; }

    /// <summary>
    /// Contains a code that identifies the product code assigner.
    /// </summary>
    [IsoId("_hnkDLUrhEfCMZJtj4J7UGQ")]
    [DisplayName("Product Code Assigner")]
    [IsoXmlTag("PdctCdAssgnr")]
    public IsoMax35Text? ProductCodeAssigner { get; init; }

    /// <summary>
    /// Indicates whether or not tax is included in unit price.
    /// </summary>
    [IsoId("_hnkDL0rhEfCMZJtj4J7UGQ")]
    [DisplayName("Unit Price Tax")]
    [IsoXmlTag("UnitPricTax")]
    public IsoTrueFalseIndicator? UnitPriceTax { get; init; }

    /// <summary>
    /// Unit price of the fleet line item.
    /// </summary>
    [IsoId("_hnkDMUrhEfCMZJtj4J7UGQ")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; }

    /// <summary>
    /// Unit of measure of the item purchased. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_hnkDM0rhEfCMZJtj4J7UGQ")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure14Code? UnitOfMeasure { get; init; }

    /// <summary>
    /// Contains the discount rate in retail minus discount method.
    /// </summary>
    [IsoId("_nCOD0FBZEfC5WMyGsBx7PA")]
    [DisplayName("Percentage Discount Rate")]
    [IsoXmlTag("PctgDscntRate")]
    public IsoPercentageRate? PercentageDiscountRate { get; init; }

    /// <summary>
    /// Contains unit discount per unit amount in retail minus discount model.
    /// </summary>
    [IsoId("__VXCIFBaEfC5WMyGsBx7PA")]
    [DisplayName("Per Unit Discount Rate")]
    [IsoXmlTag("PerUnitDscntRate")]
    public ImpliedCurrencyAndAmount? PerUnitDiscountRate { get; init; }

    /// <summary>
    /// Contains discount amount per transaction.
    /// </summary>
    [IsoId("_OcYroFBbEfC5WMyGsBx7PA")]
    [DisplayName("Flat Discount Rate")]
    [IsoXmlTag("FlatDscntRate")]
    public ImpliedCurrencyAndAmount? FlatDiscountRate { get; init; }

    /// <summary>
    /// Contains the unit discount per unit amount in cost plus discount method.
    /// </summary>
    [IsoId("_2XVekFBXEfC5WMyGsBx7PA")]
    [DisplayName("Cost Plus Unit Discount")]
    [IsoXmlTag("CostPlusUnitDscnt")]
    public ImpliedCurrencyAndAmount? CostPlusUnitDiscount { get; init; }

    /// <summary>
    /// Contain the sign of cost plus unit discount.
    /// </summary>
    [IsoId("_d1bZkFBYEfC5WMyGsBx7PA")]
    [DisplayName("Cost Plus Unit Discount Sign")]
    [IsoXmlTag("CostPlusUnitDscntSgn")]
    public CreditDebit3Code? CostPlusUnitDiscountSign { get; init; }

    /// <summary>
    /// Contains unit price in cost plus discount method.
    /// </summary>
    [IsoId("_nIA_QFBYEfC5WMyGsBx7PA")]
    [DisplayName("Cost Plus Unit Price")]
    [IsoXmlTag("CostPlusUnitPric")]
    public required ImpliedCurrencyAndAmount CostPlusUnitPrice { get; init; }

    /// <summary>
    /// Contains the total time the vehicle was plugged in.
    /// </summary>
    [IsoId("_QL4Z8EriEfCMZJtj4J7UGQ")]
    [DisplayName("Total Time Plugged In")]
    [IsoXmlTag("TtlTmPlugdIn")]
    public IsoISOTime? TotalTimePluggedIn { get; init; }

    /// <summary>
    /// Contain the actual total time taken to charge the vehicle.
    /// </summary>
    [IsoId("_hTgCMEriEfCMZJtj4J7UGQ")]
    [DisplayName("Total Time Charging")]
    [IsoXmlTag("TtlTmChrgg")]
    public IsoISOTime? TotalTimeCharging { get; init; }

    /// <summary>
    /// Contains the start time of the charge.
    /// </summary>
    [IsoId("_4j3xYEriEfCMZJtj4J7UGQ")]
    [DisplayName("Charging Start Time")]
    [IsoXmlTag("ChrggStartTm")]
    public IsoISOTime? ChargingStartTime { get; init; }

    /// <summary>
    /// Contains the completion time of the charge.
    /// </summary>
    [IsoId("_M_gvIErjEfCMZJtj4J7UGQ")]
    [DisplayName("Charging Completion Time")]
    [IsoXmlTag("ChrggCmpltnTm")]
    public IsoISOTime? ChargingCompletionTime { get; init; }

    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [IsoId("_hnkDN0rhEfCMZJtj4J7UGQ")]
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    public IsoDecimalNumber? ProductQuantity { get; init; }

    /// <summary>
    /// Contains the discount amount applied to the fleet transaction (includes coupons).
    /// </summary>
    [IsoId("_hnkDOUrhEfCMZJtj4J7UGQ")]
    [DisplayName("Discount Amount")]
    [IsoXmlTag("DscntAmt")]
    public ImpliedCurrencyAndAmount? DiscountAmount { get; init; }

    /// <summary>
    /// Indicates whether or not amount of fleet purchase is taxable.
    /// </summary>
    [IsoId("_hnkDO0rhEfCMZJtj4J7UGQ")]
    [DisplayName("Non Taxable")]
    [IsoXmlTag("NonTaxbl")]
    public IsoTrueFalseIndicator? NonTaxable { get; init; }

    /// <summary>
    /// Taxes related to the products or services.
    /// </summary>
    [IsoId("_hnkDPUrhEfCMZJtj4J7UGQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    /// <summary>
    /// Total amount excluding tax.
    /// </summary>
    [IsoId("_hnkDP0rhEfCMZJtj4J7UGQ")]
    [DisplayName("Total Amount Excluding Tax")]
    [IsoXmlTag("TtlAmtExclgTax")]
    public ImpliedCurrencyAndAmount? TotalAmountExcludingTax { get; init; }

    /// <summary>
    /// Total amount including tax.
    /// </summary>
    [IsoId("_hnkDQUrhEfCMZJtj4J7UGQ")]
    [DisplayName("Total Amount Including Tax")]
    [IsoXmlTag("TtlAmtInclgTax")]
    public ImpliedCurrencyAndAmount? TotalAmountIncludingTax { get; init; }

    /// <summary>
    /// Contains net line item, less any taxes exempted or discounts.
    /// </summary>
    [IsoId("_Vz4acFBXEfC5WMyGsBx7PA")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ImpliedCurrencyAndAmount? NetAmount { get; init; }
}
