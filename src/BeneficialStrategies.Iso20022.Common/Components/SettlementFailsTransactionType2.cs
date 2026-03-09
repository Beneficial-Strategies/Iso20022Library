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
/// Specifies the transaction type as defined in the relevant regulation.
/// </summary>
[IsoId("_apzGIx2lEeqF2P5v-Rtejg")]
[DisplayName("Settlement Fails Transaction Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsTransactionType2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsTransactionType2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsTransactionType2( SettlementTotalData1Choice_ reqSecuritiesBuyOrSell,SettlementTotalData1Choice_ reqCollateralManagementOperation,SettlementTotalData1Choice_ reqSecuritiesLendingOrBorrowing,SettlementTotalData1Choice_ reqRepurchaseAgreement,SettlementTotalData1Choice_ reqOther )
    {
        SecuritiesBuyOrSell = reqSecuritiesBuyOrSell;
        CollateralManagementOperation = reqCollateralManagementOperation;
        SecuritiesLendingOrBorrowing = reqSecuritiesLendingOrBorrowing;
        RepurchaseAgreement = reqRepurchaseAgreement;
        Other = reqOther;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Purchase or sale of securities.
    /// </summary>
    [IsoId("_aqtFAR2lEeqF2P5v-Rtejg")]
    [DisplayName("Securities Buy Or Sell")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesBuyOrSell")]
    #endif
    [IsoXmlTag("SctiesBuyOrSell")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ SecuritiesBuyOrSell { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ SecuritiesBuyOrSell { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ SecuritiesBuyOrSell { get; init; } 
    #else
    public SettlementTotalData1Choice_ SecuritiesBuyOrSell { get; set; } 
    #endif
    
    /// <summary>
    /// Relates to securities transfers aiming to provide or to return collateral.
    /// </summary>
    [IsoId("_aqtFAx2lEeqF2P5v-Rtejg")]
    [DisplayName("Collateral Management Operation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollMgmtOpr")]
    #endif
    [IsoXmlTag("CollMgmtOpr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ CollateralManagementOperation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ CollateralManagementOperation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ CollateralManagementOperation { get; init; } 
    #else
    public SettlementTotalData1Choice_ CollateralManagementOperation { get; set; } 
    #endif
    
    /// <summary>
    /// Relates to a securities lending or borrowing operation.
    /// </summary>
    [IsoId("_aqtFBR2lEeqF2P5v-Rtejg")]
    [DisplayName("Securities Lending Or Borrowing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesLndgOrBrrwg")]
    #endif
    [IsoXmlTag("SctiesLndgOrBrrwg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ SecuritiesLendingOrBorrowing { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ SecuritiesLendingOrBorrowing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ SecuritiesLendingOrBorrowing { get; init; } 
    #else
    public SettlementTotalData1Choice_ SecuritiesLendingOrBorrowing { get; set; } 
    #endif
    
    /// <summary>
    /// Repurchase transactions.
    /// </summary>
    [IsoId("_aqtFBx2lEeqF2P5v-Rtejg")]
    [DisplayName("Repurchase Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpAgrmt")]
    #endif
    [IsoXmlTag("RpAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ RepurchaseAgreement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ RepurchaseAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ RepurchaseAgreement { get; init; } 
    #else
    public SettlementTotalData1Choice_ RepurchaseAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Covers any securities transactions type not covered as a dedicated type.
    /// </summary>
    [IsoId("_aqtFCR2lEeqF2P5v-Rtejg")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ Other { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ Other { get; init; } 
    #else
    public SettlementTotalData1Choice_ Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
