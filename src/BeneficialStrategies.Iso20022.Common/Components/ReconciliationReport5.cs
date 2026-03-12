// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data on transaction requiring reconciliation or pairing.
/// </summary>
[IsoId("_CtHU1__oEemm3skPVSMJQg")]
[DisplayName("Reconciliation Report")]
public partial record ReconciliationReport5
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_CxSDIf_oEemm3skPVSMJQg")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Information related to transactions that are subject of reconciliation.
    /// </summary>
    [IsoId("_CxSDI__oEemm3skPVSMJQg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TradeTransactionIdentification4 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Indication whether information was modified.
    /// </summary>
    [IsoId("_CxSDJf_oEemm3skPVSMJQg")]
    [DisplayName("Modified")]
    [IsoXmlTag("Modfd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Modified { get; init; } 
    
    /// <summary>
    /// Indication whether the reconciliation is required.
    /// </summary>
    [IsoId("_CxSDJ__oEemm3skPVSMJQg")]
    [DisplayName("Reconciliation Status")]
    [IsoXmlTag("RcncltnSts")]
    public required ReconciliationStatus5Choice_ ReconciliationStatus { get; init; } 
    
    
    #nullable disable
    
}
