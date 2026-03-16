// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation Category5.
/// </summary>
[IsoId("_2PrtoK-8Ee69JssYImngCA")]
[DisplayName("Reconciliation Category5")]
public partial record ReconciliationCategory5
{
    #nullable enable

    /// <summary>
    /// Further Modification.
    /// </summary>
    [DisplayName("Further Modification")]
    [IsoXmlTag("FrthrMod")]
    public required IsoYesNoIndicator FurtherModification { get; init; } 

    /// <summary>
    /// Pairing.
    /// </summary>
    [DisplayName("Pairing")]
    [IsoXmlTag("Pairg")]
    public required PairingStatus1Code Pairing { get; init; } 

    /// <summary>
    /// Reconciliation.
    /// </summary>
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public required ReconciliationStatus1Code Reconciliation { get; init; } 

    /// <summary>
    /// Reporting Type.
    /// </summary>
    [DisplayName("Reporting Type")]
    [IsoXmlTag("RptgTp")]
    public required TradeRepositoryReportingType1Code ReportingType { get; init; } 

    /// <summary>
    /// Revived.
    /// </summary>
    [DisplayName("Revived")]
    [IsoXmlTag("Rvvd")]
    public required IsoYesNoIndicator Revived { get; init; } 

    /// <summary>
    /// Valuation Reconciliation.
    /// </summary>
    [DisplayName("Valuation Reconciliation")]
    [IsoXmlTag("ValtnRcncltn")]
    public required ReconciliationStatus2Code ValuationReconciliation { get; init; } 

    
    #nullable disable
    
}
