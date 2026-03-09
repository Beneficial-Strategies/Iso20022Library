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
/// Specifies the aggregated data per transaction type for a settlement internaliser.
/// </summary>
[IsoId("_ZsjzoO3oEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser Transaction Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementInternaliserTransactionType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementInternaliserTransactionType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementInternaliserTransactionType1( InternalisationData1 reqSecuritiesBuyOrSell,InternalisationData1 reqCollateralManagementOperation,InternalisationData1 reqSecuritiesLendingOrBorrowing,InternalisationData1 reqRepurchaseAgreement,InternalisationData1 reqOtherTransactions )
    {
        SecuritiesBuyOrSell = reqSecuritiesBuyOrSell;
        CollateralManagementOperation = reqCollateralManagementOperation;
        SecuritiesLendingOrBorrowing = reqSecuritiesLendingOrBorrowing;
        RepurchaseAgreement = reqRepurchaseAgreement;
        OtherTransactions = reqOtherTransactions;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Purchase or sale of securities.
    /// </summary>
    [IsoId("_5qB10O3oEeaWjpoyrnG6Rw")]
    [DisplayName("Securities Buy Or Sell")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesBuyOrSell")]
    #endif
    [IsoXmlTag("SctiesBuyOrSell")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 SecuritiesBuyOrSell { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 SecuritiesBuyOrSell { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 SecuritiesBuyOrSell { get; init; } 
    #else
    public InternalisationData1 SecuritiesBuyOrSell { get; set; } 
    #endif
    
    /// <summary>
    /// Relates to securities transfers aiming to provide or to return collateral.
    /// </summary>
    [IsoId("__U4f0O3oEeaWjpoyrnG6Rw")]
    [DisplayName("Collateral Management Operation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollMgmtOpr")]
    #endif
    [IsoXmlTag("CollMgmtOpr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 CollateralManagementOperation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 CollateralManagementOperation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 CollateralManagementOperation { get; init; } 
    #else
    public InternalisationData1 CollateralManagementOperation { get; set; } 
    #endif
    
    /// <summary>
    /// Relates to a securities lending or borrowing operation.
    /// </summary>
    [IsoId("_D0A9kO3pEeaWjpoyrnG6Rw")]
    [DisplayName("Securities Lending Or Borrowing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesLndgOrBrrwg")]
    #endif
    [IsoXmlTag("SctiesLndgOrBrrwg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 SecuritiesLendingOrBorrowing { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 SecuritiesLendingOrBorrowing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 SecuritiesLendingOrBorrowing { get; init; } 
    #else
    public InternalisationData1 SecuritiesLendingOrBorrowing { get; set; } 
    #endif
    
    /// <summary>
    /// Repurchase transactions.
    /// </summary>
    [IsoId("_GQqmMO3pEeaWjpoyrnG6Rw")]
    [DisplayName("Repurchase Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpAgrmt")]
    #endif
    [IsoXmlTag("RpAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 RepurchaseAgreement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 RepurchaseAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 RepurchaseAgreement { get; init; } 
    #else
    public InternalisationData1 RepurchaseAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Covers any securities transactions type not covered as a dedicated type.
    /// </summary>
    [IsoId("_RMMfoO3pEeaWjpoyrnG6Rw")]
    [DisplayName("Other Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTxs")]
    #endif
    [IsoXmlTag("OthrTxs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 OtherTransactions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 OtherTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 OtherTransactions { get; init; } 
    #else
    public InternalisationData1 OtherTransactions { get; set; } 
    #endif
    
    
    #nullable disable
    
}
