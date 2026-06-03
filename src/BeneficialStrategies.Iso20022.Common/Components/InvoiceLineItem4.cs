// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Item purchased with the transaction.
/// </summary>
[IsoId("_sPe2UUhrEfCMZJtj4J7UGQ")]
[DisplayName("Invoice Line Item4")]
public record InvoiceLineItem4
{
    /// <summary>
    /// Invoice date.
    /// </summary>
    [IsoId("_sSJIwUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Invoice order date.
    /// </summary>
    [IsoId("_sSJIw0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Order Date")]
    [IsoXmlTag("OrdrDt")]
    public IsoISODate? OrderDate { get; init; }

    /// <summary>
    /// Contains the corporate contract number.
    /// </summary>
    [IsoId("_sSJIxUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Contract Number")]
    [IsoXmlTag("CtrctNb")]
    public IsoMax70Text? ContractNumber { get; init; }

    /// <summary>
    /// Shipping date of the product or the date services rendered.
    /// </summary>
    [IsoId("_sSJIx0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Shipping Date")]
    [IsoXmlTag("ShppgDt")]
    public IsoISODate? ShippingDate { get; init; }

    /// <summary>
    /// Rebilling indicator.
    /// </summary>
    [IsoId("_sSJIyUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Rebilling")]
    [IsoXmlTag("Rbllg")]
    public IsoTrueFalseIndicator? Rebilling { get; init; }

    /// <summary>
    /// Indicates whether or not the invoice line item represents a medical service.
    /// </summary>
    [IsoId("_sSJIy0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Medical Services")]
    [IsoXmlTag("MdclSvcs")]
    public IsoTrueFalseIndicator? MedicalServices { get; init; }

    /// <summary>
    /// Contains the health industry number to which the medical services are being shipped.
    /// </summary>
    [IsoId("_sSJIzUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Ship To Industry Code")]
    [IsoXmlTag("ShipToIndstryCd")]
    public IsoMax50Text? ShipToIndustryCode { get; init; }

    /// <summary>
    /// Product code of the item.
    /// </summary>
    [IsoId("_sSJIz0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    public IsoMax70Text? ProductCode { get; init; }

    /// <summary>
    /// Contains a code that identifies the product number qualifier of the product.
    /// </summary>
    [IsoId("_sSJI0UhrEfCMZJtj4J7UGQ")]
    [DisplayName("Product Qualifier")]
    [IsoXmlTag("PdctQlfr")]
    public IsoMax35Text? ProductQualifier { get; init; }

    /// <summary>
    /// May contain further clarifying data, such as event name, etc.
    /// </summary>
    [IsoId("_sSJI00hrEfCMZJtj4J7UGQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax256Text? Description { get; init; }

    /// <summary>
    /// Indicates whether the purchase is categorized as goods or services.
    /// </summary>
    [IsoId("_sSJI1UhrEfCMZJtj4J7UGQ")]
    [DisplayName("Type Of Supply")]
    [IsoXmlTag("TpOfSpply")]
    public IsoMax10Text? TypeOfSupply { get; init; }

    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_sSJI10hrEfCMZJtj4J7UGQ")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; }

    /// <summary>
    /// Other unit of measure.
    /// </summary>
    [IsoId("_sSJI2UhrEfCMZJtj4J7UGQ")]
    [DisplayName("Other Unit Of Measure")]
    [IsoXmlTag("OthrUnitOfMeasr")]
    public IsoMax35Text? OtherUnitOfMeasure { get; init; }

    /// <summary>
    /// Contains the price for one unit of the product or service.
    /// </summary>
    [IsoId("_sSJI20hrEfCMZJtj4J7UGQ")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; }

    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [IsoId("_sSJI3UhrEfCMZJtj4J7UGQ")]
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    public IsoDecimalNumber? ProductQuantity { get; init; }

    /// <summary>
    /// Contains the adjusted amount (for example, discounts).
    /// </summary>
    [IsoId("_sSJI30hrEfCMZJtj4J7UGQ")]
    [DisplayName("Adjustment Amount")]
    [IsoXmlTag("AdjstmntAmt")]
    public ImpliedCurrencyAndAmount? AdjustmentAmount { get; init; }

    /// <summary>
    /// A code to indicate the adjustment amount is credit or debit.
    /// </summary>
    [IsoId("_sSJI4UhrEfCMZJtj4J7UGQ")]
    [DisplayName("Adjustment Credit Debit")]
    [IsoXmlTag("AdjstmntCdtDbt")]
    public CreditDebit3Code? AdjustmentCreditDebit { get; init; }

    /// <summary>
    /// Reason for the adjustment.
    /// </summary>
    [IsoId("_sSJI40hrEfCMZJtj4J7UGQ")]
    [DisplayName("Adjustment Reason")]
    [IsoXmlTag("AdjstmntRsn")]
    public IsoMax35Text? AdjustmentReason { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_sSJI5UhrEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    /// <summary>
    /// Cost of the insurance purchased.
    /// </summary>
    [IsoId("_sSJI50hrEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }

    /// <summary>
    /// Taxes related to the products or services.
    /// </summary>
    [IsoId("_sSJI6UhrEfCMZJtj4J7UGQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    /// <summary>
    /// Identifies the value-added tax (VAT) invoice or tax receipt.
    /// </summary>
    [IsoId("_sSJI60hrEfCMZJtj4J7UGQ")]
    [DisplayName("VAT Invoice Reference")]
    [IsoXmlTag("VATInvcRef")]
    public IsoMax35Text? VATInvoiceReference { get; init; }

    /// <summary>
    /// Total amount of line item, inclusive of any applicable adjustments and taxes.
    /// </summary>
    [IsoId("_sSJI7UhrEfCMZJtj4J7UGQ")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// A code to indicate the tax amount is credit or debit.
    /// </summary>
    [IsoId("_sSJI70hrEfCMZJtj4J7UGQ")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Indicates whether or not the line item carries a cost.
    /// </summary>
    [IsoId("_sSJI8UhrEfCMZJtj4J7UGQ")]
    [DisplayName("Zero Cost To Customer")]
    [IsoXmlTag("ZeroCostToCstmr")]
    public IsoTrueFalseIndicator? ZeroCostToCustomer { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_luufEkhrEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_luufE0hrEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
