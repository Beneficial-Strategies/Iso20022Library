// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Common6.
/// </summary>
[IsoId("_1rt3zTEyEe6g-ffJsqGiSA")]
[DisplayName("Payment Common6")]
public partial record PaymentCommon6
{
    #nullable enable

    /// <summary>
    /// Common Status.
    /// </summary>
    [DisplayName("Common Status")]
    [IsoXmlTag("CmonSts")]
    public ValueList<PaymentStatus6> CommonStatus { get; init; } = [];

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 

    /// <summary>
    /// Entry Date.
    /// </summary>
    [DisplayName("Entry Date")]
    [IsoXmlTag("NtryDt")]
    public DateAndDateTime2Choice_? EntryDate { get; init; } 

    /// <summary>
    /// Payment From.
    /// </summary>
    [DisplayName("Payment From")]
    [IsoXmlTag("PmtFr")]
    public System3? PaymentFrom { get; init; } 

    /// <summary>
    /// Payment Method.
    /// </summary>
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentOrigin1Choice_? PaymentMethod { get; init; } 

    /// <summary>
    /// Payment To.
    /// </summary>
    [DisplayName("Payment To")]
    [IsoXmlTag("PmtTo")]
    public System3? PaymentTo { get; init; } 

    /// <summary>
    /// Requested Execution Date.
    /// </summary>
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 

    
    #nullable disable
    
}
