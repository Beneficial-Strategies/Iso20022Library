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
/// Provides the identification of the collateral message cancellation request.
/// </summary>
[IsoId("_QmevMNp-Ed-ak6NoX_4Aeg_386196874")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Reference16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Reference16( System.String reqCollateralMessageCancellationRequestIdentification )
    {
        CollateralMessageCancellationRequestIdentification = reqCollateralMessageCancellationRequestIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the collateral message cancellation request.
    /// </summary>
    [IsoId("_QmevMdp-Ed-ak6NoX_4Aeg_2144150903")]
    [DisplayName("Collateral Message Cancellation Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollMsgCxlReqId")]
    #endif
    [IsoXmlTag("CollMsgCxlReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CollateralMessageCancellationRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CollateralMessageCancellationRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CollateralMessageCancellationRequestIdentification { get; init; } 
    #else
    public System.String CollateralMessageCancellationRequestIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
