// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Calculation of the current situation of a baseline as a result of the submission of a commercial data set.
/// </summary>
[IsoId("_RaVOCNp-Ed-ak6NoX_4Aeg_1564459654")]
[DisplayName("Line Item")]
public partial record LineItem8
{
    #nullable enable
    
    /// <summary>
    /// Calculated information about the goods of the underlying transaction.
    /// </summary>
    [IsoId("_Rae_ANp-Ed-ak6NoX_4Aeg_1565380180")]
    [DisplayName("Line Item Details")]
    [IsoXmlTag("LineItmDtls")]
    public ValueList<LineItemDetails8> LineItemDetails { get; init; } = [];
    // ID for the above is _Rae_ANp-Ed-ak6NoX_4Aeg_1565380180
    
    /// <summary>
    /// Line items total amount as indicated in the baseline.
    /// </summary>
    [IsoId("_Rae_Adp-Ed-ak6NoX_4Aeg_1564459693")]
    [DisplayName("Ordered Line Items Total Amount")]
    [IsoXmlTag("OrdrdLineItmsTtlAmt")]
    public required CurrencyAndAmount OrderedLineItemsTotalAmount { get; init; } 
    
    /// <summary>
    /// Line items total amount accepted by a data set submission(s).
    /// </summary>
    [IsoId("_Rae_Atp-Ed-ak6NoX_4Aeg_1564459963")]
    [DisplayName("Accepted Line Items Total Amount")]
    [IsoXmlTag("AccptdLineItmsTtlAmt")]
    public required CurrencyAndAmount AcceptedLineItemsTotalAmount { get; init; } 
    
    /// <summary>
    /// Difference between the ordered and the accepted line items total amount.
    /// </summary>
    [IsoId("_Rae_A9p-Ed-ak6NoX_4Aeg_1564460055")]
    [DisplayName("Outstanding Line Items Total Amount")]
    [IsoXmlTag("OutsdngLineItmsTtlAmt")]
    public required CurrencyAndAmount OutstandingLineItemsTotalAmount { get; init; } 
    
    /// <summary>
    /// Line item total amount for which a mismatched data set has been submitted and has not yet been accepted or rejected.
    /// </summary>
    [IsoId("_Rae_BNp-Ed-ak6NoX_4Aeg_1564459994")]
    [DisplayName("Pending Line Items Total Amount")]
    [IsoXmlTag("PdgLineItmsTtlAmt")]
    public required CurrencyAndAmount PendingLineItemsTotalAmount { get; init; } 
    
    /// <summary>
    /// Total net amount as indicated in the baseline.
    /// </summary>
    [IsoId("_Rae_Bdp-Ed-ak6NoX_4Aeg_1565380057")]
    [DisplayName("Ordered Total Net Amount")]
    [IsoXmlTag("OrdrdTtlNetAmt")]
    public required CurrencyAndAmount OrderedTotalNetAmount { get; init; } 
    
    /// <summary>
    /// Total net amount accepted by a data set submission.
    /// </summary>
    [IsoId("_Rae_Btp-Ed-ak6NoX_4Aeg_1565380118")]
    [DisplayName("Accepted Total Net Amount")]
    [IsoXmlTag("AccptdTtlNetAmt")]
    public required CurrencyAndAmount AcceptedTotalNetAmount { get; init; } 
    
    /// <summary>
    /// Total net amount for which a mismatched data set has been submitted and has not yet been accepted or rejected.
    /// </summary>
    [IsoId("_Rae_B9p-Ed-ak6NoX_4Aeg_1565380148")]
    [DisplayName("Outstanding Total Net Amount")]
    [IsoXmlTag("OutsdngTtlNetAmt")]
    public required CurrencyAndAmount OutstandingTotalNetAmount { get; init; } 
    
    /// <summary>
    /// Difference between the ordered and the accepted total net amount.
    /// </summary>
    [IsoId("_Rae_CNp-Ed-ak6NoX_4Aeg_1565380119")]
    [DisplayName("Pending Total Net Amount")]
    [IsoXmlTag("PdgTtlNetAmt")]
    public required CurrencyAndAmount PendingTotalNetAmount { get; init; } 
    
    
    #nullable disable
    
}
