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
/// Set of elements used to provide detailed information on the acceptance result.
/// </summary>
[IsoId("_RBvu4dp-Ed-ak6NoX_4Aeg_2046006177")]
[DisplayName("Acceptance Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptanceResult6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptanceResult6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptanceResult6( System.String reqAccepted )
    {
        Accepted = reqAccepted;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the mandate request was accepted or rejected.
    /// </summary>
    [IsoId("_RBvu4tp-Ed-ak6NoX_4Aeg_1773632231")]
    [DisplayName("Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Accptd")]
    #endif
    [IsoXmlTag("Accptd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Accepted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Accepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Accepted { get; init; } 
    #else
    public System.String Accepted { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the rejection of a mandate request.
    /// </summary>
    [IsoId("_RBvu49p-Ed-ak6NoX_4Aeg_1929136883")]
    [DisplayName("Reject Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctRsn")]
    #endif
    [IsoXmlTag("RjctRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MandateReason1Choice_? RejectReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateReason1Choice_? RejectReason { get; init; } 
    #else
    public MandateReason1Choice_? RejectReason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the reject reason.
    /// </summary>
    [IsoId("_RBvu5Np-Ed-ak6NoX_4Aeg_-192674430")]
    [DisplayName("Additional Reject Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRjctRsnInf")]
    #endif
    [IsoXmlTag("AddtlRjctRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AdditionalRejectReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalRejectReasonInformation { get; init; } 
    #else
    public System.String? AdditionalRejectReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
