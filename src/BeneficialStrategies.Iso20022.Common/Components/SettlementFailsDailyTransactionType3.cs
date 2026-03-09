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
[IsoId("_MUG5RTOmEeqX8uoQQ3KffQ")]
[DisplayName("Settlement Fails Daily Transaction Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsDailyTransactionType3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsDailyTransactionType3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsDailyTransactionType3( SettlementFailsDailyCSD1Choice_ reqSecuritiesBuyOrSell,SettlementFailsDailyCSD1Choice_ reqCollateralManagementOperation,SettlementFailsDailyCSD1Choice_ reqSecuritiesLendingOrBorrowing,SettlementFailsDailyCSD1Choice_ reqRepurchaseAgreement,SettlementFailsDailyCSD1Choice_ reqOther )
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
    [IsoId("_MU7YoTOmEeqX8uoQQ3KffQ")]
    [DisplayName("Securities Buy Or Sell")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesBuyOrSell")]
    #endif
    [IsoXmlTag("SctiesBuyOrSell")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyCSD1Choice_ SecuritiesBuyOrSell { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyCSD1Choice_ SecuritiesBuyOrSell { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyCSD1Choice_ SecuritiesBuyOrSell { get; init; } 
    #else
    public SettlementFailsDailyCSD1Choice_ SecuritiesBuyOrSell { get; set; } 
    #endif
    
    /// <summary>
    /// Relates to securities transfers aiming to provide or to return collateral.
    /// </summary>
    [IsoId("_MU7YozOmEeqX8uoQQ3KffQ")]
    [DisplayName("Collateral Management Operation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollMgmtOpr")]
    #endif
    [IsoXmlTag("CollMgmtOpr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyCSD1Choice_ CollateralManagementOperation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyCSD1Choice_ CollateralManagementOperation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyCSD1Choice_ CollateralManagementOperation { get; init; } 
    #else
    public SettlementFailsDailyCSD1Choice_ CollateralManagementOperation { get; set; } 
    #endif
    
    /// <summary>
    /// Relates to a securities lending or borrowing operation.
    /// </summary>
    [IsoId("_MU7YpTOmEeqX8uoQQ3KffQ")]
    [DisplayName("Securities Lending Or Borrowing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesLndgOrBrrwg")]
    #endif
    [IsoXmlTag("SctiesLndgOrBrrwg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyCSD1Choice_ SecuritiesLendingOrBorrowing { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyCSD1Choice_ SecuritiesLendingOrBorrowing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyCSD1Choice_ SecuritiesLendingOrBorrowing { get; init; } 
    #else
    public SettlementFailsDailyCSD1Choice_ SecuritiesLendingOrBorrowing { get; set; } 
    #endif
    
    /// <summary>
    /// Repurchase transactions.
    /// </summary>
    [IsoId("_MU7YpzOmEeqX8uoQQ3KffQ")]
    [DisplayName("Repurchase Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpAgrmt")]
    #endif
    [IsoXmlTag("RpAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyCSD1Choice_ RepurchaseAgreement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyCSD1Choice_ RepurchaseAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyCSD1Choice_ RepurchaseAgreement { get; init; } 
    #else
    public SettlementFailsDailyCSD1Choice_ RepurchaseAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Covers any securities transactions type not covered as a dedicated type.
    /// </summary>
    [IsoId("_MU7YqTOmEeqX8uoQQ3KffQ")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyCSD1Choice_ Other { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyCSD1Choice_ Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyCSD1Choice_ Other { get; init; } 
    #else
    public SettlementFailsDailyCSD1Choice_ Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
