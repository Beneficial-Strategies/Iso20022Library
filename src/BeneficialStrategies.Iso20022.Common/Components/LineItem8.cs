// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Calculation of the current situation of a baseline as a result of the submission of a commercial data set.
/// </summary>
[IsoId("_RaVOCNp-Ed-ak6NoX_4Aeg_1564459654")]
[DisplayName("Line Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItem8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LineItem8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LineItem8( CurrencyAndAmount reqOrderedLineItemsTotalAmount,CurrencyAndAmount reqAcceptedLineItemsTotalAmount,CurrencyAndAmount reqOutstandingLineItemsTotalAmount,CurrencyAndAmount reqPendingLineItemsTotalAmount,CurrencyAndAmount reqOrderedTotalNetAmount,CurrencyAndAmount reqAcceptedTotalNetAmount,CurrencyAndAmount reqOutstandingTotalNetAmount,CurrencyAndAmount reqPendingTotalNetAmount )
    {
        OrderedLineItemsTotalAmount = reqOrderedLineItemsTotalAmount;
        AcceptedLineItemsTotalAmount = reqAcceptedLineItemsTotalAmount;
        OutstandingLineItemsTotalAmount = reqOutstandingLineItemsTotalAmount;
        PendingLineItemsTotalAmount = reqPendingLineItemsTotalAmount;
        OrderedTotalNetAmount = reqOrderedTotalNetAmount;
        AcceptedTotalNetAmount = reqAcceptedTotalNetAmount;
        OutstandingTotalNetAmount = reqOutstandingTotalNetAmount;
        PendingTotalNetAmount = reqPendingTotalNetAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Calculated information about the goods of the underlying transaction.
    /// </summary>
    [IsoId("_Rae_ANp-Ed-ak6NoX_4Aeg_1565380180")]
    [DisplayName("Line Item Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineItmDtls")]
    #endif
    [IsoXmlTag("LineItmDtls")]
    public ValueList<LineItemDetails8> LineItemDetails { get; init; } = new ValueList<LineItemDetails8>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Rae_ANp-Ed-ak6NoX_4Aeg_1565380180
    
    /// <summary>
    /// Line items total amount as indicated in the baseline.
    /// </summary>
    [IsoId("_Rae_Adp-Ed-ak6NoX_4Aeg_1564459693")]
    [DisplayName("Ordered Line Items Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrdLineItmsTtlAmt")]
    #endif
    [IsoXmlTag("OrdrdLineItmsTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount OrderedLineItemsTotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount OrderedLineItemsTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount OrderedLineItemsTotalAmount { get; init; } 
    #else
    public CurrencyAndAmount OrderedLineItemsTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Line items total amount accepted by a data set submission(s).
    /// </summary>
    [IsoId("_Rae_Atp-Ed-ak6NoX_4Aeg_1564459963")]
    [DisplayName("Accepted Line Items Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptdLineItmsTtlAmt")]
    #endif
    [IsoXmlTag("AccptdLineItmsTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount AcceptedLineItemsTotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount AcceptedLineItemsTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount AcceptedLineItemsTotalAmount { get; init; } 
    #else
    public CurrencyAndAmount AcceptedLineItemsTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between the ordered and the accepted line items total amount.
    /// </summary>
    [IsoId("_Rae_A9p-Ed-ak6NoX_4Aeg_1564460055")]
    [DisplayName("Outstanding Line Items Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutsdngLineItmsTtlAmt")]
    #endif
    [IsoXmlTag("OutsdngLineItmsTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount OutstandingLineItemsTotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount OutstandingLineItemsTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount OutstandingLineItemsTotalAmount { get; init; } 
    #else
    public CurrencyAndAmount OutstandingLineItemsTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Line item total amount for which a mismatched data set has been submitted and has not yet been accepted or rejected.
    /// </summary>
    [IsoId("_Rae_BNp-Ed-ak6NoX_4Aeg_1564459994")]
    [DisplayName("Pending Line Items Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgLineItmsTtlAmt")]
    #endif
    [IsoXmlTag("PdgLineItmsTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount PendingLineItemsTotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount PendingLineItemsTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount PendingLineItemsTotalAmount { get; init; } 
    #else
    public CurrencyAndAmount PendingLineItemsTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total net amount as indicated in the baseline.
    /// </summary>
    [IsoId("_Rae_Bdp-Ed-ak6NoX_4Aeg_1565380057")]
    [DisplayName("Ordered Total Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrdTtlNetAmt")]
    #endif
    [IsoXmlTag("OrdrdTtlNetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount OrderedTotalNetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount OrderedTotalNetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount OrderedTotalNetAmount { get; init; } 
    #else
    public CurrencyAndAmount OrderedTotalNetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total net amount accepted by a data set submission.
    /// </summary>
    [IsoId("_Rae_Btp-Ed-ak6NoX_4Aeg_1565380118")]
    [DisplayName("Accepted Total Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptdTtlNetAmt")]
    #endif
    [IsoXmlTag("AccptdTtlNetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount AcceptedTotalNetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount AcceptedTotalNetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount AcceptedTotalNetAmount { get; init; } 
    #else
    public CurrencyAndAmount AcceptedTotalNetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total net amount for which a mismatched data set has been submitted and has not yet been accepted or rejected.
    /// </summary>
    [IsoId("_Rae_B9p-Ed-ak6NoX_4Aeg_1565380148")]
    [DisplayName("Outstanding Total Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutsdngTtlNetAmt")]
    #endif
    [IsoXmlTag("OutsdngTtlNetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount OutstandingTotalNetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount OutstandingTotalNetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount OutstandingTotalNetAmount { get; init; } 
    #else
    public CurrencyAndAmount OutstandingTotalNetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between the ordered and the accepted total net amount.
    /// </summary>
    [IsoId("_Rae_CNp-Ed-ak6NoX_4Aeg_1565380119")]
    [DisplayName("Pending Total Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgTtlNetAmt")]
    #endif
    [IsoXmlTag("PdgTtlNetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount PendingTotalNetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount PendingTotalNetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount PendingTotalNetAmount { get; init; } 
    #else
    public CurrencyAndAmount PendingTotalNetAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
