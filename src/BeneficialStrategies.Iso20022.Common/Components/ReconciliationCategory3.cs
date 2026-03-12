// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies categories of statuses of a derivative when there is a reporting requirement for both counterparties.
/// </summary>
[IsoId("_IVUQNV55Ee2a_-MvhEjKmA")]
[DisplayName("Reconciliation Category")]
public partial record ReconciliationCategory3
{
    #nullable enable
    
    /// <summary>
    /// Indicator of receiving only one side or both sides of the derivatives.
    /// </summary>
    [IsoId("_IWQrYV55Ee2a_-MvhEjKmA")]
    [DisplayName("Reporting Type")]
    [IsoXmlTag("RptgTp")]
    public required TradeRepositoryReportingType1Code ReportingType { get; init; } 
    
    /// <summary>
    /// Indicator of side identification of the same derivative.
    /// </summary>
    [IsoId("_IWQrY155Ee2a_-MvhEjKmA")]
    [DisplayName("Pairing")]
    [IsoXmlTag("Pairg")]
    public required PairingStatus1Code Pairing { get; init; } 
    
    /// <summary>
    /// Indicator if reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
    /// </summary>
    [IsoId("_IWQrZV55Ee2a_-MvhEjKmA")]
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public required ReconciliationStatus1Code Reconciliation { get; init; } 
    
    /// <summary>
    /// Indicator if reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
    /// </summary>
    [IsoId("_IWQrZ155Ee2a_-MvhEjKmA")]
    [DisplayName("Valuation Reconciliation")]
    [IsoXmlTag("ValtnRcncltn")]
    public required ReconciliationStatus2Code ValuationReconciliation { get; init; } 
    
    /// <summary>
    /// Indicator of derivative reopening, terminated or cancelled by mistake.
    /// </summary>
    [IsoId("_IWQraV55Ee2a_-MvhEjKmA")]
    [DisplayName("Revived")]
    [IsoXmlTag("Rvvd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Revived { get; init; } 
    
    /// <summary>
    /// Indicator of modification to the terms or details of a previously reported derivative, at a trade or position level, but not a correction of a report.
    /// </summary>
    [IsoId("_IWQra155Ee2a_-MvhEjKmA")]
    [DisplayName("Further Modification")]
    [IsoXmlTag("FrthrMod")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator FurtherModification { get; init; } 
    
    
    #nullable disable
    
}
