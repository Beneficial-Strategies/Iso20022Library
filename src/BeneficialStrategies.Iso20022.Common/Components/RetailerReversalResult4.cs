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
/// Reversal transaction results after a Reversal request.
/// </summary>
[IsoId("_hUjmAU37Eey_VecAUE-C9Q")]
[DisplayName("Retailer Reversal Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RetailerReversalResult4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// POI reconciliation identification.
    /// </summary>
    [IsoId("_hbf7gU37Eey_VecAUE-C9Q")]
    [DisplayName("POI Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIRcncltnId")]
    #endif
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? POIReconciliationIdentification { get; init; } 
    #else
    public System.String? POIReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original Transaction if any linked to this reversal.
    /// </summary>
    [IsoId("_hbf7g037Eey_VecAUE-C9Q")]
    [DisplayName("Original Payment Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtTx")]
    #endif
    [IsoXmlTag("OrgnlPmtTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentTransaction120? OriginalPaymentTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction120? OriginalPaymentTransaction { get; init; } 
    #else
    public CardPaymentTransaction120? OriginalPaymentTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Updated Customer order list after reversal.
    /// </summary>
    [IsoId("_hbf7hU37Eey_VecAUE-C9Q")]
    [DisplayName("Customer Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrOrdr")]
    #endif
    [IsoXmlTag("CstmrOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerOrder1? CustomerOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerOrder1? CustomerOrder { get; init; } 
    #else
    public CustomerOrder1? CustomerOrder { get; set; } 
    #endif
    
    
    #nullable disable
    
}
