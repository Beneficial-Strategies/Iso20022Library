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
/// General information about the corporate action event.
/// </summary>
[IsoId("_TdxFY9p-Ed-ak6NoX_4Aeg_1155832018")]
[DisplayName("Corporate Action Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionInformation1( PartyIdentification2Choice_ reqAgentIdentification,CorporateActionEventType2FormatChoice_ reqEventType,CorporateActionMandatoryVoluntary1FormatChoice_ reqMandatoryVoluntaryEventType,FinancialInstrumentDescription3 reqUnderlyingSecurity )
    {
        AgentIdentification = reqAgentIdentification;
        EventType = reqEventType;
        MandatoryVoluntaryEventType = reqMandatoryVoluntaryEventType;
        UnderlyingSecurity = reqUnderlyingSecurity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the issuer agent.
    /// </summary>
    [IsoId("_TdxFZNp-Ed-ak6NoX_4Aeg_-2004583146")]
    [DisplayName("Agent Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtId")]
    #endif
    [IsoXmlTag("AgtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification2Choice_ AgentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification2Choice_ AgentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_ AgentIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_ AgentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference given to the event by the CA event issuer (agent).
    /// </summary>
    [IsoId("_TdxFZdp-Ed-ak6NoX_4Aeg_2012826333")]
    [DisplayName("Issuer Corporate Action Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrCorpActnId")]
    #endif
    [IsoXmlTag("IssrCorpActnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? IssuerCorporateActionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuerCorporateActionIdentification { get; init; } 
    #else
    public System.String? IssuerCorporateActionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_TdxFZtp-Ed-ak6NoX_4Aeg_1187231640")]
    [DisplayName("Corporate Action Processing Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnPrcgId")]
    #endif
    [IsoXmlTag("CorpActnPrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CorporateActionProcessingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CorporateActionProcessingIdentification { get; init; } 
    #else
    public System.String? CorporateActionProcessingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_TdxFZ9p-Ed-ak6NoX_4Aeg_1187231671")]
    [DisplayName("Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTp")]
    #endif
    [IsoXmlTag("EvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionEventType2FormatChoice_ EventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionEventType2FormatChoice_ EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventType2FormatChoice_ EventType { get; init; } 
    #else
    public CorporateActionEventType2FormatChoice_ EventType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_TdxFaNp-Ed-ak6NoX_4Aeg_1497013693")]
    [DisplayName("Mandatory Voluntary Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtryVlntryEvtTp")]
    #endif
    [IsoXmlTag("MndtryVlntryEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionMandatoryVoluntary1FormatChoice_ MandatoryVoluntaryEventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionMandatoryVoluntary1FormatChoice_ MandatoryVoluntaryEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMandatoryVoluntary1FormatChoice_ MandatoryVoluntaryEventType { get; init; } 
    #else
    public CorporateActionMandatoryVoluntary1FormatChoice_ MandatoryVoluntaryEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of processing involved by a Corporate Action.
    /// </summary>
    [IsoId("_Td6PUNp-Ed-ak6NoX_4Aeg_-1661033303")]
    [DisplayName("Event Processing Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtPrcgTp")]
    #endif
    [IsoXmlTag("EvtPrcgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventProcessingType1FormatChoice_? EventProcessingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventProcessingType1FormatChoice_? EventProcessingType { get; init; } 
    #else
    public CorporateActionEventProcessingType1FormatChoice_? EventProcessingType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the underlying financial instrument, ie, the financial instrument affected by the corporate action event.
    /// </summary>
    [IsoId("_Td6PUdp-Ed-ak6NoX_4Aeg_-1593018755")]
    [DisplayName("Underlying Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygScty")]
    #endif
    [IsoXmlTag("UndrlygScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentDescription3 UnderlyingSecurity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentDescription3 UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentDescription3 UnderlyingSecurity { get; init; } 
    #else
    public FinancialInstrumentDescription3 UnderlyingSecurity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
