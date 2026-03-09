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
/// Information about the message reference of the message for which the status is requested and the business reference of the order.
/// </summary>
[IsoId("_UvH_lNp-Ed-ak6NoX_4Aeg_-1303328661")]
[DisplayName("Message And Business Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MessageAndBusinessReference2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MessageAndBusinessReference2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MessageAndBusinessReference2( AdditionalReference3 reqOtherReference,AdditionalReference3 reqPreviousReference )
    {
        OtherReference = reqOtherReference;
        PreviousReference = reqPreviousReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    [IsoId("_UvH_ldp-Ed-ak6NoX_4Aeg_1913296890")]
    [DisplayName("Other Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRef")]
    #endif
    [IsoXmlTag("OthrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReference3 OtherReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalReference3 OtherReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3 OtherReference { get; init; } 
    #else
    public AdditionalReference3 OtherReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_UvH_ltp-Ed-ak6NoX_4Aeg_1585446487")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReference3 PreviousReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalReference3 PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3 PreviousReference { get; init; } 
    #else
    public AdditionalReference3 PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_UvH_l9p-Ed-ak6NoX_4Aeg_-1275621169")]
    [DisplayName("Individual Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvOrdrRef")]
    #endif
    [IsoXmlTag("IndvOrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? IndividualOrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IndividualOrderReference { get; init; } 
    #else
    public System.String? IndividualOrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Account information of the order message for which the status is requested.
    /// </summary>
    [IsoId("_UvH_mNp-Ed-ak6NoX_4Aeg_608688577")]
    [DisplayName("Investment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcct")]
    #endif
    [IsoXmlTag("InvstmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount13? InvestmentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount13? InvestmentAccount { get; init; } 
    #else
    public InvestmentAccount13? InvestmentAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
