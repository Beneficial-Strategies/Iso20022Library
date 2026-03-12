// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the standing instruction.
/// </summary>
[IsoId("_UJkbdNp-Ed-ak6NoX_4Aeg_1871445103")]
[DisplayName("Corporate Action Standing Instruction General Information")]
public partial record CorporateActionStandingInstructionGeneralInformation1
{
    #nullable enable
    
    /// <summary>
    /// Type of standing instruction.
    /// </summary>
    [IsoId("_UJkbddp-Ed-ak6NoX_4Aeg_1386661402")]
    [DisplayName("Standing Instruction Type")]
    [IsoXmlTag("StgInstrTp")]
    public required StandingInstructionType1Code StandingInstructionType { get; init; } 
    
    /// <summary>
    /// Type of coporpate action event.
    /// </summary>
    [IsoId("_UJkbdtp-Ed-ak6NoX_4Aeg_1471624351")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public CorporateActionEventType2FormatChoice_? EventType { get; init; } 
    
    /// <summary>
    /// Identification of the instructing party, ie, the CSD client.
    /// </summary>
    [IsoId("_UJkbd9p-Ed-ak6NoX_4Aeg_-218154734")]
    [DisplayName("Instructing Party Identification")]
    [IsoXmlTag("InstgPtyId")]
    public required PartyIdentification2Choice_ InstructingPartyIdentification { get; init; } 
    
    /// <summary>
    /// Reference of the standing instruction assigned by the client.
    /// </summary>
    [IsoId("_UJkbeNp-Ed-ak6NoX_4Aeg_-290186934")]
    [DisplayName("Client Standing Instruction Identification")]
    [IsoXmlTag("ClntStgInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ClientStandingInstructionIdentification { get; init; } 
    
    /// <summary>
    /// Provides information about the account to which the standing instruction can apply.
    /// </summary>
    [IsoId("_UJkbedp-Ed-ak6NoX_4Aeg_-1954368406")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public IncludedAccount1? AccountDetails { get; init; } 
    
    /// <summary>
    /// Identification of the underlying financial instrument, ie, the financial instrument affected by the corporate action event.
    /// </summary>
    [IsoId("_UJkbetp-Ed-ak6NoX_4Aeg_1334871492")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentDescription3? UnderlyingSecurity { get; init; } 
    
    
    #nullable disable
    
}
