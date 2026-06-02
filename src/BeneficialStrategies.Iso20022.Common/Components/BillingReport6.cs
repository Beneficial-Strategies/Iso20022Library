// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report on specific billing data.
/// </summary>
[IsoId("_2jks1zEyEe6g-ffJsqGiSA")]
[DisplayName("Billing Report6")]
public record BillingReport6
{
    /// <summary>
    /// Information about legal and regulatory data exchanged between invoicing and paying party.
    /// </summary>
    [IsoId("_2mCyATEyEe6g-ffJsqGiSA")]
    [DisplayName("Regulatory Data")]
    [IsoXmlTag("RgltryData")]
    public required InvoiceLegalIssue5 RegulatoryData { get; init; }

    /// <summary>
    /// Identification of the service or system for which the billing information is provided.
    /// </summary>
    [IsoId("_2mCyAzEyEe6g-ffJsqGiSA")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public SystemAndCurrency1? Service { get; init; }

    /// <summary>
    /// Date at which the billing report was created.
    /// </summary>
    [IsoId("_2mCyBTEyEe6g-ffJsqGiSA")]
    [DisplayName("Invoice Date")]
    [IsoXmlTag("InvcDt")]
    public required IsoISODate InvoiceDate { get; init; }

    /// <summary>
    /// Unique identification of the billing report.
    /// </summary>
    [IsoId("_2mCyBzEyEe6g-ffJsqGiSA")]
    [DisplayName("Billing Identification")]
    [IsoXmlTag("BllgId")]
    public required IsoMax35Text BillingIdentification { get; init; }

    /// <summary>
    /// Date period for which the report data is valid.
    /// </summary>
    [IsoId("_2mCyCTEyEe6g-ffJsqGiSA")]
    [DisplayName("Billing Period")]
    [IsoXmlTag("BllgPrd")]
    public required DatePeriod2 BillingPeriod { get; init; }

    /// <summary>
    /// Unique identification of the party responsible for the referenced party.
    /// </summary>
    [IsoId("_2mCyCzEyEe6g-ffJsqGiSA")]
    [DisplayName("Responsible Party Identification")]
    [IsoXmlTag("RspnsblPtyId")]
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; }

    /// <summary>
    /// Unique identification to unambiguously identify the billed party.
    /// </summary>
    [IsoId("_2mCyDTEyEe6g-ffJsqGiSA")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public PartyIdentification136? PartyIdentification { get; init; }

    /// <summary>
    /// Specifies totals related to the invoice per account.
    /// </summary>
    [IsoId("_2mCyDzEyEe6g-ffJsqGiSA")]
    [DisplayName("Account Invoice Totals")]
    [IsoXmlTag("AcctInvcTtls")]
    public ValueList<InvoiceTotals8> AccountInvoiceTotals { get; init; } = [];

    /// <summary>
    /// Specifies totals related to the invoice.
    /// </summary>
    [IsoId("_2mCyETEyEe6g-ffJsqGiSA")]
    [DisplayName("Invoice Totals")]
    [IsoXmlTag("InvcTtls")]
    public InvoiceTotals7? InvoiceTotals { get; init; }

    /// <summary>
    /// Specifies totals related to the service category.
    /// </summary>
    [IsoId("_2mCyEzEyEe6g-ffJsqGiSA")]
    [DisplayName("Service Category Totals")]
    [IsoXmlTag("SvcCtgyTtls")]
    public ValueList<ServiceCategoryTotals8> ServiceCategoryTotals { get; init; } = [];
}
