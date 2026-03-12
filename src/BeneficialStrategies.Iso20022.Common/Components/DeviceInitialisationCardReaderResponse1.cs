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
[IsoId("_4gUzkN7HEeiwsev40qZGEQ")]
[DisplayName("Device Initialisation Card Reader Response")]
public partial record DeviceInitialisationCardReaderResponse1
{
    #nullable enable
    
    /// <summary>
    /// Payment instrument entry mode requested by the Sale System.
    /// </summary>
    [IsoId("__WHmsN7HEeiwsev40qZGEQ")]
    [DisplayName("Card Entry Mode")]
    [IsoXmlTag("CardNtryMd")]
    public CardDataReading6Code? CardEntryMode { get; init; } 
    
    /// <summary>
    /// Data of a Chip Card related to the reset of the chip.
    /// </summary>
    [IsoId("_RV7bMN7IEeiwsev40qZGEQ")]
    [DisplayName("ICC Reset Data")]
    [IsoXmlTag("ICCRstData")]
    public ICCResetData1? ICCResetData { get; init; } 
    
    /// <summary>
    /// Additional information about the Device Initialisation Card Reader Response.
    /// </summary>
    [IsoId("_40q80O12Eei-V5h0ja04AA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
