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
/// Provides information about the account that is impacted or not by the standing instruction.
/// </summary>
[IsoId("_QUmVCNp-Ed-ak6NoX_4Aeg_1997970663")]
[DisplayName("Included Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IncludedAccount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IncludedAccount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IncludedAccount1( System.String reqSecuritiesAccountIdentification,System.String reqIncludedIndicator )
    {
        SecuritiesAccountIdentification = reqSecuritiesAccountIdentification;
        IncludedIndicator = reqIncludedIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_QUwGANp-Ed-ak6NoX_4Aeg_-2068886946")]
    [DisplayName("Securities Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcctId")]
    #endif
    [IsoXmlTag("SctiesAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SecuritiesAccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SecuritiesAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SecuritiesAccountIdentification { get; init; } 
    #else
    public System.String SecuritiesAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account is impacted or not by the standing instruction.||Yes = The account is impacted by the standing instruction.|No = The account is not impacted by the standing instruction.
    /// </summary>
    [IsoId("_QUwGAdp-Ed-ak6NoX_4Aeg_-2068886937")]
    [DisplayName("Included Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InclInd")]
    #endif
    [IsoXmlTag("InclInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator IncludedIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IncludedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IncludedIndicator { get; init; } 
    #else
    public System.String IncludedIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
