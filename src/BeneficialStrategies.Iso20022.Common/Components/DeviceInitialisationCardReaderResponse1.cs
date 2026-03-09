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
/// Content of the Device Initialisation Card Reader Response message.
/// </summary>
[IsoId("_4gUzkN7HEeiwsev40qZGEQ")]
[DisplayName("Device Initialisation Card Reader Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceInitialisationCardReaderResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Payment instrument entry mode requested by the Sale System.
    /// </summary>
    [IsoId("__WHmsN7HEeiwsev40qZGEQ")]
    [DisplayName("Card Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardNtryMd")]
    #endif
    [IsoXmlTag("CardNtryMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading6Code? CardEntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading6Code? CardEntryMode { get; init; } 
    #else
    public CardDataReading6Code? CardEntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Data of a Chip Card related to the reset of the chip.
    /// </summary>
    [IsoId("_RV7bMN7IEeiwsev40qZGEQ")]
    [DisplayName("ICC Reset Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ICCRstData")]
    #endif
    [IsoXmlTag("ICCRstData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ICCResetData1? ICCResetData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ICCResetData1? ICCResetData { get; init; } 
    #else
    public ICCResetData1? ICCResetData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the Device Initialisation Card Reader Response.
    /// </summary>
    [IsoId("_40q80O12Eei-V5h0ja04AA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10000Binary? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? AdditionalInformation { get; init; } 
    #else
    public System.Byte[]? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
