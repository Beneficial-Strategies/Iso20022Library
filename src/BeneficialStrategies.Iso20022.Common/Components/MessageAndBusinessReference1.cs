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
/// Information about the message reference of the message for which the status is requested and the business reference of the transfer instruction.
/// </summary>
[IsoId("_VFeqFtp-Ed-ak6NoX_4Aeg_1197711929")]
[DisplayName("Message And Business Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MessageAndBusinessReference1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MessageAndBusinessReference1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MessageAndBusinessReference1( AdditionalReference2 reqPreviousReference,AdditionalReference2 reqOtherReference )
    {
        PreviousReference = reqPreviousReference;
        OtherReference = reqOtherReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_VFeqF9p-Ed-ak6NoX_4Aeg_-1666036339")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReference2 PreviousReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalReference2 PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2 PreviousReference { get; init; } 
    #else
    public AdditionalReference2 PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or the reference of a system.
    /// </summary>
    [IsoId("_VFeqGNp-Ed-ak6NoX_4Aeg_-1664186882")]
    [DisplayName("Other Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRef")]
    #endif
    [IsoXmlTag("OthrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReference2 OtherReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalReference2 OtherReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2 OtherReference { get; init; } 
    #else
    public AdditionalReference2 OtherReference { get; set; } 
    #endif
    
    /// <summary>
    /// Investment account information of the transfer message for which the status is requested.
    /// </summary>
    [IsoId("_VFeqGdp-Ed-ak6NoX_4Aeg_-1659762580")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount10? InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount10? InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount10? InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Business reference of the transfer instruction message.
    /// </summary>
    [IsoId("_VFeqGtp-Ed-ak6NoX_4Aeg_1669629363")]
    [DisplayName("Transfer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRef")]
    #endif
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransferReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransferReference { get; init; } 
    #else
    public System.String? TransferReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
