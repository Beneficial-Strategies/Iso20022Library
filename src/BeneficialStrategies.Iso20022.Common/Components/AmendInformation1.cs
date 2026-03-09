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
/// Information specific to an amendment or cancellation.
/// </summary>
[IsoId("_RVa40tp-Ed-ak6NoX_4Aeg_-1270467118")]
[DisplayName("Amend Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmendInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmendInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmendInformation1( MessageIdentification reqPreviousReference,System.String reqReconfirmInstructions )
    {
        PreviousReference = reqPreviousReference;
        ReconfirmInstructions = reqReconfirmInstructions;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the linked message which was previously sent.
    /// </summary>
    [IsoId("_RVa409p-Ed-ak6NoX_4Aeg_1071515411")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification PreviousReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification PreviousReference { get; init; } 
    #else
    public MessageIdentification PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether instructions must be resent (in case of modification of the parameters of a meeting for which instructions have already been sent).
    /// </summary>
    [IsoId("_RVa41Np-Ed-ak6NoX_4Aeg_-1270467116")]
    [DisplayName("Reconfirm Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcnfrmInstrs")]
    #endif
    [IsoXmlTag("RcnfrmInstrs")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ReconfirmInstructions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReconfirmInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReconfirmInstructions { get; init; } 
    #else
    public System.String ReconfirmInstructions { get; set; } 
    #endif
    
    
    #nullable disable
    
}
