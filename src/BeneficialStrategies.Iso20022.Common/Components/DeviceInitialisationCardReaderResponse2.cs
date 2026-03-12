// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Device Initialisation Card Reader Response message.
/// </summary>
[IsoId("_UyZdUQ0cEeqUVL7sB4m7NA")]
[DisplayName("Device Initialisation Card Reader Response")]
public partial record DeviceInitialisationCardReaderResponse2
{
    #nullable enable
    
    /// <summary>
    /// Payment instrument entry mode requested by the Sale System.
    /// </summary>
    [IsoId("_U9zcEQ0cEeqUVL7sB4m7NA")]
    [DisplayName("Card Entry Mode")]
    [IsoXmlTag("CardNtryMd")]
    public CardDataReading8Code? CardEntryMode { get; init; } 
    
    /// <summary>
    /// Data of a Chip Card related to the reset of the chip.
    /// </summary>
    [IsoId("_U9zcEw0cEeqUVL7sB4m7NA")]
    [DisplayName("ICC Reset Data")]
    [IsoXmlTag("ICCRstData")]
    public ICCResetData1? ICCResetData { get; init; } 
    
    /// <summary>
    /// Additional information about the Device Initialisation Card Reader Response.
    /// </summary>
    [IsoId("_U9zcFQ0cEeqUVL7sB4m7NA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
