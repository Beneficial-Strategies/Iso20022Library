// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the process type used for the trade repository reconciliation.
/// </summary>
[IsoId("_ZhSkZ62lEeujnrmCqLd8pg")]
[DisplayName("Reconciliation Flag")]
public partial record ReconciliationFlag2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether both counterparties to the transaction have reported to the same Trade Repository
    /// </summary>
    [IsoId("_Zw7i0a2lEeujnrmCqLd8pg")]
    [DisplayName("Report Type")]
    [IsoXmlTag("RptTp")]
    public TradeRepositoryReportingType1Code? ReportType { get; init; } 
    
    /// <summary>
    /// Indicates whether both counterparties are obliged to report the transaction data.
    /// </summary>
    [IsoId("_Zw7i062lEeujnrmCqLd8pg")]
    [DisplayName("Both Counterparties Reporting")]
    [IsoXmlTag("BothCtrPtiesRptg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BothCounterpartiesReporting { get; init; } 
    
    /// <summary>
    /// Indicates whether the transaction is paired.
    /// </summary>
    [IsoId("_Zw7i1a2lEeujnrmCqLd8pg")]
    [DisplayName("Paired Status")]
    [IsoXmlTag("PairdSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PairedStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether loan data is reconciled.
    /// </summary>
    [IsoId("_Zw7i162lEeujnrmCqLd8pg")]
    [DisplayName("Loan Reconciliation Status")]
    [IsoXmlTag("LnRcncltnSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LoanReconciliationStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether collateral data is reconciled.
    /// </summary>
    [IsoId("_Zw7i2a2lEeujnrmCqLd8pg")]
    [DisplayName("Collateral Reconciliation Status")]
    [IsoXmlTag("CollRcncltnSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CollateralReconciliationStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether the initially submitted report was further modified using action type modification.
    /// </summary>
    [IsoId("_Zw7i262lEeujnrmCqLd8pg")]
    [DisplayName("Modification Status")]
    [IsoXmlTag("ModSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ModificationStatus { get; init; } 
    
    
    #nullable disable
    
}
