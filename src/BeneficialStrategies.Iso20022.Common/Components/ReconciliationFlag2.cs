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
/// Specifies the process type used for the trade repository reconciliation.
/// </summary>
[IsoId("_ZhSkZ62lEeujnrmCqLd8pg")]
[DisplayName("Reconciliation Flag")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReconciliationFlag2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether both counterparties to the transaction have reported to the same Trade Repository
    /// </summary>
    [IsoId("_Zw7i0a2lEeujnrmCqLd8pg")]
    [DisplayName("Report Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptTp")]
    #endif
    [IsoXmlTag("RptTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeRepositoryReportingType1Code? ReportType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeRepositoryReportingType1Code? ReportType { get; init; } 
    #else
    public TradeRepositoryReportingType1Code? ReportType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether both counterparties are obliged to report the transaction data.
    /// </summary>
    [IsoId("_Zw7i062lEeujnrmCqLd8pg")]
    [DisplayName("Both Counterparties Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BothCtrPtiesRptg")]
    #endif
    [IsoXmlTag("BothCtrPtiesRptg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? BothCounterpartiesReporting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BothCounterpartiesReporting { get; init; } 
    #else
    public System.String? BothCounterpartiesReporting { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transaction is paired.
    /// </summary>
    [IsoId("_Zw7i1a2lEeujnrmCqLd8pg")]
    [DisplayName("Paired Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PairdSts")]
    #endif
    [IsoXmlTag("PairdSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PairedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PairedStatus { get; init; } 
    #else
    public System.String? PairedStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether loan data is reconciled.
    /// </summary>
    [IsoId("_Zw7i162lEeujnrmCqLd8pg")]
    [DisplayName("Loan Reconciliation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LnRcncltnSts")]
    #endif
    [IsoXmlTag("LnRcncltnSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? LoanReconciliationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LoanReconciliationStatus { get; init; } 
    #else
    public System.String? LoanReconciliationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether collateral data is reconciled.
    /// </summary>
    [IsoId("_Zw7i2a2lEeujnrmCqLd8pg")]
    [DisplayName("Collateral Reconciliation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollRcncltnSts")]
    #endif
    [IsoXmlTag("CollRcncltnSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CollateralReconciliationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralReconciliationStatus { get; init; } 
    #else
    public System.String? CollateralReconciliationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the initially submitted report was further modified using action type modification.
    /// </summary>
    [IsoId("_Zw7i262lEeujnrmCqLd8pg")]
    [DisplayName("Modification Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModSts")]
    #endif
    [IsoXmlTag("ModSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ModificationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ModificationStatus { get; init; } 
    #else
    public System.String? ModificationStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
