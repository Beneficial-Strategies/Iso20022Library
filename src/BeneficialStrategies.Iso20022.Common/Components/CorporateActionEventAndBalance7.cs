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
/// Detailed account holdings information report for a corporate action event.
/// </summary>
[IsoId("_VBONEQ4xEeKVsZQr6J31Tg")]
[DisplayName("Corporate Action Event And Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionEventAndBalance7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionEventAndBalance7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionEventAndBalance7( EventInformation5 reqGeneralInformation,SecurityIdentification14 reqUnderlyingSecurity )
    {
        GeneralInformation = reqGeneralInformation;
        UnderlyingSecurity = reqUnderlyingSecurity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides general information related to a corporate action event.
    /// </summary>
    [IsoId("_VYKtdQ4xEeKVsZQr6J31Tg")]
    [DisplayName("General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlInf")]
    #endif
    [IsoXmlTag("GnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EventInformation5 GeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EventInformation5 GeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventInformation5 GeneralInformation { get; init; } 
    #else
    public EventInformation5 GeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_VYKteQ4xEeKVsZQr6J31Tg")]
    [DisplayName("Underlying Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygScty")]
    #endif
    [IsoXmlTag("UndrlygScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification14 UnderlyingSecurity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification14 UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14 UnderlyingSecurity { get; init; } 
    #else
    public SecurityIdentification14 UnderlyingSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the balance related to a corporate action.
    /// </summary>
    [IsoId("_VYKtgw4xEeKVsZQr6J31Tg")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionBalanceDetails9? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionBalanceDetails9? Balance { get; init; } 
    #else
    public CorporateActionBalanceDetails9? Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information related to the event and the balance of the corporate action.
    /// </summary>
    [IsoId("_VYKtjQ4xEeKVsZQr6J31Tg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
