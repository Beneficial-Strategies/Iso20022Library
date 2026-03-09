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
/// Identifies the mandate, which is being accepted.
/// </summary>
[IsoId("_RBmk9tp-Ed-ak6NoX_4Aeg_-1832843790")]
[DisplayName("Mandate Acceptance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateAcceptance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MandateAcceptance1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MandateAcceptance1( AcceptanceResult6 reqAcceptanceResult,OriginalMandate1Choice_ reqOriginalMandate )
    {
        AcceptanceResult = reqAcceptanceResult;
        OriginalMandate = reqOriginalMandate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    [IsoId("_RBmk99p-Ed-ak6NoX_4Aeg_-184360758")]
    [DisplayName("Original Message Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgInf")]
    #endif
    [IsoXmlTag("OrgnlMsgInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    #else
    public OriginalMessageInformation1? OriginalMessageInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide detailed information on the acceptance result.
    /// </summary>
    [IsoId("_RBmk-Np-Ed-ak6NoX_4Aeg_-2005150257")]
    [DisplayName("Acceptance Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptncRslt")]
    #endif
    [IsoXmlTag("AccptncRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptanceResult6 AcceptanceResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptanceResult6 AcceptanceResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptanceResult6 AcceptanceResult { get; init; } 
    #else
    public AcceptanceResult6 AcceptanceResult { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide the original mandate data.
    /// </summary>
    [IsoId("_RBvu4Np-Ed-ak6NoX_4Aeg_-557460763")]
    [DisplayName("Original Mandate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMndt")]
    #endif
    [IsoXmlTag("OrgnlMndt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalMandate1Choice_ OriginalMandate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalMandate1Choice_ OriginalMandate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMandate1Choice_ OriginalMandate { get; init; } 
    #else
    public OriginalMandate1Choice_ OriginalMandate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
