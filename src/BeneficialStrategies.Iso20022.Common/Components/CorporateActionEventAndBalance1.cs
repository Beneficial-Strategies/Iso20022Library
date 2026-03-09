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
[IsoId("_QzTDMNp-Ed-ak6NoX_4Aeg_-397940404")]
[DisplayName("Corporate Action Event And Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionEventAndBalance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionEventAndBalance1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionEventAndBalance1( EventInformation1 reqGeneralInformation,UnderlyingSecurity1 reqUnderlyingSecurity )
    {
        GeneralInformation = reqGeneralInformation;
        UnderlyingSecurity = reqUnderlyingSecurity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides general information related to a corporate action event.
    /// </summary>
    [IsoId("_QzTDMdp-Ed-ak6NoX_4Aeg_1318887598")]
    [DisplayName("General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlInf")]
    #endif
    [IsoXmlTag("GnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EventInformation1 GeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EventInformation1 GeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventInformation1 GeneralInformation { get; init; } 
    #else
    public EventInformation1 GeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_QzTDMtp-Ed-ak6NoX_4Aeg_847952146")]
    [DisplayName("Underlying Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygScty")]
    #endif
    [IsoXmlTag("UndrlygScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingSecurity1 UnderlyingSecurity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingSecurity1 UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingSecurity1 UnderlyingSecurity { get; init; } 
    #else
    public UnderlyingSecurity1 UnderlyingSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the balance related to a corporate action.
    /// </summary>
    [IsoId("_QzTDM9p-Ed-ak6NoX_4Aeg_-715240098")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionBalanceDetails4? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionBalanceDetails4? Balance { get; init; } 
    #else
    public CorporateActionBalanceDetails4? Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information related to the event and the balance of the corporate action.
    /// </summary>
    [IsoId("_QzTDNNp-Ed-ak6NoX_4Aeg_496694477")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension2? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension2? Extension { get; init; } 
    #else
    public Extension2? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}
