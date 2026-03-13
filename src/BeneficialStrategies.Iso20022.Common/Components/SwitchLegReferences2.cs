// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a switch leg that is rejected or repaired.
/// </summary>
[IsoId("_Fx2LRTbtEead9bDRE_1DAQ")]
[DisplayName("Switch Leg References")]
public partial record SwitchLegReferences2
{
    #nullable enable
    
    /// <summary>
    /// Identification of a switch leg.
    /// </summary>
    [IsoId("_pWQb0EglEea9YuSvQGoi-w")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    public required LegIdentification1Choice_ LegIdentification { get; init; } 
    
    /// <summary>
    /// Additional information about the reason for the rejection of the leg.
    /// </summary>
    [IsoId("_GKGTFzbtEead9bDRE_1DAQ")]
    [DisplayName("Leg Rejection Reason")]
    [IsoXmlTag("LegRjctnRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? LegRejectionReason { get; init; } 
    
    /// <summary>
    /// Elements from the original individual order that have been repaired so that the order can be accepted.
    /// </summary>
    [IsoId("_KVakgUgmEea9YuSvQGoi-w")]
    [DisplayName("Repaired Fee")]
    [IsoXmlTag("RprdFee")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Fee3> RepairedFee { get; init; } = [];
    
    /// <summary>
    /// Account identification of the switch leg that is rejected or repaired.
    /// </summary>
    [IsoId("_GKGTGzbtEead9bDRE_1DAQ")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Financial instrument identification of the switch leg that is rejected or repaired.
    /// </summary>
    [IsoId("_GKGTHTbtEead9bDRE_1DAQ")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument57? FinancialInstrumentDetails { get; init; } 
    
    
    #nullable disable
    
}
