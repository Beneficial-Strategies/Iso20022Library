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
/// Identifies the status of a quote and the rejection reason if required.
/// </summary>
[IsoId("_Q9IUqNp-Ed-ak6NoX_4Aeg_1434126655")]
[DisplayName("Quote Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QuoteStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a QuoteStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public QuoteStatus1( QuoteStatus1Code reqQuoteStatus )
    {
        QuoteStatus = reqQuoteStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information related to the status of a quote.
    /// </summary>
    [IsoId("_Q9IUqdp-Ed-ak6NoX_4Aeg_-1311303659")]
    [DisplayName("Quote Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtSts")]
    #endif
    [IsoXmlTag("QtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QuoteStatus1Code QuoteStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QuoteStatus1Code QuoteStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuoteStatus1Code QuoteStatus { get; init; } 
    #else
    public QuoteStatus1Code QuoteStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information related to the rejection of the quote.
    /// </summary>
    [IsoId("_Q9SFodp-Ed-ak6NoX_4Aeg_111978599")]
    [DisplayName("Rejection Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnRsn")]
    #endif
    [IsoXmlTag("RjctnRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RejectionReason3Code? RejectionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionReason3Code? RejectionReason { get; init; } 
    #else
    public RejectionReason3Code? RejectionReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
