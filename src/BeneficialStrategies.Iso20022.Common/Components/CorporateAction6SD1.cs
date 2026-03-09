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
/// Extension for mergers.
/// </summary>
[IsoId("_yeONwFPNEeG1_c7AazzqRQ")]
[DisplayName("Corporate Action 6 SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateAction6SD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_9xiVEFPNEeG1_c7AazzqRQ")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about mergers.
    /// </summary>
    [IsoId("_Cmb7kFPbEeG1qPPaW9KJvg")]
    [DisplayName("Merger Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgrDtls")]
    #endif
    [IsoXmlTag("MrgrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MergerDetailsType1? MergerDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MergerDetailsType1? MergerDetails { get; init; } 
    #else
    public MergerDetailsType1? MergerDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement of the target company.
    /// TargetCompanyAgreement should only be used for corporate action event type code TEND. It is not necessary for corporate action event type code BIDS. 
    ///  対象会社の同意の有無
    /// 公開買付のときのみ。（自己株買付のときは無し）.
    /// </summary>
    [IsoId("_Glt4hWzdEeGa9q9Mq4E7uA")]
    [DisplayName("Target Company Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrgtCpnyAgrmt")]
    #endif
    [IsoXmlTag("TrgtCpnyAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetCompanyAgreementCode? TargetCompanyAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetCompanyAgreementCode? TargetCompanyAgreement { get; init; } 
    #else
    public TargetCompanyAgreementCode? TargetCompanyAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of new shares to be issued.
    /// 発行新株式数.
    /// </summary>
    [IsoId("_KOn45WzdEeGa9q9Mq4E7uA")]
    [DisplayName("Total Number Of New Shares Issued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfNewShrsIssd")]
    #endif
    [IsoXmlTag("TtlNbOfNewShrsIssd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? TotalNumberOfNewSharesIssued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? TotalNumberOfNewSharesIssued { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? TotalNumberOfNewSharesIssued { get; set; } 
    #endif
    
    
    #nullable disable
    
}
