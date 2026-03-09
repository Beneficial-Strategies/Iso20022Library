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
/// Provides more details on the response such as the response type, the collateral identification, and optionally further details in case of rejection.
/// </summary>
[IsoId("_tKLROYpDEeaNTaanBSMWmg")]
[DisplayName("Cash Collateral Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashCollateralResponse2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashCollateralResponse2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashCollateralResponse2( Status4Code reqResponseType )
    {
        ResponseType = reqResponseType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the status of the collateral proposal.
    /// </summary>
    [IsoId("_tYmuw4pDEeaNTaanBSMWmg")]
    [DisplayName("Response Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnTp")]
    #endif
    [IsoXmlTag("RspnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status4Code ResponseType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status4Code ResponseType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status4Code ResponseType { get; init; } 
    #else
    public Status4Code ResponseType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    [IsoId("_tYmuxYpDEeaNTaanBSMWmg")]
    [DisplayName("Collateral Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollId")]
    #endif
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CollateralIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralIdentification { get; init; } 
    #else
    public System.String? CollateralIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    [IsoId("_tYmux4pDEeaNTaanBSMWmg")]
    [DisplayName("Asset Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstNb")]
    #endif
    [IsoXmlTag("AsstNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AssetNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssetNumber { get; init; } 
    #else
    public System.String? AssetNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_tYmuyYpDEeaNTaanBSMWmg")]
    [DisplayName("Cash Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctId")]
    #endif
    [IsoXmlTag("CshAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? CashAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? CashAccountIdentification { get; init; } 
    #else
    public AccountIdentification4Choice_? CashAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    [IsoId("_tYmuy4pDEeaNTaanBSMWmg")]
    [DisplayName("Rejection Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnRsn")]
    #endif
    [IsoXmlTag("RjctnRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RejectionReasonV021Code? RejectionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionReasonV021Code? RejectionReason { get; init; } 
    #else
    public RejectionReasonV021Code? RejectionReason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information regarding why the collateral proposal has a rejected status.
    /// </summary>
    [IsoId("_tYmuzYpDEeaNTaanBSMWmg")]
    [DisplayName("Rejection Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnInf")]
    #endif
    [IsoXmlTag("RjctnInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RejectionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RejectionInformation { get; init; } 
    #else
    public System.String? RejectionInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
