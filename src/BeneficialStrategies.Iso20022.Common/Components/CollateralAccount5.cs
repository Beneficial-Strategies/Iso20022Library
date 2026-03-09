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
/// Operational construct used by a central counterparty to record ownership of assets posted as collateral by clearing members to meet their obligations at the central counterparty.
/// </summary>
[IsoId("_hcja4XYAEee_qcLXasnA4g")]
[DisplayName("Collateral Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralAccount5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralAccount5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralAccount5( PartyIdentification118Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifer for the collateral account.
    /// </summary>
    [IsoId("_hlIvIXYAEee_qcLXasnA4g")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification118Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification118Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification118Choice_ Identification { get; init; } 
    #else
    public PartyIdentification118Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Operational construct used to record the set of positions whose margin requirements is calculated on a gross basis.
    /// </summary>
    [IsoId("_EPbHcHYCEee_qcLXasnA4g")]
    [DisplayName("Related Margin Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdMrgnAcct")]
    #endif
    [IsoXmlTag("RltdMrgnAcct")]
    public ValueList<MarginAccount1> RelatedMarginAccount { get; init; } = new ValueList<MarginAccount1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _EPbHcHYCEee_qcLXasnA4g
    
    /// <summary>
    /// Indicates whether the account can be used for clients of UK FCA authorised firms subject to Title Transfer Collateral Arrangements (TTCA).
    /// </summary>
    [IsoId("_GuWoAHYCEee_qcLXasnA4g")]
    [DisplayName("Title Transfer Collateral Arrangement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TitlTrfCollArrgmnt")]
    #endif
    [IsoXmlTag("TitlTrfCollArrgmnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TitleTransferCollateralArrangement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TitleTransferCollateralArrangement { get; init; } 
    #else
    public System.String? TitleTransferCollateralArrangement { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the client collateral is segregated by value in accordance with local regulations. Usage: In the context of clearing members with US clients, in accordance with Section 4d(a)(2) of the Commodity Exchange Act.
    /// </summary>
    [IsoId("_JNSIkHYCEee_qcLXasnA4g")]
    [DisplayName("Collateral Segregation By Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSgrtnByVal")]
    #endif
    [IsoXmlTag("CollSgrtnByVal")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CollateralSegregationByValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralSegregationByValue { get; init; } 
    #else
    public System.String? CollateralSegregationByValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
