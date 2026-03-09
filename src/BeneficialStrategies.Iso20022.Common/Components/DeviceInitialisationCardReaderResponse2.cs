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
[IsoId("_UyZdUQ0cEeqUVL7sB4m7NA")]
[DisplayName("Device Initialisation Card Reader Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceInitialisationCardReaderResponse2
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
    [IsoId("_U9zcEQ0cEeqUVL7sB4m7NA")]
    [DisplayName("Card Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardNtryMd")]
    #endif
    [IsoXmlTag("CardNtryMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading8Code? CardEntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading8Code? CardEntryMode { get; init; } 
    #else
    public CardDataReading8Code? CardEntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Data of a Chip Card related to the reset of the chip.
    /// </summary>
    [IsoId("_U9zcEw0cEeqUVL7sB4m7NA")]
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
    [IsoId("_U9zcFQ0cEeqUVL7sB4m7NA")]
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
