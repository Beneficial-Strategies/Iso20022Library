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
/// References linked to the trade leg notification cancellation message.
/// </summary>
[IsoId("_QllXVdp-Ed-ak6NoX_4Aeg_2009700024")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Reference18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Reference18( System.String reqTradeLegIdentification )
    {
        TradeLegIdentification = reqTradeLegIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Allocated by the central counterparty - central counterparty trade leg reference identification that uniquely identifies the trade.
    /// </summary>
    [IsoId("_QllXVtp-Ed-ak6NoX_4Aeg_705272339")]
    [DisplayName("Trade Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradLegId")]
    #endif
    [IsoXmlTag("TradLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TradeLegIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TradeLegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradeLegIdentification { get; init; } 
    #else
    public System.String TradeLegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the message previously sent by the central counterparty.
    /// </summary>
    [IsoId("_QllXV9p-Ed-ak6NoX_4Aeg_545464198")]
    [DisplayName("Previous Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsMsgId")]
    #endif
    [IsoXmlTag("PrvsMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PreviousMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreviousMessageIdentification { get; init; } 
    #else
    public System.String? PreviousMessageIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
