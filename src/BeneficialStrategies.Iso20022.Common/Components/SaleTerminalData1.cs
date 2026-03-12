// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the software and hardware feature of the Sale Terminal.
/// </summary>
[IsoId("_PfggMN6IEeiwsev40qZGEQ")]
[DisplayName("Sale Terminal Data")]
public partial record SaleTerminalData1
{
    #nullable enable
    
    /// <summary>
    /// Human attendance at the POI location during the transaction.
    /// </summary>
    [IsoId("_VoMVsN6IEeiwsev40qZGEQ")]
    [DisplayName("Terminal Environment")]
    [IsoXmlTag("TermnlEnvt")]
    public AttendanceContext1Code? TerminalEnvironment { get; init; } 
    
    /// <summary>
    /// Identifier of the reconciliation between the Sale system and the POI system.
    /// </summary>
    [IsoId("_buPG4N6IEeiwsev40qZGEQ")]
    [DisplayName("Sale Reconciliation Identification")]
    [IsoXmlTag("SaleRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SaleReconciliationIdentification { get; init; } 
    
    
    #nullable disable
    
}
