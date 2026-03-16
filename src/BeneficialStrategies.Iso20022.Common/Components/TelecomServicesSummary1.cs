// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Telecom services summary component carries summary level telephony billing data.
/// </summary>
[IsoId("_3YH6X_e-Eei89sMSHxl1ew")]
[DisplayName("Telecom Services Summary")]
public record TelecomServicesSummary1
{
    /// <summary>
    /// Contains the details of the customer. Also known as the user of the service.
    /// </summary>
    [IsoId("_3YK9qfe-Eei89sMSHxl1ew")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public Customer6? Customer { get; init; }

    /// <summary>
    /// Contains the billing period start date for telecommunication or related services.
    /// </summary>
    [IsoId("_3YIhYve-Eei89sMSHxl1ew")]
    [DisplayName("Billing Statement Period Start")]
    [IsoXmlTag("BllgStmtPrdStart")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BillingStatementPeriodStart { get; init; }

    /// <summary>
    /// Contains the billing period end date for telecommunication or related services.
    /// </summary>
    [IsoId("_tFwnwffAEei89sMSHxl1ew")]
    [DisplayName("Billing Statement Period End")]
    [IsoXmlTag("BllgStmtPrdEnd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BillingStatementPeriodEnd { get; init; }

    /// <summary>
    /// Summary of the charges associated with the billing event.
    /// </summary>
    [IsoId("_3YK9p_e-Eei89sMSHxl1ew")]
    [DisplayName("Billing Event")]
    [IsoXmlTag("BllgEvt")]
    public ValueList<Amount10> BillingEvent { get; init; } = [];

    /// <summary>
    /// Total of taxes applicable to the billing amount.
    /// </summary>
    [IsoId("_sjf9UffCEei89sMSHxl1ew")]
    [DisplayName("Total Tax")]
    [IsoXmlTag("TtlTax")]
    public ValueList<Tax33> TotalTax { get; init; } = [];

    /// <summary>
    /// Additional user-defined data pertaining to the shipment.
    /// </summary>
    [IsoId("_3YK9oPe-Eei89sMSHxl1ew")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
