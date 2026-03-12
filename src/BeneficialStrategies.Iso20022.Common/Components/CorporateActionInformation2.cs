// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
[IsoId("_Td6PVdp-Ed-ak6NoX_4Aeg_2005876121")]
[DisplayName("Corporate Action Information")]
public partial record CorporateActionInformation2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the issuer&apos;s agent or the issuer.
    /// </summary>
    [IsoId("_Td6PVtp-Ed-ak6NoX_4Aeg_-1997258841")]
    [DisplayName("Agent Identification")]
    [IsoXmlTag("AgtId")]
    public required PartyIdentification2Choice_ AgentIdentification { get; init; } 
    
    /// <summary>
    /// Reference given to the event by the CA event issuer (agent).
    /// </summary>
    [IsoId("_Td6PV9p-Ed-ak6NoX_4Aeg_-561952179")]
    [DisplayName("Issuer Corporate Action Identification")]
    [IsoXmlTag("IssrCorpActnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text IssuerCorporateActionIdentification { get; init; } 
    
    /// <summary>
    /// Reference assigned by the (I)CSD to unambiguously identify a corporate avent.
    /// </summary>
    [IsoId("_Td6PWNp-Ed-ak6NoX_4Aeg_-1997259025")]
    [DisplayName("Corporate Action Processing Identification")]
    [IsoXmlTag("CorpActnPrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CorporateActionProcessingIdentification { get; init; } 
    
    /// <summary>
    /// Speficies the type of corporate event.
    /// </summary>
    [IsoId("_Td6PWdp-Ed-ak6NoX_4Aeg_-1997258964")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public required CorporateActionEventType2FormatChoice_ EventType { get; init; } 
    
    /// <summary>
    /// Type of processing involved by a Corporate Action.
    /// </summary>
    [IsoId("_Td6PWtp-Ed-ak6NoX_4Aeg_-1997258933")]
    [DisplayName("Event Processing Type")]
    [IsoXmlTag("EvtPrcgTp")]
    public CorporateActionEventProcessingType1FormatChoice_? EventProcessingType { get; init; } 
    
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_Td6PW9p-Ed-ak6NoX_4Aeg_-1997258902")]
    [DisplayName("Mandatory Voluntary Event Type")]
    [IsoXmlTag("MndtryVlntryEvtTp")]
    public required CorporateActionMandatoryVoluntary1FormatChoice_ MandatoryVoluntaryEventType { get; init; } 
    
    /// <summary>
    /// Identification of the underlying financial instrument, ie, the financial instrument affected by the corporate action event.
    /// </summary>
    [IsoId("_TeEAUNp-Ed-ak6NoX_4Aeg_-1997258872")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required FinancialInstrumentDescription3 UnderlyingSecurity { get; init; } 
    
    /// <summary>
    /// Identification of the secondary underlying financial instrument, ie, the non-principal financial instrument affected by the corporate action event.
    /// </summary>
    [IsoId("_TeEAUdp-Ed-ak6NoX_4Aeg_301729875")]
    [DisplayName("Other Underlying Security")]
    [IsoXmlTag("OthrUndrlygScty")]
    public FinancialInstrumentDescription3? OtherUnderlyingSecurity { get; init; } 
    
    
    #nullable disable
    
}
