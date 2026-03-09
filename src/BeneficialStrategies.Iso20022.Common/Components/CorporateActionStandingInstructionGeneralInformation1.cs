// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the standing instruction.
/// </summary>
[IsoId("_UJkbdNp-Ed-ak6NoX_4Aeg_1871445103")]
[DisplayName("Corporate Action Standing Instruction General Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionStandingInstructionGeneralInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionStandingInstructionGeneralInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionStandingInstructionGeneralInformation1( StandingInstructionType1Code reqStandingInstructionType,PartyIdentification2Choice_ reqInstructingPartyIdentification,System.String reqClientStandingInstructionIdentification )
    {
        StandingInstructionType = reqStandingInstructionType;
        InstructingPartyIdentification = reqInstructingPartyIdentification;
        ClientStandingInstructionIdentification = reqClientStandingInstructionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of standing instruction.
    /// </summary>
    [IsoId("_UJkbddp-Ed-ak6NoX_4Aeg_1386661402")]
    [DisplayName("Standing Instruction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgInstrTp")]
    #endif
    [IsoXmlTag("StgInstrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StandingInstructionType1Code StandingInstructionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StandingInstructionType1Code StandingInstructionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingInstructionType1Code StandingInstructionType { get; init; } 
    #else
    public StandingInstructionType1Code StandingInstructionType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of coporpate action event.
    /// </summary>
    [IsoId("_UJkbdtp-Ed-ak6NoX_4Aeg_1471624351")]
    [DisplayName("Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTp")]
    #endif
    [IsoXmlTag("EvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventType2FormatChoice_? EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventType2FormatChoice_? EventType { get; init; } 
    #else
    public CorporateActionEventType2FormatChoice_? EventType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the instructing party, ie, the CSD client.
    /// </summary>
    [IsoId("_UJkbd9p-Ed-ak6NoX_4Aeg_-218154734")]
    [DisplayName("Instructing Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstgPtyId")]
    #endif
    [IsoXmlTag("InstgPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification2Choice_ InstructingPartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification2Choice_ InstructingPartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_ InstructingPartyIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_ InstructingPartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the standing instruction assigned by the client.
    /// </summary>
    [IsoId("_UJkbeNp-Ed-ak6NoX_4Aeg_-290186934")]
    [DisplayName("Client Standing Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntStgInstrId")]
    #endif
    [IsoXmlTag("ClntStgInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ClientStandingInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ClientStandingInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ClientStandingInstructionIdentification { get; init; } 
    #else
    public System.String ClientStandingInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the account to which the standing instruction can apply.
    /// </summary>
    [IsoId("_UJkbedp-Ed-ak6NoX_4Aeg_-1954368406")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncludedAccount1? AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncludedAccount1? AccountDetails { get; init; } 
    #else
    public IncludedAccount1? AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the underlying financial instrument, ie, the financial instrument affected by the corporate action event.
    /// </summary>
    [IsoId("_UJkbetp-Ed-ak6NoX_4Aeg_1334871492")]
    [DisplayName("Underlying Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygScty")]
    #endif
    [IsoXmlTag("UndrlygScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentDescription3? UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentDescription3? UnderlyingSecurity { get; init; } 
    #else
    public FinancialInstrumentDescription3? UnderlyingSecurity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
