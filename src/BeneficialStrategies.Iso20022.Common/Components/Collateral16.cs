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
/// Provides details on the collateral that will be either delivered, returned or both.
/// </summary>
[IsoId("_skpwBYpIEeaNTaanBSMWmg")]
[DisplayName("Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Collateral16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Collateral16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Collateral16( System.String reqMarginCallRequestIdentification )
    {
        MarginCallRequestIdentification = reqMarginCallRequestIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call request.
    /// </summary>
    [IsoId("_szYvkYpIEeaNTaanBSMWmg")]
    [DisplayName("Margin Call Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnCallReqId")]
    #endif
    [IsoXmlTag("MrgnCallReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MarginCallRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MarginCallRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MarginCallRequestIdentification { get; init; } 
    #else
    public System.String MarginCallRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call response.
    /// </summary>
    [IsoId("_szYvk4pIEeaNTaanBSMWmg")]
    [DisplayName("Margin Call Response Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnCallRspnId")]
    #endif
    [IsoXmlTag("MrgnCallRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MarginCallResponseIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MarginCallResponseIdentification { get; init; } 
    #else
    public System.String? MarginCallResponseIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the standard settlement instructions.
    /// </summary>
    [IsoId("_szYvlYpIEeaNTaanBSMWmg")]
    [DisplayName("Standard Settlement Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StdSttlmInstrs")]
    #endif
    [IsoXmlTag("StdSttlmInstrs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? StandardSettlementInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StandardSettlementInstructions { get; init; } 
    #else
    public System.String? StandardSettlementInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the collateral proposal response (in case of counter proposal).
    /// </summary>
    [IsoId("_szYvl4pIEeaNTaanBSMWmg")]
    [DisplayName("Collateral Proposal Response Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPrpslRspnId")]
    #endif
    [IsoXmlTag("CollPrpslRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CollateralProposalResponseIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralProposalResponseIdentification { get; init; } 
    #else
    public System.String? CollateralProposalResponseIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Collateral type is securities.
    /// </summary>
    [IsoId("_szYvmYpIEeaNTaanBSMWmg")]
    [DisplayName("Securities Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesColl")]
    #endif
    [IsoXmlTag("SctiesColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesCollateral8? SecuritiesCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesCollateral8? SecuritiesCollateral { get; init; } 
    #else
    public SecuritiesCollateral8? SecuritiesCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Collateral type is cash.
    /// </summary>
    [IsoId("_szYvm4pIEeaNTaanBSMWmg")]
    [DisplayName("Cash Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshColl")]
    #endif
    [IsoXmlTag("CshColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashCollateral3? CashCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashCollateral3? CashCollateral { get; init; } 
    #else
    public CashCollateral3? CashCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Collateral type is other than securities or cash for example letter of credit.
    /// </summary>
    [IsoId("_szYvnYpIEeaNTaanBSMWmg")]
    [DisplayName("Other Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrColl")]
    #endif
    [IsoXmlTag("OthrColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherCollateral5? OtherCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherCollateral5? OtherCollateral { get; init; } 
    #else
    public OtherCollateral5? OtherCollateral { get; set; } 
    #endif
    
    
    #nullable disable
    
}
