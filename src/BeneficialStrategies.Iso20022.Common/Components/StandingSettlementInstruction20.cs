// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Standing Settlement Instruction20.
/// </summary>
[IsoId("_s-Iro4otEe-efPejSUAtLw")]
[DisplayName("Standing Settlement Instruction20")]
public partial record StandingSettlementInstruction20
{
    #nullable enable

    /// <summary>
    /// Counterparty.
    /// </summary>
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    public required Counterparty15Choice_ Counterparty { get; init; } 

    /// <summary>
    /// Other Delivering Settlement Parties.
    /// </summary>
    [DisplayName("Other Delivering Settlement Parties")]
    [IsoXmlTag("OthrDlvrgSttlmPties")]
    public SettlementParties126? OtherDeliveringSettlementParties { get; init; } 

    /// <summary>
    /// Other Receiving Settlement Parties.
    /// </summary>
    [DisplayName("Other Receiving Settlement Parties")]
    [IsoXmlTag("OthrRcvgSttlmPties")]
    public SettlementParties126? OtherReceivingSettlementParties { get; init; } 

    /// <summary>
    /// Settlement Standing Instruction Database.
    /// </summary>
    [DisplayName("Settlement Standing Instruction Database")]
    [IsoXmlTag("SttlmStgInstrDB")]
    public required SettlementStandingInstructionDatabase4Choice_ SettlementStandingInstructionDatabase { get; init; } 

    /// <summary>
    /// Vendor.
    /// </summary>
    [DisplayName("Vendor")]
    [IsoXmlTag("Vndr")]
    public PartyIdentification136? Vendor { get; init; } 

    
    #nullable disable
    
}
