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
/// Details of the amendment.
/// </summary>
[IsoId("_9_wDcHltEeG7BsjMvd1mEw_-868509945")]
[DisplayName("Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amendment9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Amendment9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Amendment9( UndertakingAmendmentResponseMessage1 reqUndertakingAmendmentResponseMessage )
    {
        UndertakingAmendmentResponseMessage = reqUndertakingAmendmentResponseMessage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contents of the related UndertakingAmendmentResponse message.
    /// </summary>
    [IsoId("_9_wDcXltEeG7BsjMvd1mEw_-1238548049")]
    [DisplayName("Undertaking Amendment Response Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgAmdmntRspnMsg")]
    #endif
    [IsoXmlTag("UdrtkgAmdmntRspnMsg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingAmendmentResponseMessage1 UndertakingAmendmentResponseMessage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingAmendmentResponseMessage1 UndertakingAmendmentResponseMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingAmendmentResponseMessage1 UndertakingAmendmentResponseMessage { get; init; } 
    #else
    public UndertakingAmendmentResponseMessage1 UndertakingAmendmentResponseMessage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
