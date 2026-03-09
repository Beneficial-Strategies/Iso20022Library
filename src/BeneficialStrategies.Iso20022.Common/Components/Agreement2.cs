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
/// Agreement details for the over the counter market.
/// </summary>
[IsoId("_Un-Otdp-Ed-ak6NoX_4Aeg_-902133760")]
[DisplayName("Agreement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Agreement2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Agreement2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Agreement2( System.String reqAgreementDetails,System.DateOnly reqAgreementDate,string reqBaseCurrency )
    {
        AgreementDetails = reqAgreementDetails;
        AgreementDate = reqAgreementDate;
        BaseCurrency = reqBaseCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Full details of the supporting legal agreement under which the margin call can be issued and/or governed.
    /// </summary>
    [IsoId("_Un-Ottp-Ed-ak6NoX_4Aeg_-898359592")]
    [DisplayName("Agreement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrmtDtls")]
    #endif
    [IsoXmlTag("AgrmtDtls")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text AgreementDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AgreementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AgreementDetails { get; init; } 
    #else
    public System.String AgreementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Common reference to the agreement between the two counterparties.
    /// </summary>
    [IsoId("_Un-Ot9p-Ed-ak6NoX_4Aeg_-1464759032")]
    [DisplayName("Agreement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrmtId")]
    #endif
    [IsoXmlTag("AgrmtId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AgreementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AgreementIdentification { get; init; } 
    #else
    public System.String? AgreementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the collateral agreement was signed.
    /// </summary>
    [IsoId("_Un-OuNp-Ed-ak6NoX_4Aeg_-508672237")]
    [DisplayName("Agreement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrmtDt")]
    #endif
    [IsoXmlTag("AgrmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate AgreementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly AgreementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly AgreementDate { get; init; } 
    #else
    public System.DateOnly AgreementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Denomination currency as specified in the collateral agreement.
    /// </summary>
    [IsoId("_Un-Oudp-Ed-ak6NoX_4Aeg_1780700591")]
    [DisplayName("Base Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BaseCcy")]
    #endif
    [IsoXmlTag("BaseCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyCode BaseCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string BaseCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string BaseCurrency { get; init; } 
    #else
    public string BaseCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying master agreement.
    /// </summary>
    [IsoId("_Un-Outp-Ed-ak6NoX_4Aeg_1837622011")]
    [DisplayName("Agreement Framework")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrmtFrmwk")]
    #endif
    [IsoXmlTag("AgrmtFrmwk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AgreementFramework1Choice_? AgreementFramework { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreementFramework1Choice_? AgreementFramework { get; init; } 
    #else
    public AgreementFramework1Choice_? AgreementFramework { get; set; } 
    #endif
    
    
    #nullable disable
    
}
