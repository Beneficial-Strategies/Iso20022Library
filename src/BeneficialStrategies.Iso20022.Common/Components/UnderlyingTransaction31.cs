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
/// Identifies the underlying (group of) transaction(s) to which the resolution of investigation applies.
/// </summary>
[IsoId("_MIswYRlbEe2Do_UtrNmb2g")]
[DisplayName("Underlying Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingTransaction31
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the original cancellation message, to which the resolution refers.
    /// </summary>
    [IsoId("_MSMDlxlbEe2Do_UtrNmb2g")]
    [DisplayName("Original Group Information And Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInfAndSts")]
    #endif
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupHeader14? OriginalGroupInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupHeader14? OriginalGroupInformationAndStatus { get; init; } 
    #else
    public OriginalGroupHeader14? OriginalGroupInformationAndStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the original (group of) transactions, to which the cancellation status refers.
    /// </summary>
    [IsoId("_MSMDmRlbEe2Do_UtrNmb2g")]
    [DisplayName("Original Payment Information And Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInfAndSts")]
    #endif
    [IsoXmlTag("OrgnlPmtInfAndSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalPaymentInstruction43? OriginalPaymentInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalPaymentInstruction43? OriginalPaymentInformationAndStatus { get; init; } 
    #else
    public OriginalPaymentInstruction43? OriginalPaymentInformationAndStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_MSMDmxlbEe2Do_UtrNmb2g")]
    [DisplayName("Transaction Information And Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxInfAndSts")]
    #endif
    [IsoXmlTag("TxInfAndSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction148? TransactionInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction148? TransactionInformationAndStatus { get; init; } 
    #else
    public PaymentTransaction148? TransactionInformationAndStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
