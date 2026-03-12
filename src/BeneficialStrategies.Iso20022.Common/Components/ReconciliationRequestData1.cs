// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Reconciliation Request message.
/// </summary>
[IsoId("__qugkNxdEeioifFt1dhnJA")]
[DisplayName("Reconciliation Request Data")]
public partial record ReconciliationRequestData1
{
    #nullable enable
    
    /// <summary>
    /// Type of Reconciliation requested by the Sale to the POI.
    /// </summary>
    [IsoId("_E1kNwNxeEeioifFt1dhnJA")]
    [DisplayName("Reconciliation Type")]
    [IsoXmlTag("RcncltnTp")]
    public required ReconciliationType1Code ReconciliationType { get; init; } 
    
    /// <summary>
    /// Identification of the Acquirer.
    /// </summary>
    [IsoId("_lzjRwNxeEeioifFt1dhnJA")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AcquirerIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the reconciliation period between Sale and POI.
    /// </summary>
    [IsoId("_pqqtQNxeEeioifFt1dhnJA")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    
    
    #nullable disable
    
}
