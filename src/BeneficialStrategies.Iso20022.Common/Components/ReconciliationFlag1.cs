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
[IsoId("_N6obcNIDEeiG-o-KpBT4-g")]
[DisplayName("Reconciliation Flag")]
public partial record ReconciliationFlag1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether both counterparties to the transaction have reported to the same Trade Repository
    /// </summary>
    [IsoId("_giwXsNIEEeiG-o-KpBT4-g")]
    [DisplayName("Report Type")]
    [IsoXmlTag("RptTp")]
    public TradeRepositoryReportingType1Code? ReportType { get; init; } 
    
    /// <summary>
    /// Indicates whether both counterparties are obliged to report the transaction data.
    /// </summary>
    [IsoId("_LZGdYNIEEeiG-o-KpBT4-g")]
    [DisplayName("Both Counterparties Reporting")]
    [IsoXmlTag("BothCtrPtiesRptg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BothCounterpartiesReporting { get; init; } 
    
    /// <summary>
    /// Indicates whether the transaction is paired.
    /// </summary>
    [IsoId("_783_8NIDEeiG-o-KpBT4-g")]
    [DisplayName("Paired Status")]
    [IsoXmlTag("PairdSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PairedStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether loan data is reconciled.
    /// </summary>
    [IsoId("_S6hgENIHEeiG-o-KpBT4-g")]
    [DisplayName("Loan Reconciliation Status")]
    [IsoXmlTag("LnRcncltnSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LoanReconciliationStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether collateral data is reconciled.
    /// </summary>
    [IsoId("_W-lLYNIHEeiG-o-KpBT4-g")]
    [DisplayName("Collateral Reconciliation Status")]
    [IsoXmlTag("CollRcncltnSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CollateralReconciliationStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether the initially submitted report was further modified using action type modification.
    /// </summary>
    [IsoId("_xL6XwNIDEeiG-o-KpBT4-g")]
    [DisplayName("Modification Status")]
    [IsoXmlTag("ModSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ModificationStatus { get; init; } 
    
    
    #nullable disable
    
}
